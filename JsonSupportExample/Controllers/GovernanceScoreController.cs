using JsonSupportExample.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace JsonSupportExample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GovernanceScoreController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetScore(string country)
        {
            country = "npl";
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "http://api.worldbank.org/countries/{country}/indicators/CC.EST;GE.EST;PV.EST;RL.EST;RQ.EST;VA.EST?mrv=5&format=json&source=3&gapfill=Y");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<List<object>>(content);
            var pages = JsonConvert.DeserializeObject<GovernanceEntity>(data[0].ToString());
            var indicators = JsonConvert.DeserializeObject<List<Item>>(data[1].ToString());
            var value = indicators.Select(x => x.Value);
            if (value.Count() == 30)
            {
                double sum = value.Sum();
                var avg = sum / 6;
                return Ok(avg);
            }
            return BadRequest("The selected zone in the country does not have at least five years of data for one of the World Governance Indicators (WGI's). Unfortunately, the project is not eligible for CCS projects under the VCS program in this zone.");
        }
    }
}

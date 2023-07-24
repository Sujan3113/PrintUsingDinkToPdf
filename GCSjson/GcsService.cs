
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace GCSjson
{
    public class GcsService : IGcsService
    {
        private readonly AppDbContext _context;
        public GcsService(AppDbContext context)
        {
            _context = context;
        }

        /*public async Task AddGcs()
        {
            var data = new Gcs()
            {
                Id = 1,
                Template = @"{
                      ""gcsToolTemplates"": [
                        {
                          ""riskCategory"": ""Regulatory Framework Risk (RFR)"",
                          ""riskSubCategory"": """",
                          ""validator"": {
                            ""required"": true,
                            ""identifiers"": [
                              ""a"",
                              ""b""
                            ],
                            ""logic"": ""AND""
                          },
                          ""riskFactors"": [
                            {
                              ""identifier"": ""1"",
                              ""label"": ""The jurisdiction has in place a regulatory framework that affords priority to a CO2 storage project in the event of any competing   pore space resource use, such as oil and gas production activities, other waste disposal activities, gas storage, geothermal energy, mineral brine exploration, and development, or other resource activities."",
                              ""score"": 0,
                              ""inputType"": ""radio"",
                              ""inputName"": ""a"",
                              ""hasFileUpload"": false
                            },
                            {
                              ""identifier"": ""2"",
                              ""label"": ""The jurisdiction does not have in place a regulatory framework that affords priority to a CO2 storage project in the event of any competing pore space resource use, such as oil and gas production activities, other waste disposal activities, gas storage, geothermal energy, mineral brine exploration, and development or other resource activities."",
                              ""score"": 0.125,
                              ""inputType"": ""radio"",
                              ""inputName"": ""a"",
                              ""hasFileUpload"": false
                            },
                            {
                              ""identifier"": ""3"",
                              ""label"": ""A legislative or regulatory rule providing for the transfer of both climate and remedial liability is in place"",
                              ""score"": 0,
                              ""inputType"": ""radio"",
                              ""inputName"": ""b"",
                              ""hasFileUpload"": false
                            },
                            {
                              ""identifier"": ""4"",
                              ""label"": ""A legislative or regulatory rule providing for the transfer of remedial liability or climate liability (but not both) is in place."",
                              ""score"": 0.0625,
                              ""inputType"": ""radio"",
                              ""inputName"": ""b"",
                              ""hasFileUpload"": false
                            },
                            {
                              ""identifier"": ""5"",
                              ""label"": ""There is no legislative or regulatory rule providing for the transfer of liability."",
                              ""score"": 0.125,
                              ""inputType"": ""radio"",
                              ""inputName"": ""b"",
                              ""hasFileUpload"": false
                            }
                          ],
                          ""calculations"": [
                            {
                              ""identifier"": ""total-regulatory-framework-risk"",
                              ""label"": ""Total Regulatory Framework Risk (RFR) = a + b"",
                              ""calculation"": [
                                {
                                  ""type"": ""options"",
                                  ""identifier"": ""a"",
                                  ""operation"": ""+""
                                },
                                {
                                  ""type"": ""options"",
                                  ""identifier"": ""b"",
                                  ""operation"": ""+""
                                }
                              ]
                            }
                          ]
                        },
                        {
                          ""riskCategory"": ""Political Risk"",
                          ""riskSubCategory"": """",
                          ""validator"": {
                            ""required"": true,
                            ""identifiers"": [
                              ""a""
                            ],
                            ""logic"": ""AND""
                          },
                          ""riskFactors"": [
                            {
                              ""identifier"": ""1"",
                              ""label"": ""Governance score of 0.82 or higher"",
                              ""score"": 0,
                              ""inputType"": ""radio"",
                              ""inputName"": ""a"",
                              ""hasFileUpload"": true
                            },
                            {
                              ""identifier"": ""2"",
                              ""label"": ""Governance score of 0.19 to less than 0.82"",
                              ""score"": 0.25,
                              ""inputType"": ""radio"",
                              ""inputName"": ""a"",
                              ""hasFileUpload"": true
                            },
                            {
                              ""identifier"": ""3"",
                              ""label"": ""Governance score of −0.32 to less than 0.19"",
                              ""score"": 0.5,
                              ""inputType"": ""radio"",
                              ""inputName"": ""a"",
                              ""hasFileUpload"": true
                            },
                            {
                              ""identifier"": ""4"",
                              ""label"": ""Governance score of −0.79 to less than −0.32"",
                              ""score"": 2,
                              ""inputType"": ""radio"",
                              ""inputName"": ""a"",
                              ""hasFileUpload"": true
                            },
                            {
                              ""identifier"": ""5"",
                              ""label"": ""Governance score of less than −0.79"",
                              ""score"": 4,
                              ""inputType"": ""radio"",
                              ""inputName"": ""a"",
                              ""hasFileUpload"": true
                            }
                          ],
                          ""calculations"": [
                            {
                              ""identifier"": ""political risk"",
                              ""label"": ""Total Political Risk (PR) = a"",
                              ""minValue"": 0,
                              ""calculation"": [
                                {
                                  ""type"": ""options"",
                                  ""identifier"": ""a"",
                                  ""operation"": """"
                                }
                              ]
                            }
                          ]
                        }
                      ]
                    }"
            };
            await _context.GcsTemplate.AddAsync(data);
            await _context.SaveChangesAsync();

        }*/

        public async Task GetGcs()
        {/*
            var data=_context.GcsTemplate.ToList();
            var template = data.Select(x => new
            {
                Id = x.Id,
                Template = JsonConvert.DeserializeObject<Root>(x.Template)
            });
            await Console.Out.WriteLineAsync(template);*/
        }
    }
}

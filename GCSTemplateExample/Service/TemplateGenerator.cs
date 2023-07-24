using System.Text;

namespace GCSTemplateExample.Service
{
    public class TemplateGenerator
    {
        public async static Task<string> GetKPIDetailsPDFHTMLString()
        {
            string FullName = "Sujan Bhujel";
            var OrganizationUnit = 7;
            var currentYear=DateTime.Now;
            var JobPosition = "abc";
            var Manager = "Sujan";
            StringBuilder builder = new StringBuilder();
            builder.Append(
                            $"<!DOCTYPE html><html lang='en'>" +
                            $"<head>" +
                            $"<meta charset='UTF-8'>" +
                            $"<meta name='viewport' content='width=device-width, initial-scale=1.0'>" +
                            $"<meta http-equiv='X-UA-Compatible' content='ie=edge'>" +
                            $"<title>KPI Settings</title>" +
                            $"<style type='text/css'>" +
                            "body{max-width:768px;margin:0 auto;font-family:verdana;font-size:14px}.username{font-weight:600}.username span{font-size:14px;color:#622691;letter-spacing:-.47px;background-color:rgba(98,38,145,.12);padding:2px 10px}h2.title{font-size:20px;padding-bottom:10px;border-bottom:1px solid #e3e3e3}h4{font-size:16px;padding:10px;background-color:#e4e4e4;margin-top:30px}p{margin:0}.title{font-weight:600}.padding-15{padding:15px 0}span.num{background-color:#919191;color:#fff;border-radius:4px;max-height:30px;max-width:30px;text-align:center;padding:5px;}.space-between{justify-content:space-between}.flex-row{display:flex;flex-wrap:wrap}.behaviour-wrap .comment-wrapper>p.title,.challenge{margin-top:10px},.individual-kpi{margin-bottom:30px}.smart-kpi{border-bottom:1px solid #e3e3e3}.smart-kpi p{margin-bottom:10px}.smart-kpi div{color:#a7a7a7;margin-bottom:5px}.smart-kpi .weight-bar{text-transform:capitalize}.smart-kpi .weight-bar b:first-of-type{font-weight:400;margin-right:10px}.tag{background-color:rgba(238,34,128,.12);color:#ee2280;padding:1px 15px;border:none;display:inline-block;border-radius:20px;margin-left:8px;font-weight:600;font-size:13px;outline:0;min-height:auto}.tag.green{color:#1daa5f;background-color:rgba(29,170,95,.12)}.expectation{padding-top:10px}.expectation>div{margin-bottom:15px}.expectation span{color:#a7a7a7}.expectation p{font-weight:600}.expectation p.title{margin-bottom:10px}.expectation p.descriptor{font-weight:300;margin-top:5px}.comment-wrapper .comment{border-top:1px solid #e3e3e3;border-bottom:1px solid #e3e3e3;margin:10px 0;padding:10px 0}.comment-wrapper .comment span{color:#757575;font-size:12px;font-weight:400}.comment-wrapper .comment p{letter-spacing:-.5px;font-weight:300}.comment-wrapper>p.title{margin-top:20px}.comment>div{margin-bottom:12px}ol{padding-left:15px}ol li{margin-bottom:20px;font-weight:600}.pdf-detail{margin-top:30px}.tbl-border{border:1px solid #e3e3e3;padding:10px;border-radius:5px}table{width:100%;padding-bottom:10px;margin:0 -5px}td,th{text-align:left;padding:5px;vertical-align:top}.text-center{text-align:center}.text-right{text-align:right}.logo{width:95px}.lm-comment{background-color:#fccc3c2e;padding:5px;border-radius:4px}.space{height:30px}" +
                            "" +
                            $"</style>" +
                            $"</head>" +
                            $" <body><div class='pdf-detail'>" +
                            $" <div class='space'></div>" +
                            //$"<img src='{logoImagePath}' alt='' class='logo'>" +
                            $"<div class='flex'>" +
                            $"<h2 class='title username'>KPI Settings of {FullName}</h2>" +
                            $"<h4>KPI Settings Review</h4>" +
                            $"<div class='user-detail'>" +
                            $"<table class='tbl-border'>" +
                            $"<tr>" +
                            $"  <th style='width: 5%'>Name</th>" +
                            $"  <td style='width: 30%'>{FullName}</td>" +
                            $"  <th style='width: 5%'>Department</th>" +
                            $"  <td style='width: 35%'>{OrganizationUnit}</td>" +
                            $"  <th style='width: 5%'>Year</th>" +
                            $"  <td style='width: 20%'>{currentYear}</td>" +
                            $"</tr>" +
                            $"<tr>" +
                            $"  <th>Position</th><td>{JobPosition}</td>" +
                            $"  <th>Manager</th><td>{Manager}</td>" +
                            $"  <th>Company</th>" +
                            $"  <td>Ncell Axiata Ltd." +
                            $"</tr>" +
                            $"</table>" +
                            $"</div>");

            builder.Append($"<div class='individual-kpi-wrap'><h4>KPI Lists</h4>");
            var kpiCounter = 1;
            string descriptorName = string.Empty;

            builder.Append($"</div>");
            builder.Append($"</body></html>");

            return await Task.FromResult(builder.ToString());
        }
    }
}

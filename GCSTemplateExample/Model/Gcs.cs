using System.ComponentModel.DataAnnotations.Schema;

namespace GCSTemplateExample.Model
{
    public class Gcs
    {
        public int Id { get; set; }
        [Column(TypeName = "jsonb")]
        public List<Template> Template { get; set; }
    }

    public record Template(string Category, Validator Validator, List<RiskFactorTemplate> RiskFactors, List<Calculation> Calculations);

    public record Validator(bool isRequired, List<string> Identifiers, string Logic);

    public record RiskFactorTemplate(string Identifier, string Label, bool? IsQuestion, string Score, string InputType, string InputName, bool HasFileUpload);

    public record Calculation(string Identifier, string Label, int MinValue, List<CalculationSub> Calculations);

    public record CalculationSub(string Type, string Identifier, string Operation);

    /* public class Root
     {
         public List<GcsToolTemplate> GcsToolTemplates { get; set; }

     }
     public class GcsToolTemplate
     {
         public string RiskCategory { get; set; }
         public string RiskSubCategory { get; set; }
         public Validator Validator { get; set; }
         public List<RiskFactor> RiskFactors { get; set; }
         public Calculations Calculations { get; set; }
     }
     public class Validator
     {
         public bool Required { get; set; }
         public List<string> Identifiers { get; set; }
         public string Logic { get; set; }
     }
     public class RiskFactor
     {
         public string Identifier { get; set; }
         public string Label { get; set; }
         public string? Score { get; set; }
         public string InputType { get; set; }
         public string InputName { get; set; }
         public bool HasFileUpload { get; set; }

     }
     public class Calculations
     {
         public string Identifier { get; set; }
         public string Label { get; set; }
         public List<Calculation> Calculation { get; set; }

     }
     public class Calculation
     {
         public string Type { get; set; }
         public string Identifier { get; set; }
         public string Operation { get; set; }
     }*/
}


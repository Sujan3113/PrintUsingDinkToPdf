using DinkToPdf;
using DinkToPdf.Contracts;
using GCSTemplateExample.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GCSTemplateExample.Service
{
    public class GcsService : IGcsService
    {
        private readonly AppDbContext _context;

        public GcsService(AppDbContext context)
        {
            _context = context;
            //this._converter = converter;
            //_converter = new SynchronizedConverter(new PdfTools());
        }
        public async Task<string> AddGcs()
        {
            /*var data = new Gcs()
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
            var datas=new Gcs
           {
               Id = 3,
               Template= @"
            {
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
                  ""calculations"": 
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
                  ""calculations"": 
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
                  
                },
                {
                  ""riskCategory"": ""Land and Resource Tenure Risk (LRTR)"",
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
                      ""label"": ""All pore space within the area of review is government-owned."",
                      ""score"": 0,
                      ""inputType"": ""radio"",
                      ""inputName"": ""a"",
                      ""hasFileUpload"": false
                    },
                    {
                      ""identifier"": ""2"",
                      ""label"": ""At least some of the pore space within the area of review is community- or privately owned."",
                      ""score"": 0.125,
                      ""inputType"": ""radio"",
                      ""inputName"": ""a"",
                      ""hasFileUpload"": false
                    },
                    {
                      ""identifier"": ""3"",
                      ""label"": ""Access to injection facilities, monitoring wells, and other sensory equipment is secured through ownership, leases, rights of way, or government-issued right of entry orders for the duration of the project and the post-injection site care (PISC) period. "",
                      ""score"": 0,
                      ""inputType"": ""radio"",
                      ""inputName"": ""b"",
                      ""hasFileUpload"": false
                    },
                    {
                      ""identifier"": ""4"",
                      ""label"": ""Access to injection facilities, monitoring wells, and other sensors are secured through ownership, leases, rights of way, or government-issued right of entry orders for a portion of the project and PISC period but is subject to expiry and/or conditional renewals during the injection or PISC periods. "",
                      ""score"": 0.25,
                      ""inputType"": ""radio"",
                      ""inputName"": ""b"",
                      ""hasFileUpload"": false
                    }
                  ],
                  ""calculations"": 
                    {
                      ""identifier"": ""total land and resource tenure risk"",
                      ""label"": ""Total Land and Resource Tenure Risk (LRTR) = a + b "",
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
                  
                },
                {
                  ""riskCategory"": ""Closure Financial Risk (CFR)"",
                  ""riskSubCategory"": """",
                  ""validator"": {
                    ""required"": true,
                    ""identifiers"": [
                      ""a"",
                      ""b"",
                      ""c""
                    ],
                    ""logic"": ""AND""
                  },
                  ""elememnts"": [
                    {
                      ""identifier"": ""a"",
                      ""label"": ""The percentage of PISC costs covered by secured funding (expressed as a decimal)"",
                      ""score"": null,
                      ""inputType"": ""value"",
                      ""hasFileUpload"": false
                    },
                    {
                      ""identifier"": ""b"",
                      ""label"": ""The percentage of PISC costs covered by unsecured funding (expressed as a decimal)"",
                      ""score"": null,
                      ""inputType"": ""value"",
                      ""hasFileUpload"": false
                    },
                    {
                      ""identifier"": ""c"",
                      ""label"": ""The percentage of PISC costs not funded (expressed as a decimal)"",
                      ""score"": null,
                      ""inputType"": ""value"",
                      ""hasFileUpload"": false
                    }
                  ],
                  ""calculations"": 
                    {
                      ""identifier"": ""closure financial risk"",
                      ""label"": ""Total Closure Financial Risk (CFR) = a + (1.5 × b) + (5 × c) "",
                      ""minValue"": 0,
                      ""calculation"": [
                        {
                          ""type"": ""options"",
                          ""identifier"": ""a"",
                          ""operation"": """"
                        }
                      ]
                    }
                  
                },
                {
                  ""riskCategory"": ""Design Risk (DR)"",
                  ""riskSubCategory"": """",
                  ""validator"": {
                    ""required"": true,
                    ""identifiers"": [
                      ""a"",
                      ""b"",
                      ""c""
                    ],
                    ""logic"": ""AND""
                  },
                  ""riskFactors"": [
                    {
                      ""identifier"": ""1"",
                      ""label"": ""All injection wells for the project meet the design guidelines."",
                      ""score"": 0,
                      ""inputType"": ""radio"",
                      ""inputName"": ""a"",
                      ""hasFileUpload"": false
                    },
                    {
                      ""identifier"": ""2"",
                      ""label"": ""Some or all injection wells for the project do not meet the design guidelines."",
                      ""score"": 2,
                      ""inputType"": ""radio"",
                      ""inputName"": ""a"",
                      ""hasFileUpload"": false
                    },
                    {
                      ""identifier"": ""3"",
                      ""label"": ""The storage reservoir has more than two confining layers above the sequestration zone."",
                      ""score"": 0,
                      ""inputType"": ""radio"",
                      ""inputName"": ""b"",
                      ""hasFileUpload"": false
                    },
                    {
                      ""identifier"": ""4"",
                      ""label"": ""The storage reservoir does not have more than two confining layers above the sequestration zone."",
                      ""score"": 1,
                      ""inputType"": ""radio"",
                      ""inputName"": ""b"",
                      ""hasFileUpload"": false
                    },
                    {
                      ""identifier"": ""5"",
                      ""label"": ""The project proponent has access to relevant data (e.g., drilling logs, seismic data, core samples) from all wells that penetrate the primary or any secondary seals of the storage reservoir within the area of review for site characterization and monitoring as part of the monitoring program."",
                      ""score"": 0,
                      ""inputType"": ""radio"",
                      ""inputName"": ""c"",
                      ""hasFileUpload"": false
                    },
                    {
                      ""identifier"": ""6"",
                      ""label"": ""There are wells other than the injection and monitoring wells of the project that penetrate the primary or any secondary seals of the storage reservoir within the area of review, to which the project proponent does not have access for review or inclusion of relevant data (e.g., drilling logs, seismic data, core samples) for site characterization and monitoring as part of the monitoring program."",
                      ""score"": 1.5,
                      ""inputType"": ""radio"",
                      ""inputName"": ""c"",
                      ""hasFileUpload"": false
                    }
                  ],
                  ""calculations"": 
                    {
                      ""identifier"": ""total design risk"",
                      ""label"": ""Total Design Risk (DR) = a + b + c"",
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
                        },
                        {
                          ""type"": ""options"",
                          ""identifier"": ""c"",
                          ""operation"": ""+""
                        }
                      ]
                    }
                  
                }
              ]
            }
            "
            };                
            await _context.GcsTemplate.AddAsync(datas);
            await _context.SaveChangesAsync();*/
            return "Data saved.";
        }

        public async Task<object> GetGcs()
        {
           
            throw new Exception();
        }

        
    }
}

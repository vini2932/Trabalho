#pragma checksum "C:\Users\Vinicius\source\repos\AgenciaViagemTrabalho\AgenciaViagemTrabalho\Views\Home\Promocoes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d4d6f938b599d3753cd0c1c4ce097c758a83465"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Promocoes), @"mvc.1.0.view", @"/Views/Home/Promocoes.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Vinicius\source\repos\AgenciaViagemTrabalho\AgenciaViagemTrabalho\Views\_ViewImports.cshtml"
using AgenciaViagemTrabalho;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vinicius\source\repos\AgenciaViagemTrabalho\AgenciaViagemTrabalho\Views\_ViewImports.cshtml"
using AgenciaViagemTrabalho.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d4d6f938b599d3753cd0c1c4ce097c758a83465", @"/Views/Home/Promocoes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5f158d453f90ca1acf5e1c5902aea0365c05c8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Promocoes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Vinicius\source\repos\AgenciaViagemTrabalho\AgenciaViagemTrabalho\Views\Home\Promocoes.cshtml"
  
    ViewData["Title"] = "Promocoes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d4d6f938b599d3753cd0c1c4ce097c758a834653583", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Veja nossas promo????es</title>
    <link rel=""stylesheet"" href=""../Css/vi.css"">



    <style>

        li {
            display: inline;
            margin-left: 20px;
        }

        #cards {
            display: inline;
            width: 500px;
            height: 300px;
            margin-left: 10px;
        }

        * {
            margin: 0;
            padding:0;
        }

        #cardsimagem {
            width: 400px;
            height: 300px;
        }

        #imagempromo {
            width: 300px;
            height: 200px;
        }

        #text {
            text-align: center;
            color: white;
            padding-top: 70px;
            position: absolute;
            top: 100px;
            right: 200px;
        }

        #alinhar {
            margin-left:");
                WriteLiteral(@" 20px;
        }

        #main {
            position: relative;
            padding-top: 300px;
            width: 100vw;
            background: url(../Fotos/Punta-Cana-6.jpg);
            height: 400px;
            background-size: cover;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d4d6f938b599d3753cd0c1c4ce097c758a834655898", async() => {
                WriteLiteral("\r\n    <header>\r\n\r\n        <nav style=\"position: absolute;top: 10px;right: 60px;\">\r\n            <ul>\r\n                <li><a href=\"Promo????es.html\">Promo????es</a></li>\r\n                <li><a href=\"bordas.html\">Contato</a></li>\r\n                <li><a");
                BeginWriteAttribute("href", " href=\"", 1656, "\"", 1663, 0);
                EndWriteAttribute();
                WriteLiteral(">Cadastro</a></li>\r\n            </ul>\r\n        </nav>\r\n        </header>\r\n        <img src=\"../Fotos/Confira nossa promo????es.png\"");
                BeginWriteAttribute("alt", " alt=\"", 1793, "\"", 1799, 0);
                EndWriteAttribute();
                WriteLiteral(@" style=""width:100vw  ;height: 500px; margin-left:-120px"">

        <h1 style=""text-align: center; color:orange"">Confira nossa melhores promo????es</h1>


        <div style=""display: flex; margin-left:-90px"">

            <div id=""alinhar"">
                <div id=""cards"">
                    <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                        <p style=""text-align: center; position: relative ;top: -15px; color: white;"">-50%</p>
                    </div>
                    <a");
                BeginWriteAttribute("href", " href=\"", 2391, "\"", 2398, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/1_bp.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 2428, "\"", 2434, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
                </div>

                <div style="" border-radius: 5px;
          box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22);  margin-top: -8px;"" id=""imagempromo"">
                    <h4>Pacote de Viagem - Fortaleza + Beach Park - 2023</h4>
                    <p>???? 5 diarias</p>
                    <p> <del>De R$ 600,00</del></p>
                    <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$300,00</p></strong>
                </div>
            </div>



            <div id=""alinhar"">
                <div id=""cards"">
                    <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                        <p style=""text-align: center; position: relative ;top: -15px; color: white;"">-70%</p>
                    </div>
                    <a");
                BeginWriteAttribute("href", " href=\"", 3350, "\"", 3357, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/viagens-personalizadas-para-o-japao.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 3418, "\"", 3424, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
                </div>

                <div style="" border-radius: 5px;
         box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22); margin-top: -8px;"" id=""imagempromo"">
                    <h4>Pacote de Viagem - Jap??o (T??quio) - 2023 e 2024</h4>
                    <p>???? 7 diarias</p>
                    <p> <del>De R$ 10000,00</del></p>
                    <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$3000</p></strong>
                </div>
            </div>






            <div id=""alinhar"">
                <div id=""cards"">
                    <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                        <p style=""text-align: center; position: relative ;top: -15px; color: white;"">-60%</p>
                    </div>
                    <a");
                BeginWriteAttribute("href", " href=\"", 4343, "\"", 4350, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/india.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 4381, "\"", 4387, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
                </div>

                <div style="" border-radius: 5px;
         box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22); margin-top: -8px;"" id=""imagempromo"">
                    <h4>Pacote de Viagem ??ndia - 2023</h4>
                    <p>???? 8 diarias</p>
                    <p> <del>De R$ 5000,00</del></p>
                    <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$2000,00</p></strong>
                </div>

            </div>





            <div id=""alinhar"">
                <div id=""cards"">
                    <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                        <p style=""text-align: center; position: relative ;top: -15px; color: white;"">-50%</p>
                    </div>
                    <a");
                BeginWriteAttribute("href", " href=\"", 5290, "\"", 5297, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/australia-sydney-opera-house.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 5351, "\"", 5357, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
                </div>

                <div style="" border-radius: 5px;
        box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22);  margin-top: -8px;"" id=""imagempromo"">
                    <h4>Pacote de Viagem - Austr??lia- 2023</h4>
                    <p>???? 6 diarias</p>
                    <p> <del>De R$ 3000,00</del></p>
                    <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$1500</p></strong>
                </div>
            </div>


        </div>
        <h2 style=""text-align: center; color:orange"">Nossas  melhores promo????es pelo Brasil</h2>

        <div style=""display: flex;margin-left:-90px"">
            <div id=""alinhar"">
                <div id=""cards"">
                    <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                        <p style=""text-align: center; position: relative ;top: -15px; color: white;"">-50%</p>
       ");
                WriteLiteral("             </div>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 6425, "\"", 6432, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/1_bp.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 6462, "\"", 6468, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
                </div>

                <div style="" border-radius: 5px;
        box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22);  margin-top: -8px;"" id=""imagempromo"">
                    <h4>Pacote de Viagem - Fortaleza + Beach Park - 2023</h4>
                    <p>???? 5 diarias</p>
                    <p> <del>De R$ 600,00</del></p>
                    <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$300,00</p></strong>
                </div>
            </div>



            <div id=""alinhar"">
                <div id=""cards"">
                    <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                        <p style=""text-align: center; position: relative ;top: -15px; color: white;"">-55%</p>
                    </div>
                    <a");
                BeginWriteAttribute("href", " href=\"", 7382, "\"", 7389, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/53498_exterior_view_3.webp\"");
                BeginWriteAttribute("alt", " alt=\"", 7437, "\"", 7443, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
                </div>

                <div style="" border-radius: 5px;
            box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22);  margin-top: -8px;"" id=""imagempromo"">
                    <h4>Pacote de Viagem - Gramado+ Skyglass - 2023</h4>
                    <p>???? 3 diarias</p>
                    <p>De<del> R$ 700,00</del></p>
                    <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$315,00</p></strong>
                </div>
            </div>

            <div id=""alinhar"">
                <div id=""cards"">
                    <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                        <p style=""text-align: center; position: relative ;top: -15px; color: white;"">-40%</p>
                    </div>
                    <a");
                BeginWriteAttribute("href", " href=\"", 8351, "\"", 8358, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/o-que-fazer-em-maragogi-3.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 8409, "\"", 8415, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
                </div>

                <div style="" border-radius: 20px;
                box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22);  margin-top: -8px;"" id=""imagempromo"">
                    <h4>Pacote de Viagem - Maragogi - Carnaval 2022</h4>
                    <p>???? 4 diarias</p>
                    <p>De <del>R$ 5000,00</del></p>
                    <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$3000,00</p></strong>
                </div>
            </div>





            <div id=""alinhar"">
                <div id=""cards"">
                    <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                        <p style=""text-align: center; position: relative ;top: -15px; color: white;"">-75%</p>
                    </div>
                    <a");
                BeginWriteAttribute("href", " href=\"", 9338, "\"", 9345, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/28_shutterstock_41365018___Piscina_subter__nea_dentro_de_cavernas___Parque_Nacional_da_Chapada_Diamantina__BA.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 9480, "\"", 9486, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
                </div>

                <div style="" border-radius: 5px;
                 box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22); margin-top: -8px;"" id=""imagempromo"">
                    <h4>Pacote de Viagem - Chapada Diamantina (Bahia) - 2023</h4>
                    <p>???? 6 diarias</p>
                    <p> <del>De R$ 2000,00</del></p>
                    <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$500,00</p>.</strong>
                </div>
            </div>
        </div>


        <h2 style=""text-align: center; color:orange"">Nossas melhores promo????es internacionais</h2>

        <div style=""display: flex; margin-left:-90px"">

            <div id=""alinhar"">
                <div id=""cards"">
                    <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                        <p style=""text-align: center; position: relative ;top: -15px");
                WriteLiteral("; color: white;\">-50%</p>\r\n                    </div>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 10588, "\"", 10595, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/australia-sydney-opera-house.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 10649, "\"", 10655, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
                </div>

                <div style="" border-radius: 5px;
    box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22);  margin-top: -8px;"" id=""imagempromo"">
                    <h3>Pacote de Viagem - Austr??lia (Sydney) - 2023</h3>
                    <p>???? 6 diarias</p>
                    <p> <del>De R$ 3000,00</del></p>
                    <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$1500</p></strong>
                </div>
            </div>


            <div id=""alinhar"">
                <div id=""cards"">
                    <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                        <p style=""text-align: center; position: relative ;top: -15px; color: white;"">-60%</p>
                    </div>
                    <a");
                BeginWriteAttribute("href", " href=\"", 11558, "\"", 11565, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/india.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 11596, "\"", 11602, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
                </div>

                <div style="" border-radius: 5px;
     box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22); margin-top: -8px;"" id=""imagempromo"">
                    <h4>Pacote de Viagem ??ndia - 2023</h4>
                    <p>???? 8 diarias</p>
                    <p> <del>De R$ 5000,00</del></p>
                    <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$2000,00</p></strong>
                </div>
            </div>



            <div id=""alinhar"">
                <div id=""cards"">
                    <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                        <p style=""text-align: center; position: relative ;top: -15px; color: white;"">-70%</p>
                    </div>
                    <a");
                BeginWriteAttribute("href", " href=\"", 12495, "\"", 12502, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/viagens-personalizadas-para-o-japao.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 12563, "\"", 12569, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
                </div>

                <div style="" border-radius: 5px;
     box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22); margin-top: -8px;"" id=""imagempromo"">
                    <h4>Pacote de Viagem - Jap??o (T??quio) - 2023 e 2024</h4>
                    <p>???? 7 diarias</p>
                    <p> <del>De R$ 10000,00</del></p>
                    <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$3000</p></strong>
                </div>
            </div>


            <div id=""alinhar"">
                <div id=""cards"">
                    <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                        <p style=""text-align: center; position: relative ;top: -15px; color: white;"">-50%</p>
                    </div>
                    <a");
                BeginWriteAttribute("href", " href=\"", 13476, "\"", 13483, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/cabanas-aerial.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 13523, "\"", 13529, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
                </div>

                <div style="" border-radius: 5px;
        box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22);  margin-top: -8px;"" id=""imagempromo"">
                    <h4>Pacote de Viagem - Aruba - 2023 e 2024</h4>
                    <p>???? 7 diarias</p>
                    <p><del> De R$ 4000,00</del></p>
                    <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$2000,00</p></strong>
                </div>
            </div>
        </div>


");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

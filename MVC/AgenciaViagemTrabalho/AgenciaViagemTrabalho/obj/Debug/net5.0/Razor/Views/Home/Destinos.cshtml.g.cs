#pragma checksum "C:\Users\Vinicius\source\repos\AgenciaViagemTrabalho\AgenciaViagemTrabalho\Views\Home\Destinos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa48426535d7d89acab63e626b6451f6c021a712"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Destinos), @"mvc.1.0.view", @"/Views/Home/Destinos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa48426535d7d89acab63e626b6451f6c021a712", @"/Views/Home/Destinos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5f158d453f90ca1acf5e1c5902aea0365c05c8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Destinos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa48426535d7d89acab63e626b6451f6c021a7123346", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Document</title>\r\n    <link rel=\"stylesheet\" href=\"../Css/vi.css\">\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa48426535d7d89acab63e626b6451f6c021a7124578", async() => {
                WriteLiteral(@"
    <header>

        <nav style=""position: absolute;top: 10px;right: 60px;"">
            <ul>
                <li><strong><a href=""#"" style=""color: black;""></a></strong></li>
                <li><strong><a href=""#"" style=""color: black;""></a></strong></li>
                <li><strong><a href=""#"" style=""color: black;""></a></strong></li>
            </ul>
        </nav>
    </header>
    <h1 style=""text-align: center;color: orange;"">Veja todas as nossas Passagens e Pacotes</h1>


    <div style=""display: flex; margin-left:-150px"">
        <div id=""alinhar"">
            <div id=""cards"">
                <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                    <p style=""text-align: center; position: relative ;top: -15px; color: white;"">-50%</p>
                </div>
                <a");
                BeginWriteAttribute("href", " href=\"", 1203, "\"", 1210, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/1_bp.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 1240, "\"", 1246, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
            </div>

            <div style="" border-radius: 5px;
          box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22);  margin-top: -8px;"" id=""imagempromo"">
                <h4>Pacote de Viagem - Fortaleza + Beach Park - 2023</h4>
                <p>📆 5 diarias</p>
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
                BeginWriteAttribute("href", " href=\"", 2104, "\"", 2111, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/viagens-personalizadas-para-o-japao.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 2172, "\"", 2178, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
            </div>

            <div style="" border-radius: 5px;
         box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22); margin-top: -8px;"" id=""imagempromo"">
                <h4>Pacote de Viagem - Japão (Tóquio) - 2023 e 2024</h4>
                <p>📆 7 diarias</p>
                <p> <del>De R$ 10000,00</del></p>
                <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$3000</p></strong>
            </div>
        </div>

        <div id=""alinhar"">
            <div id=""cards"">
                <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                    <p style=""text-align: center; position: relative ;top: -15px; color: white;"">-75%</p>
                </div>
                <a");
                BeginWriteAttribute("href", " href=\"", 3031, "\"", 3038, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/28_shutterstock_41365018___Piscina_subter__nea_dentro_de_cavernas___Parque_Nacional_da_Chapada_Diamantina__BA.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 3173, "\"", 3179, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
            </div>

            <div style="" border-radius: 5px;
         box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22); margin-top: -8px;"" id=""imagempromo"">
                <h4>Pacote de Viagem - Chapada Diamantina (Bahia) - 2023</h4>
                <p>📆 6 diarias</p>
                <p> <del>De R$ 2000,00</del></p>
                <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$500,00</p>.</strong>
            </div>
        </div>


        <div id=""alinhar"">
            <div id=""cards"">
                <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                    <p style=""text-align: center; position: relative ;top: -15px; color: white;"">-60%</p>
                </div>
                <a");
                BeginWriteAttribute("href", " href=\"", 4041, "\"", 4048, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/india.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 4079, "\"", 4085, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
            </div>

            <div style="" border-radius: 5px;
         box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22); margin-top: -8px;"" id=""imagempromo"">
                <h4>Pacote de Viagem Índia - 2023</h4>
                <p>📆 8 diarias</p>
                <p> <del>De R$ 5000,00</del></p>
                <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$2000,00</p></strong>
            </div>

        </div>
    </div>






    <div style=""display: flex; margin-left:-150px"">

        <div id=""alinhar"">
            <div id=""cards"">
                <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                    <p style=""text-align: center; position: relative ;top: -15px; color: white;"">-20%</p>
                </div>
                <a");
                BeginWriteAttribute("href", " href=\"", 5001, "\"", 5008, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/014LCM-IM2101-lencois-maranhenses-768.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 5071, "\"", 5077, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
            </div>

            <div style="" border-radius: 5px;
            box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22);  margin-top: -8px;"" id=""imagempromo"">
                <h4>
                    São Luís, MA
                    Pacote de Viagem -Lençóis Maranhenses - 2022
                </h4>
                <p>📆 6 diarias</p>
                <p> <del> R$ 1000,00</del></p>
                <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$800,00</p></strong>
            </div>
        </div>



        <div id=""alinhar"">
            <div id=""cards"">
                <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                    <p style=""text-align: center; position: relative ;top: -15px; color: white;"">-50%</p>
                </div>
                <a");
                BeginWriteAttribute("href", " href=\"", 6008, "\"", 6015, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/australia-sydney-opera-house.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 6069, "\"", 6075, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
            </div>

            <div style="" border-radius: 5px;
                box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22);  margin-top: -8px;"" id=""imagempromo"">
                <h4>Pacote de Viagem - Austrália (Sydney) - 2023</h4>
                <p>📆 6 diarias</p>
                <p> <del>De R$ 3000,00</del></p>
                <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$1500</p></strong>
            </div>
        </div>




        <div id=""alinhar"">
            <div id=""cards"">
                <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                    <p style=""text-align: center; position: relative ;top: -15px; color: white;"">-50%</p>
                </div>
                <a");
                BeginWriteAttribute("href", " href=\"", 6938, "\"", 6945, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/cabanas-aerial.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 6985, "\"", 6991, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
            </div>

            <div style="" border-radius: 5px;
                    box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22);  margin-top: -8px;"" id=""imagempromo"">
                <h4>Pacote de Viagem - Aruba - 2023 e 2024</h4>
                <p>📆 7 diarias</p>
                <p><del> De R$ 4000,00</del></p>
                <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$2000,00</p></strong>
            </div>
        </div>
        <div id=""alinhar"">
            <div id=""cards"">
                <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                    <p style=""text-align: center; position: relative ;top: -15px; color: white;"">-55%</p>
                </div>
                <a");
                BeginWriteAttribute("href", " href=\"", 7847, "\"", 7854, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/53498_exterior_view_3.webp\"");
                BeginWriteAttribute("alt", " alt=\"", 7902, "\"", 7908, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
            </div>

            <div style="" border-radius: 5px;
                        box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22);  margin-top: -8px;"" id=""imagempromo"">
                <h5>Pacote de Viagem - Gramado+ Skyglass - 2023</h5>
                <p>📆 3 diarias</p>
                <p>De<del> R$ 700,00</del></p>
                <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$315,00</p></strong>
            </div>
        </div>




    </div>




    <div style=""display: flex; margin-left:-150px "">

        <div id=""alinhar"">
            <div id=""cards"">
                <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                    <p style=""text-align: center; position: relative ;top: -15px; color: white;"">-40%</p>
                </div>
                <a");
                BeginWriteAttribute("href", " href=\"", 8854, "\"", 8861, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/20210922182454450793e.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 8908, "\"", 8914, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
            </div>

            <div style="" border-radius: 5px;
                    box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22);  margin-top: -8px;"" id=""imagempromo"">
                <h4>Pacote de Viagem - Recife - Carnaval 2022</h4>
                <p>📆 6 diarias</p>
                <p>De<del> R$ 2500,00</del></p>
                <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$1500,00</p></strong>
            </div>
        </div>


        <div id=""alinhar"">
            <div id=""cards"">
                <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                    <p style=""text-align: center; position: relative ;top: -15px; color: white;"">-40%</p>
                </div>
                <a");
                BeginWriteAttribute("href", " href=\"", 9776, "\"", 9783, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/cf2.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 9812, "\"", 9818, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
            </div>

            <div style="" border-radius: 5px;
             box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22);  margin-top: -8px;"" id=""imagempromo"">
                <h4>Pacote de Viagem - Cabo Frio - Carnaval 2022</h4>
                <p>📆 10 diarias</p>
                <p>De <del>R$ 5000,00</del></p>
                <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$3000,00</p></strong>
            </div>
        </div>





        <div id=""alinhar"">
            <div id=""cards"">
                <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                    <p style=""text-align: center; position: relative ;top: -15px; color: white;"">-40%</p>
                </div>
                <a");
                BeginWriteAttribute("href", " href=\"", 10683, "\"", 10690, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/csm_CARNAVAL-JP-31-01-2020_15e75e14ff.png\"");
                BeginWriteAttribute("alt", " alt=\"", 10753, "\"", 10759, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
            </div>

            <div style="" border-radius: 5px;
                box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22);  margin-top: -8px;"" id=""imagempromo"">
                <h4>Pacote de Viagem - João Pessoa - Carnaval 2022</h4>
                <p>📆 4 diarias</p>
                <p>De <del>R$ 5000,00</del></p>
                <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$3000,00</p></strong>
            </div>
        </div>


        <div id=""alinhar"">
            <div id=""cards"">
                <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                    <p style=""text-align: center; position: relative ;top: -15px; color: white;"">-40%</p>
                </div>
                <a");
                BeginWriteAttribute("href", " href=\"", 11622, "\"", 11629, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/o-que-fazer-em-maragogi-3.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 11680, "\"", 11686, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
            </div>

            <div style="" border-radius: 5px;
             box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22);  margin-top: -8px;"" id=""imagempromo"">
                <h4>Pacote de Viagem - Maragogi - Carnaval 2022</h4>
                <p>📆 4 diarias</p>
                <p>De <del>R$ 5000,00</del></p>
                <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$3000,00</p></strong>
            </div>
        </div>
    </div>









    <div style=""display: flex; margin-left:-150px"">

        <div id=""alinhar"">
            <div id=""cards"">
                <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                    <p style=""text-align: center; position: relative ;top: -15px; color: white;"">-40%</p>
                </div>
                <a");
                BeginWriteAttribute("href", " href=\"", 12624, "\"", 12631, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/9_carnaval.webp\"");
                BeginWriteAttribute("alt", " alt=\"", 12668, "\"", 12674, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
            </div>

            <div style="" border-radius: 5px;
             box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22);  margin-top: -8px;"" id=""imagempromo"">
                <h4>Pacote de Viagem - Gramado ou Canela - Carnaval 2022</h4>
                <p>📆 3 diarias</p>
                <p>De <del>R$ 5000,00</del></p>
                <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$3000,00</p></strong>
            </div>
        </div>


        <div id=""alinhar"">
            <div id=""cards"">
                <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                    <p style=""text-align: center; position: relative ;top: -15px; color: white;"">-40%</p>
                </div>
                <a");
                BeginWriteAttribute("href", " href=\"", 13540, "\"", 13547, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/FB_IMG_15828247545581771.webp\"");
                BeginWriteAttribute("alt", " alt=\"", 13598, "\"", 13604, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
            </div>

            <div style="" border-radius: 5px;
             box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22);  margin-top: -8px;"" id=""imagempromo"">
                <h4>Pacote de Viagem - Itacaré - Carnaval 2022</h4>
                <p>📆 7 diarias</p>
                <p>De <del>R$ 5000,00</del></p>
                <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$3000,00</p></strong>
            </div>
        </div>




        <div id=""alinhar"">
            <div id=""cards"">
                <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                    <p style=""text-align: center; position: relative ;top: -15px; color: white;"">-40%</p>
                </div>
                <a");
                BeginWriteAttribute("href", " href=\"", 14464, "\"", 14471, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/1_ba270120026_16606888.webp\"");
                BeginWriteAttribute("alt", " alt=\"", 14520, "\"", 14526, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
            </div>

            <div style="" border-radius: 5px;
              box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22);  margin-top: -8px;"" id=""imagempromo"">
                <h4>Pacote de Viagem - Porto de Galinhas - Carnaval 2022</h4>
                <p>📆 3 diarias</p>
                <p>De <del>R$ 6000,00</del></p>
                <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$1000,00</p></strong>
            </div>
        </div>


        <div id=""alinhar"">
            <div id=""cards"">
                <div style=""color: orange; position: relative; top: 30px; border: solid; width: 35px ;height: 20px; background-color: orange;"">
                    <p style=""text-align: center; position: relative ;top: -15px; color: white;"">-40%</p>
                </div>
                <a");
                BeginWriteAttribute("href", " href=\"", 15393, "\"", 15400, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"../Fotos/1_54a553c239a288ce4bcfd4439240952e.webp\"");
                BeginWriteAttribute("alt", " alt=\"", 15461, "\"", 15467, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""imagempromo""> </a>
            </div>

            <div style="" border-radius: 5px;
               box-shadow: 7px 7px 13px 0px rgba(50, 50, 50, 0.22);  margin-top: -8px;"" id=""imagempromo"">
                <h4>Pacote de Viagem - Brasília - Carnaval 2022</h4>
                <p>📆 3 diarias</p>
                <p>De <del>R$ 5000,00</del></p>
                <strong><p style=""color: orange; font-size: 30px; margin-top: -10px;"">R$700,00</p></strong>
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

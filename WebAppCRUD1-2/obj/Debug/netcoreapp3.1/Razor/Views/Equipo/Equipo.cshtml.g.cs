#pragma checksum "C:\Users\lords\OneDrive\Documents\GitHub\ProyectoIntegradorIEPAM\WebAppCRUD1-2\Views\Equipo\Equipo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ac7290929b0c9c67fd196a3ee5bf9a42c7de056"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Equipo_Equipo), @"mvc.1.0.view", @"/Views/Equipo/Equipo.cshtml")]
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
#line 1 "C:\Users\lords\OneDrive\Documents\GitHub\ProyectoIntegradorIEPAM\WebAppCRUD1-2\Views\_ViewImports.cshtml"
using WebAppCRUD1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lords\OneDrive\Documents\GitHub\ProyectoIntegradorIEPAM\WebAppCRUD1-2\Views\_ViewImports.cshtml"
using WebAppCRUD1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac7290929b0c9c67fd196a3ee5bf9a42c7de056", @"/Views/Equipo/Equipo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3e5d9bafb027a9d32af89b02939e968ae085d03", @"/Views/_ViewImports.cshtml")]
    public class Views_Equipo_Equipo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style7.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lords\OneDrive\Documents\GitHub\ProyectoIntegradorIEPAM\WebAppCRUD1-2\Views\Equipo\Equipo.cshtml"
Write(Html.ValidationSummary(false, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\lords\OneDrive\Documents\GitHub\ProyectoIntegradorIEPAM\WebAppCRUD1-2\Views\Equipo\Equipo.cshtml"
  
    ViewData["Title"] = "Equipo";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ac7290929b0c9c67fd196a3ee5bf9a42c7de0565098", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"with=device-width, initial-scale=1.0\">\r\n    <title>IEPAM Main</title>\r\n    <link rel=\"icon\" href=\"images/NL.png\">\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7ac7290929b0c9c67fd196a3ee5bf9a42c7de0565528", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7ac7290929b0c9c67fd196a3ee5bf9a42c7de0566706", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ac7290929b0c9c67fd196a3ee5bf9a42c7de0568596", async() => {
                WriteLiteral(@"
    <div class=""atras"">
        <section class=""row"">
            <div class=""card"">
                <div class=""card-container"">
                    <header class=""card-header"">
                        <div class=""user-profile-image""></div>
                        <span class=""user-name"">Luis Rodríguez</span>
                        <span class=""user-bio"">Ingeniería en Tecnologías Computacionales</span>
                    </header>

                    <section class=""about-section"">
                        <div class=""about-item"">
                            <div class=""item-value""></div>
                            <div class=""item-label"">
                                Escuela
                                de Ingeniería
                            </div>
                        </div>
                        <div class=""about-item"">
                            <div class=""item-value""></div>
                            <div class=""item-label"">ITC</div>
                        </d");
                WriteLiteral(@"iv>
                        <div class=""about-item"">
                            <div class=""item-value""></div>
                            <div class=""item-label"">TEC de Mty</div>
                        </div>
                    </section>
                </div>
            </div>
            <div class=""card"">
                <div class=""card-container"">

                    <header class=""card-header"">
                        <div class=""user-profile-image2""></div>
                        <span class=""user-name"">Andrea Garza</span>
                        <span class=""user-bio"">Ingeniería en Tecnologías Computacionales</span>
                    </header>

                    <section class=""about-section"">
                        <div class=""about-item"">
                            <div class=""item-value""></div>
                            <div class=""item-label"">
                                Escuela
                                de Ingeniería
                            </di");
                WriteLiteral(@"v>
                        </div>
                        <div class=""about-item"">
                            <div class=""item-value""></div>
                            <div class=""item-label"">ITC</div>
                        </div>
                        <div class=""about-item"">
                            <div class=""item-value""></div>
                            <div class=""item-label"">TEC de Mty</div>
                        </div>
                    </section>
                </div>
            </div>
            <div class=""card"">
                <div class=""card-container"">

                    <header class=""card-header"">
                        <div class=""user-profile-image""></div>
                        <span class=""user-name"">Tadeo Willis</span>
                        <span class=""user-bio"">Ingeniería en Tecnologías Computacionales</span>
                    </header>

                    <section class=""about-section"">
                        <div class=""about-item"">
                WriteLiteral(@"
                            <div class=""item-value""></div>
                            <div class=""item-label"">
                                Escuela
                                de Ingeniería
                            </div>
                        </div>
                        <div class=""about-item"">
                            <div class=""item-value""></div>
                            <div class=""item-label"">ITC</div>
                        </div>
                        <div class=""about-item"">
                            <div class=""item-value""></div>
                            <div class=""item-label"">TEC de Mty</div>
                        </div>
                    </section>
                </div>
            </div>
            <div class=""card"">
                <div class=""card-container"">

                    <header class=""card-header"">
                        <div class=""user-profile-image""></div>
                        <span class=""user-name"">Rodolfo Sandoval</");
                WriteLiteral(@"span>
                        <span class=""user-bio"">Ingeniería en Tecnologías Computacionales</span>
                    </header>

                    <section class=""about-section"">
                        <div class=""about-item"">
                            <div class=""item-value""></div>
                            <div class=""item-label"">
                                Escuela
                                de Ingeniería
                            </div>
                        </div>
                        <div class=""about-item"">
                            <div class=""item-value""></div>
                            <div class=""item-label"">ITC</div>
                        </div>
                        <div class=""about-item"">
                            <div class=""item-value""></div>
                            <div class=""item-label"">TEC de Mty</div>
                        </div>
                    </section>
                </div>
            </div>
        </section>
 ");
                WriteLiteral("   </div>\r\n");
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
            WriteLiteral("\r\n\r\n</html>");
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
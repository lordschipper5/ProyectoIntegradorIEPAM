#pragma checksum "/Users/larome/Documents/GitHub/ProyectoIntegradorIEPAM/WebAppCRUD1-2/Views/Cursos/Cursos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee23a88b8fe384ac00e6994a7f84f0d2d6141713"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cursos_Cursos), @"mvc.1.0.view", @"/Views/Cursos/Cursos.cshtml")]
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
#line 1 "/Users/larome/Documents/GitHub/ProyectoIntegradorIEPAM/WebAppCRUD1-2/Views/_ViewImports.cshtml"
using WebAppCRUD1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/larome/Documents/GitHub/ProyectoIntegradorIEPAM/WebAppCRUD1-2/Views/_ViewImports.cshtml"
using WebAppCRUD1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee23a88b8fe384ac00e6994a7f84f0d2d6141713", @"/Views/Cursos/Cursos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f6fa66a45937cd9de39297d339d33d4749eb1d1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cursos_Cursos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CursosModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style3.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ContenidoCursos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cursos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/app.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/larome/Documents/GitHub/ProyectoIntegradorIEPAM/WebAppCRUD1-2/Views/Cursos/Cursos.cshtml"
Write(Html.ValidationSummary(false, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/larome/Documents/GitHub/ProyectoIntegradorIEPAM/WebAppCRUD1-2/Views/Cursos/Cursos.cshtml"
  
    ViewData["Title"] = "Cursos";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee23a88b8fe384ac00e6994a7f84f0d2d61417136100", async() => {
                WriteLiteral(@"

    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <script src=""https://kit.fontawesome.com/64d58efce2.js""
            crossorigin=""anonymous""></script>
    <link rel=""icon"" href=""https://nuevoleon.travel/wp-content/uploads/2019/11/ImagoNLE-700x582.png"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ee23a88b8fe384ac00e6994a7f84f0d2d61417136656", async() => {
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
                WriteLiteral("\n    <title>Sign in & Sign up Form</title>\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee23a88b8fe384ac00e6994a7f84f0d2d61417138550", async() => {
                WriteLiteral(@"
    <div class=""atracito"" style=""display: flex; align-items: center; justify-content: center; flex-direction: column; min-height: 100vh; margin: 0;"">
        <div class=""courses-container"">
            <div class=""course"">
                <div class=""course-preview"">
                    <h6>Curso</h6>
                    <h2>DESAROLLO DE VIDEOJUEGOS</h2>
                    <a href=""#"">Ver Todos los Capitulos <i class=""fas fa-chevron-right""></i></a>
                </div>
                <div class=""course-info"">
                    <div class=""progress-container"">
                        <div class=""progress""></div>
                        <span class=""progress-text"">
                            0/9 Challenges
                        </span>
                    </div>
                    <h6>Capitulo 1</h6>
                    <h2>¿Que es UNITY?</h2>
                    <a class=""btn"" href=""contenidoCurso.html"">Empezar</a>
                </div>
            </div>
        </div>
        <div id=""demo"" class");
                WriteLiteral(@"=""course"">
            <div class=""course-preview"">
                <h6>Curso Nuevo</h6>
                <h2>[Agrega Nombre del Curso]</h2>
                <a href=""#"">Ver Todos los Capitulos <i class=""fas fa-chevron-right""></i></a>
            </div>
            <div class=""course-info"">
                <div class=""progress-container"">
                    <div class=""progress""></div>
                    <span class=""progress-text"">
                        0/9 Challenges
                    </span>
                </div>
                <h6>Capitulo 1</h6>
                <h2>[Inserta Nombre del Capitulo]</h2>
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee23a88b8fe384ac00e6994a7f84f0d2d614171310540", async() => {
                    WriteLiteral("Empezar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>
        </div>
        <button class=""floating-btn"" onclick=""myFunction()"">Agregar Curso</button>

        <script>function myFunction() {
                const node = document.getElementById(""demo"");
                const clone = node.cloneNode(true);
                document.body.appendChild(clone);
            }</script>

        <!-- SOCIAL PANEL HTML -->
        <div class=""social-panel-container"">
            <div class=""social-panel"">
                <p>
                    CREADO POR: <i class=""fa fa-heart""></i> by
                    <a target=""_blank"" href=""https://florin-pop.com"">EQUIPO 5</a>
                </p>
                <button class=""close-btn""><i class=""fas fa-times""></i></button>
                <h4>Contactarnos</h4>
                <ul>
                    <li>
                        <a");
                BeginWriteAttribute("href", " href=\"", 3171, "\"", 3178, 0);
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\">\n                            <i class=\"fab fa-discord\"></i>\n                        </a>\n                    </li>\n                    <li>\n                        <a");
                BeginWriteAttribute("href", " href=\"", 3362, "\"", 3369, 0);
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\">\n                            <i class=\"fab fa-twitter\"></i>\n                        </a>\n                    </li>\n                    <li>\n                        <a");
                BeginWriteAttribute("href", " href=\"", 3553, "\"", 3560, 0);
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\">\n                            <i class=\"fab fa-linkedin\"></i>\n                        </a>\n                    </li>\n                    <li>\n                        <a");
                BeginWriteAttribute("href", " href=\"", 3745, "\"", 3752, 0);
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\">\n                            <i class=\"fab fa-facebook\"></i>\n                        </a>\n                    </li>\n                    <li>\n                        <a");
                BeginWriteAttribute("href", " href=\"", 3937, "\"", 3944, 0);
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\">\n                            <i class=\"fab fa-instagram\"></i>\n                        </a>\n                    </li>\n                </ul>\n            </div>\n        </div>\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee23a88b8fe384ac00e6994a7f84f0d2d614171314626", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    </div>\n");
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
            WriteLiteral("\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CursosModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

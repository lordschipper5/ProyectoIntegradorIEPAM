#pragma checksum "/Users/larome/Documents/GitHub/ProyectoIntegradorIEPAM/WebAppCRUD1-2/Views/Cursos/Cursos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66277cdbc7633cc9090e7468211793aec4aeb20a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66277cdbc7633cc9090e7468211793aec4aeb20a", @"/Views/Cursos/Cursos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f6fa66a45937cd9de39297d339d33d4749eb1d1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cursos_Cursos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CursosModel>
    #nullable disable
    {
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
            WriteLiteral(@"
<link rel=""stylesheet"" href=""style3.css"" />
<link rel=""icon"" href=""images/NL.png"">
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
            <button class=""btn"" href=""contenidoCurso.html"">Empezar</button>
        </div>
    </div>
</div>

<div id=""demo"" class=""course"">
    <div class=""course-preview"">
        <h6>Curso Nuevo</h6>
        <h2>[Agrega Nombre del Curso]</h2>
        <a href=""#"">Ver Todos los Capitulos <i class=""fas fa-chevron-right""></i></a>
    </div>
    <div cla");
            WriteLiteral(@"ss=""course-info"">
        <div class=""progress-container"">
            <div class=""progress""></div>
            <span class=""progress-text"">
                0/9 Challenges
            </span>
        </div>
        <h6>Capitulo 1</h6>
        <h2>[Inserta Nombre del Capitulo]</h2>
        <button class=""btn"" href=""contenidoCurso2.html"">Empezar</button>
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
            BeginWriteAttribute("href", " href=\"", 2211, "\"", 2218, 0);
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\n                    <i class=\"fab fa-discord\"></i>\n                </a>\n            </li>\n            <li>\n                <a");
            BeginWriteAttribute("href", " href=\"", 2362, "\"", 2369, 0);
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\n                    <i class=\"fab fa-twitter\"></i>\n                </a>\n            </li>\n            <li>\n                <a");
            BeginWriteAttribute("href", " href=\"", 2513, "\"", 2520, 0);
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\n                    <i class=\"fab fa-linkedin\"></i>\n                </a>\n            </li>\n            <li>\n                <a");
            BeginWriteAttribute("href", " href=\"", 2665, "\"", 2672, 0);
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\n                    <i class=\"fab fa-facebook\"></i>\n                </a>\n            </li>\n            <li>\n                <a");
            BeginWriteAttribute("href", " href=\"", 2817, "\"", 2824, 0);
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\n                    <i class=\"fab fa-instagram\"></i>\n                </a>\n            </li>\n        </ul>\n    </div>\n</div>\n\n<script src=\"app.js\"></script>\n\n");
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

#pragma checksum "/Users/larome/Documents/GitHub/ProyectoIntegradorIEPAM/WebAppCRUD1-2/Views/Register/Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cae2b8dfb5b264822b99ddd711319707431a32a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Register), @"mvc.1.0.view", @"/Views/Register/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cae2b8dfb5b264822b99ddd711319707431a32a", @"/Views/Register/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f6fa66a45937cd9de39297d339d33d4749eb1d1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Register_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UsuarioModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/larome/Documents/GitHub/ProyectoIntegradorIEPAM/WebAppCRUD1-2/Views/Register/Register.cshtml"
Write(Html.ValidationSummary(false, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/larome/Documents/GitHub/ProyectoIntegradorIEPAM/WebAppCRUD1-2/Views/Register/Register.cshtml"
  
    ViewData["Title"] = "Guardar";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    body {
    margin: 0;
    padding: 0;
    background: linear-gradient(135deg, #6a1aca, #ebb5ff);
    background-size: cover;
   
}

    .container {
    background-color: #fff;
    padding: 25px 30px;
    border-radius: 5px;
    box-shadow: 0 5px 10px rgba(0,0,0,0.15);
}

    .container .title {
        font-size: 25px;
        font-weight: 500;
        position: relative;
    }

        .container .title::before {
            content: """";
            position: absolute;
            left: 0;
            bottom: 0;
            height: 3px;
            width: 30px;
            border-radius: 5px;
            background: linear-gradient(135deg, #6a1aca, #ebb5ff);
        }

.content form .user-details {
    display: flex;
    flex-wrap: wrap;
    justify-content: space-between;
    margin: 20px 0 12px 0;
}

form .user-details .input-box {
    margin-bottom: 15px;
    width: calc(100% / 2 - 20px);
}

form .input-box span.details {
    display: block;
    font-weight: 500;
    margin-bottom: 5px;
}

.");
            WriteLiteral(@"user-details .input-box input {
    height: 45px;
    width: 100%;
    outline: none;
    font-size: 16px;
    border-radius: 5px;
    padding-left: 15px;
    border: 1px solid #ccc;
    border-bottom-width: 2px;
    transition: all 0.3s ease;
}

    .user-details .input-box input:focus,
    .user-details .input-box input:valid {
        border-color: #9b59b6;
    }

form .gender-details .gender-title {
    font-size: 20px;
    font-weight: 500;
}

form .category {
    display: flex;
    width: 80%;
    margin: 14px 0;
    justify-content: space-between;
}

    form .category label {
        display: flex;
        align-items: center;
        cursor: pointer;
    }

        form .category label .dot {
            height: 18px;
            width: 18px;
            border-radius: 50%;
            margin-right: 10px;
            background: #d9d9d9;
            border: 5px solid transparent;
            transition: all 0.3s ease;
        }

#dot-1:checked ~ .category label .one,
#dot-2:checked ~ .category label ");
            WriteLiteral(@".two,
#dot-3:checked ~ .category label .three {
    background: #9b59b6;
    border-color: #d9d9d9;
}

form input[type=""radio""] {
    display: none;
}

form .button {
    height: 45px;
    margin: 35px 0
}

    form .button input {
        height: 100%;
        width: 100%;
        border-radius: 5px;
        border: none;
        color: #fff;
        font-size: 18px;
        font-weight: 500;
        letter-spacing: 1px;
        cursor: pointer;
        transition: all 0.3s ease;
        background: linear-gradient(135deg, #6a1aca, #ebb5ff);
    }

        form .button input:hover {
           
            background: linear-gradient(-135deg, #6a1aca, #ebb5ff);
        }

/* media(max - width: 584px){
    .container {
        max-width: 100%;
    }

    form .user-details .input-box {
        margin-bottom: 15px;
    width: 100%;
    }

    form .category {
    width: 100%;
    }

    .content form .user-details {
        max-height: 300px;
        overflow-y: scroll;
    }

    .user-details::-webkit-scroll");
            WriteLiteral("bar {\n    width: 5px;\n    }\n}\n\nmedia(max-width: 459px) {\n    .container .content .category {\n        flex-direction: column;\n    }\n}\n    */\n</style>\n\n<!DOCTYPE html>\n<html lang=\"en\" dir=\"ltr\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cae2b8dfb5b264822b99ddd711319707431a32a8675", async() => {
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <title> Registration Form  </title>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1cae2b8dfb5b264822b99ddd711319707431a32a9004", async() => {
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
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cae2b8dfb5b264822b99ddd711319707431a32a10936", async() => {
                WriteLiteral("\n    <div class=\"container\">\n        <div class=\"title\">Register</div>\n        <div class=\"content\">\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cae2b8dfb5b264822b99ddd711319707431a32a11312", async() => {
                    WriteLiteral(@"
                <div class=""user-details"">
                    <div class=""input-box"">
                        <span class=""details"">Nombre</span>
                        <input type=""text"" placeholder=""Inserta Tu Nombre"" required>
                    </div>
                    <div class=""input-box"">
                        <span class=""details"">Apellido Paterno</span>
                        <input type=""text"" placeholder=""Inserta Tu Appelido"" required>
                    </div>
                    <div class=""input-box"">
                        <span class=""details"">Apeliido Materno</span>
                        <input type=""text"" placeholder=""Inserta Tu Apellido"" required>
                    </div>
                    <div class=""input-box"">
                        <span class=""details"">Edad</span>
                        <input type=""text"" placeholder=""Inserta Tu Edad"" required>
                    </div>
                    <div class=""input-box"">
                        <span class=""details"">Userna");
                    WriteLiteral(@"me</span>
                        <input type=""text"" placeholder=""Inserta Usuario Deseado"" required>
                    </div>
                    <div class=""input-box"">
                        <span class=""details"">Correo</span>
                        <input type=""text"" placeholder=""Inserta Correo"" required>
                    </div>
                    <div class=""input-box"">
                        <span class=""details"">Contraseña</span>
                        <input type=""password"" placeholder=""Inserta Contraeña Deseada"" id=""password"" required>
                    </div>
                    <div class=""input-box"">
                        <span class=""details"">Confirma Contraseña</span>
                        <input type=""password"" placeholder=""Confirma Contraseña"" id=""confirm_password"" required>
                    </div>
                </div>
                <div class=""cuenta-details"">
                    <input type=""radio"" name=""cuenta"" id=""dot-1"">
                    <input type=""radio"" name=""");
                    WriteLiteral(@"cuenta"" id=""dot-2"">
                    <input type=""radio"" name=""cuenta"" id=""dot-3"">
                    <span class=""cuenta-title"">Tipo de Cuenta: </span>
                    <div class=""category"">
                        <label for=""dot-1"">
                            <span class=""dot one""></span>
                            <span class=""cuenta"">Usuario General</span>
                        </label>
                        <label for=""dot-2"">
                            <span class=""dot two""></span>
                            <span class=""cuenta"">Administrador</span>
                        </label>
                        <label for=""dot-3"">
                            <span class=""dot three""></span>
                            <span class=""cuenta"">Otro</span>
                        </label>
                    </div>
                </div>
                <div class=""button"">
                    <input type=""submit"" value=""Register"">
                </div>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        </div>\n    </div>\n\n");
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
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UsuarioModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

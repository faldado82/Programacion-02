#pragma checksum "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Usuario\OpBusqueda.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c82855dac45ce9fba738043656a7b92d8dafc19f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_OpBusqueda), @"mvc.1.0.view", @"/Views/Usuario/OpBusqueda.cshtml")]
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
#line 1 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\_ViewImports.cshtml"
using Obligatorio2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\_ViewImports.cshtml"
using Obligatorio2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c82855dac45ce9fba738043656a7b92d8dafc19f", @"/Views/Usuario/OpBusqueda.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87e36970f455aae1bee373d97230b042ea67aa2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_OpBusqueda : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formBusqueda"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("container-fluid bg-dark text-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c82855dac45ce9fba738043656a7b92d8dafc19f4585", async() => {
                WriteLiteral("\r\n    <h1>Busqueda de compras realizadas entre dos fechas</h1>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-4\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c82855dac45ce9fba738043656a7b92d8dafc19f4983", async() => {
                    WriteLiteral(@"

                <label>Ingrese la primera fecha:</label> <br />
                <input type=""date"" name=""f1"" class=""form-control"" id=""f1"" required/> <br />

                <label>Ingrese la segunda fecha:</label> <br />
                <input type=""date"" name=""f2"" class=""form-control"" id=""f2""  required/> <br />

                <input type=""submit"" name=""name"" value=""Iniciar Busqueda"" class=""btn btn-primary mb-3"" />
                <p id=""pMensaje""></p>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n\r\n\r\n        <div class=\"col-12\">\r\n\r\n");
#nullable restore
#line 22 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Usuario\OpBusqueda.cshtml"
             if (ViewBag.LargoCompras > 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <h3 class=\"mt-3\">Resultado</h3>\r\n");
                WriteLiteral(@"                <table class=""table table-striped text-light"">
                    <thead>
                        <tr>
                            <th>
                                NOMBRE DE ACTIVIDAD
                            </th>
                            <th>
                                CANTIDAD ENTRADAS
                            </th>
                            <th>
                                NOMBRE DE USUARIO
                            </th>
                            <th>
                                FECHA HORA COMPRA
                            </th>
                            <th>
                                PRECIO
                            </th>

                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 48 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Usuario\OpBusqueda.cshtml"
                         foreach (var c in ViewBag.ComprasFecha)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 52 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Usuario\OpBusqueda.cshtml"
                               Write(c.Actividad.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 55 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Usuario\OpBusqueda.cshtml"
                               Write(c.CantidadEntradas);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 58 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Usuario\OpBusqueda.cshtml"
                               Write(c.Usuario.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 61 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Usuario\OpBusqueda.cshtml"
                               Write(c.FechaHoraCompra);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 64 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Usuario\OpBusqueda.cshtml"
                               Write(c.PrecioFinal);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 67 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Usuario\OpBusqueda.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n                    </tbody>\r\n                </table>\r\n");
#nullable restore
#line 73 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Usuario\OpBusqueda.cshtml"
            }
            else {

#line default
#line hidden
#nullable disable
                WriteLiteral("             <p> No hay coincidencias para su busqueda </p>\r\n");
#nullable restore
#line 76 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 2\P2\OBLIGATORIO 2 P2\version final\Obligatorio2 version final\Obligatorio2\Views\Usuario\OpBusqueda.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n</div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

<script>
    document.querySelector(""#formBusqueda"").addEventListener('submit', FormularioBusqueda);

    function FormularioBusqueda(evento) {
        evento.preventDefault();
        
        let f1 = document.querySelector(""#f1"").value;
        let f2 = document.querySelector(""#f2"").value;
        let mensaje = """";
        if (f1 > f2) {
            var aux = f1;
            f1 = f2;
            f2 = aux;
        }
        if (f1 != """" && f2 != """") {
            this.submit();

        } else {
            mensaje = ""error en el ingreso de fechas"";
        }
        document.querySelector(""#pMensaje"").innerHTML = mensaje;
    }

</script>
    
    


 ");
            }
            );
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
#pragma checksum "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Eliminar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f1c75b00aed699de657fbab69084ddd4b222659"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Eliminar), @"mvc.1.0.view", @"/Views/Usuario/Eliminar.cshtml")]
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
#line 1 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\_ViewImports.cshtml"
using VWorkS.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f1c75b00aed699de657fbab69084ddd4b222659", @"/Views/Usuario/Eliminar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c5605e86bfdc163e2749e6e7847f380f6d2a4bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Eliminar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VWorkS.Data.UsuarioManto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Eliminar.cshtml"
Write(Html.HiddenFor(model => model.Usuario.EstadoRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Eliminar.cshtml"
Write(Html.Hidden("TipoManto", (object)@ViewBag.TipoManto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<input name=\"IsValid\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 185, "\"", 232, 1);
#nullable restore
#line 7 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Eliminar.cshtml"
WriteAttributeValue("", 193, ViewData.ModelState.IsValid.ToString(), 193, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n<div class=\"form-group row\">\r\n    <label class=\"col-md-4 control-label\">Id</label>\r\n    <div class=\"col-md-12\">\r\n        ");
#nullable restore
#line 12 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Eliminar.cshtml"
   Write(Html.EditorFor(model => model.Usuario.IdUsuario, new { htmlAttributes = new { @class = "form-control", @readonly = "true", @type = "" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 13 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Eliminar.cshtml"
   Write(Html.ValidationMessageFor(model => model.Usuario.IdUsuario, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"form-group row\">\r\n    <label class=\"col-md-4 control-label\">Nombre De Usuario</label>\r\n    <div class=\"col-md-12\">\r\n        ");
#nullable restore
#line 19 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Eliminar.cshtml"
   Write(Html.EditorFor(model => model.Usuario.NombreUsuario, new { htmlAttributes = new { @class = "form-control", @readonly = "true" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 20 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Eliminar.cshtml"
   Write(Html.ValidationMessageFor(model => model.Usuario.NombreUsuario, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"form-group\">\r\n");
#nullable restore
#line 24 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Eliminar.cshtml"
     if (Model.Usuario.EstadoRegistro == "A")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""input-group"">
            <label class=""control-label"" id=""switch01"" name=""switch01"">Activo</label>
            <div class=""input-group-append"">
                <div class=""switch"">
                    <label>
                        <input type=""checkbox"" disabled checked id=""radio_01"" name=""radio_01""><span class=""lever switch-col-light-green""></span>
                    </label>
                </div>
            </div>
        </div>
");
#nullable restore
#line 36 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Eliminar.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""input-group"">
            <label class=""control-label"" id=""switch01"" name=""switch01"">Inactivo</label>
            <div class=""input-group-append"">
                <div class=""switch"">
                    <label>
                        <input type=""checkbox"" disabled id=""radio_01"" name=""radio_01""><span class=""lever switch-col-light-green""></span>
                    </label>
                </div>
            </div>
        </div>
");
#nullable restore
#line 49 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Eliminar.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<hr />\r\n<ul class=\"nav nav-tabs\">\r\n    <li class=\"nav-item\">\r\n        <a href=\"#ultimamodificacion\" data-toggle=\"tab\" aria-expanded=\"false\" class=\"nav-link active\">\r\n            <span");
            BeginWriteAttribute("class", " class=\"", 2265, "\"", 2273, 0);
            EndWriteAttribute();
            WriteLiteral(">Modificaci??n</span>\r\n        </a>\r\n    </li>\r\n    <li class=\"nav-item\">\r\n        <a href=\"#otrasmodificaciones\" data-toggle=\"tab\" aria-expanded=\"true\"\r\n           class=\"nav-link\">\r\n            <span");
            BeginWriteAttribute("class", " class=\"", 2474, "\"", 2482, 0);
            EndWriteAttribute();
            WriteLiteral(@">Otras Modificaciones</span>
        </a>
    </li>
</ul>
<div class=""tab-content border"">
    <div class=""tab-pane show active"" id=""ultimamodificacion"">
        <div class=""form-group"">
            <label class=""col-md-4 control-label"">Fecha y Hora</label>
            <div class=""col-md-12"">
                <input");
            BeginWriteAttribute("value", " value=\"", 2808, "\"", 2848, 1);
#nullable restore
#line 70 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Eliminar.cshtml"
WriteAttributeValue("", 2816, Model.Usuario.FechaHoraModifica, 2816, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""Usuario.FechaHoraModifica"" readonly class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-md-4 control-label"">Usuario</label>
            <div class=""col-md-12"">
                <input");
            BeginWriteAttribute("value", " value=\"", 3113, "\"", 3149, 1);
#nullable restore
#line 76 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Eliminar.cshtml"
WriteAttributeValue("", 3121, Model.Usuario.NombreUsuario, 3121, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Usuario.Usuario\" readonly class=\"form-control\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 81 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Eliminar.cshtml"
  
    if (!ViewData.ModelState.IsValid)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 85 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Eliminar.cshtml"
        var error = ViewData.ModelState["EliminarError"].Errors;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""alert alert-warning alert-dismissible fade show"" role=""alert"" style=""margin-bottom:-6px;"">
    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
        <span aria-hidden=""true"">&times;</span>
    </button>
    <strong>Error - </strong>No es posible eliminar el Usuario, para dejar de utilizarlo cambie el estado a INACTIVO.
</div>
");
#nullable restore
#line 92 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Eliminar.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VWorkS.Data.UsuarioManto> Html { get; private set; }
    }
}
#pragma warning restore 1591

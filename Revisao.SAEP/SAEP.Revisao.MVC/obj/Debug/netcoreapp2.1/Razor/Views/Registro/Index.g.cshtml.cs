#pragma checksum "C:\Users\00836578279\Desktop\2s2019-t3-treinamento\Revisao.SAEP\SAEP.Revisao.MVC\Views\Registro\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "981e1cc25711153e8eb401d845a96d375de4d785"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registro_Index), @"mvc.1.0.view", @"/Views/Registro/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Registro/Index.cshtml", typeof(AspNetCore.Views_Registro_Index))]
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
#line 1 "C:\Users\00836578279\Desktop\2s2019-t3-treinamento\Revisao.SAEP\SAEP.Revisao.MVC\Views\_ViewImports.cshtml"
using SAEP.Revisao.MVC;

#line default
#line hidden
#line 2 "C:\Users\00836578279\Desktop\2s2019-t3-treinamento\Revisao.SAEP\SAEP.Revisao.MVC\Views\_ViewImports.cshtml"
using SAEP.Revisao.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"981e1cc25711153e8eb401d845a96d375de4d785", @"/Views/Registro/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c1cfe143ec1cda45b5b5dd984b36b2c2c566d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Registro_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SAEP.Revisao.MVC.Dominios.RegistroDefeito>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\00836578279\Desktop\2s2019-t3-treinamento\Revisao.SAEP\SAEP.Revisao.MVC\Views\Registro\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#line 6 "C:\Users\00836578279\Desktop\2s2019-t3-treinamento\Revisao.SAEP\SAEP.Revisao.MVC\Views\Registro\Index.cshtml"
 if (ViewBag.Mensagem != null)
{

#line default
#line hidden
            BeginContext(141, 60, true);
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
            EndContext();
            BeginContext(202, 26, false);
#line 9 "C:\Users\00836578279\Desktop\2s2019-t3-treinamento\Revisao.SAEP\SAEP.Revisao.MVC\Views\Registro\Index.cshtml"
   Write(Html.Raw(ViewBag.Mensagem));

#line default
#line hidden
            EndContext();
            BeginContext(228, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 11 "C:\Users\00836578279\Desktop\2s2019-t3-treinamento\Revisao.SAEP\SAEP.Revisao.MVC\Views\Registro\Index.cshtml"
}

#line default
#line hidden
            BeginContext(245, 389, true);
            WriteLiteral(@"<h2>Relatórios</h2>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Data
            </th>
            <th>
                Equipamento
            </th>
            <th>
                Defeito
            </th>
            <th>
                Descrição
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 33 "C:\Users\00836578279\Desktop\2s2019-t3-treinamento\Revisao.SAEP\SAEP.Revisao.MVC\Views\Registro\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(683, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(744, 47, false);
#line 37 "C:\Users\00836578279\Desktop\2s2019-t3-treinamento\Revisao.SAEP\SAEP.Revisao.MVC\Views\Registro\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DataRegistro));

#line default
#line hidden
            EndContext();
            BeginContext(791, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(859, 67, false);
#line 40 "C:\Users\00836578279\Desktop\2s2019-t3-treinamento\Revisao.SAEP\SAEP.Revisao.MVC\Views\Registro\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IdTipoEquipamentoNavigation.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(926, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(994, 66, false);
#line 43 "C:\Users\00836578279\Desktop\2s2019-t3-treinamento\Revisao.SAEP\SAEP.Revisao.MVC\Views\Registro\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IdDefeitoNavigation.NomeDefeito));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1128, 44, false);
#line 46 "C:\Users\00836578279\Desktop\2s2019-t3-treinamento\Revisao.SAEP\SAEP.Revisao.MVC\Views\Registro\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(1172, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 49 "C:\Users\00836578279\Desktop\2s2019-t3-treinamento\Revisao.SAEP\SAEP.Revisao.MVC\Views\Registro\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1227, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SAEP.Revisao.MVC.Dominios.RegistroDefeito>> Html { get; private set; }
    }
}
#pragma warning restore 1591

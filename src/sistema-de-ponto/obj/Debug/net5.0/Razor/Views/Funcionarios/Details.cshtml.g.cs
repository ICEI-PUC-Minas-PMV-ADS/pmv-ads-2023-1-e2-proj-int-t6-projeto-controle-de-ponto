#pragma checksum "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aebd5aec801fc33367c780785cad748735b2af76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionarios_Details), @"mvc.1.0.view", @"/Views/Funcionarios/Details.cshtml")]
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
#line 1 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\_ViewImports.cshtml"
using sistema_de_ponto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\_ViewImports.cshtml"
using sistema_de_ponto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aebd5aec801fc33367c780785cad748735b2af76", @"/Views/Funcionarios/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ca671fecfc0fc8fef013f1327d5b7ac06ccd576", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Funcionarios_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema_de_ponto.Models.Funcionario>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary rounded-pill"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalhes Colaborador</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sobrenome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Sobrenome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Departamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Departamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cargo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cargo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 49 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 52 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 55 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 58 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 61 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Senha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 64 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Senha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 67 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Perfil));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 70 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Perfil));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 73 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Foto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 76 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Foto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 79 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Empresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 82 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Empresa.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aebd5aec801fc33367c780785cad748735b2af7613990", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\Funcionarios\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aebd5aec801fc33367c780785cad748735b2af7616314", async() => {
                WriteLiteral("Cancelar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema_de_ponto.Models.Funcionario> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

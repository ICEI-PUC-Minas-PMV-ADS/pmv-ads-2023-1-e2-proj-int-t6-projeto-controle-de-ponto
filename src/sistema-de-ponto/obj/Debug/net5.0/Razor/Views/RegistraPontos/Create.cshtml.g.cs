#pragma checksum "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\RegistraPontos\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a64860a1c006db89dae0b4758610d98efd789777"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegistraPontos_Create), @"mvc.1.0.view", @"/Views/RegistraPontos/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a64860a1c006db89dae0b4758610d98efd789777", @"/Views/RegistraPontos/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ca671fecfc0fc8fef013f1327d5b7ac06ccd576", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_RegistraPontos_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema_de_ponto.Models.RegistraPonto>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\RegistraPontos\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h1>Bater Ponto</h1>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\RegistraPontos\Create.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Data: ");
#nullable restore
#line 13 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\RegistraPontos\Create.cshtml"
        Write(Model.Data.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 15 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\RegistraPontos\Create.cshtml"
     if (Model.HoraEntrada1 == default(DateTime))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Horário de Entrada 1: Ainda não batido</p>\r\n");
#nullable restore
#line 18 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\RegistraPontos\Create.cshtml"
    }
    else
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\RegistraPontos\Create.cshtml"
   Write(Html.LabelFor(model=> model.HoraEntrada1));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\RegistraPontos\Create.cshtml"
   Write(Html.TextBoxFor(model=> model.HoraEntrada1, "{0:HH\\:mm}", new { @class = "form-control" , @readonly ="readonly"} ));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\RegistraPontos\Create.cshtml"
                                                                                                                            

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\RegistraPontos\Create.cshtml"
     if (Model.HoraSaida1 == default(DateTime))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Horário de Saída 1: Ainda não batido</p>\r\n");
#nullable restore
#line 30 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\RegistraPontos\Create.cshtml"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\RegistraPontos\Create.cshtml"
   Write(Html.LabelFor(model => model.HoraSaida1));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\RegistraPontos\Create.cshtml"
   Write(Html.TextBoxFor(model=> model.HoraSaida1, "{0:HH\\:mm}", new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\RegistraPontos\Create.cshtml"
                                                                                                 
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\RegistraPontos\Create.cshtml"
     if (Model.HoraEntrada2 == default(DateTime))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Horário de Entrada 2: Ainda não batido</p>\r\n");
#nullable restore
#line 40 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\RegistraPontos\Create.cshtml"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\RegistraPontos\Create.cshtml"
   Write(Html.LabelFor(model => model.HoraEntrada2));

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\RegistraPontos\Create.cshtml"
   Write(Html.TextBoxFor(model=> model.HoraEntrada2, "{0:HH\\:mm}", new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\RegistraPontos\Create.cshtml"
                                                                                                   
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\RegistraPontos\Create.cshtml"
     if (Model.HoraSaida2 == default(DateTime))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Horário de Saída 2: Ainda não batido</p>\r\n");
#nullable restore
#line 50 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\RegistraPontos\Create.cshtml"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\RegistraPontos\Create.cshtml"
   Write(Html.LabelFor(model => model.HoraSaida2));

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\RegistraPontos\Create.cshtml"
   Write(Html.TextBoxFor(model=> model.HoraSaida2, "{0:HH\\:mm}", new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\RegistraPontos\Create.cshtml"
                                                                                                 
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\RegistraPontos\Create.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a64860a1c006db89dae0b4758610d98efd78977711400", async() => {
                WriteLiteral("\r\n    <button type=\"submit\" class=\"btn btn-primary\">Bater Ponto</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 65 "C:\Users\Jeosafa\Documents\GitHub\pmv-ads-2023-1-e2-proj-int-t6-projeto-controle-de-ponto\src\sistema-de-ponto\Views\RegistraPontos\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema_de_ponto.Models.RegistraPonto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

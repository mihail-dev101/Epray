#pragma checksum "C:\Users\ASUS\Desktop\Advanced\EPray\EPray\Views\User\Signin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6107bdc58352e565aef4ed69b189bec7b1b9067d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Signin), @"mvc.1.0.view", @"/Views/User/Signin.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\Advanced\EPray\EPray\Views\_ViewImports.cshtml"
using EPray;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Advanced\EPray\EPray\Views\_ViewImports.cshtml"
using EPray.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6107bdc58352e565aef4ed69b189bec7b1b9067d", @"/Views/User/Signin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c742fb1c15d4066fcd64deb56e2c2b571be95bf", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Signin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EPray.Models.RegistrationModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Advanced\EPray\EPray\Views\User\Signin.cshtml"
 using (Html.BeginForm("Signin", "User", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div>\r\n            <div>\r\n                <h3>Sign in</h3>\r\n                <i class=\"fa fa-envelope\"></i> Email<br />\r\n                ");
#nullable restore
#line 10 "C:\Users\ASUS\Desktop\Advanced\EPray\EPray\Views\User\Signin.cshtml"
           Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 11 "C:\Users\ASUS\Desktop\Advanced\EPray\EPray\Views\User\Signin.cshtml"
           Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <i class=\"fa fa-key\" aria-hidden=\"true\"></i> Password <br />\r\n                ");
#nullable restore
#line 13 "C:\Users\ASUS\Desktop\Advanced\EPray\EPray\Views\User\Signin.cshtml"
           Write(Html.TextBoxFor(m => m.Password, new { @class = "form-control", type = "Password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 14 "C:\Users\ASUS\Desktop\Advanced\EPray\EPray\Views\User\Signin.cshtml"
           Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <div id=\"sign-in\">\r\n                    <input type=\"submit\" value=\"Sign In\" />\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 22 "C:\Users\ASUS\Desktop\Advanced\EPray\EPray\Views\User\Signin.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EPray.Models.RegistrationModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\VotingManageMentSystem\StudentDetails\Views\Student\GetOrganizationData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "133901dc5d5f0393b445fce180a9d902a07d1ace"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_GetOrganizationData), @"mvc.1.0.view", @"/Views/Student/GetOrganizationData.cshtml")]
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
#line 1 "D:\VotingManageMentSystem\StudentDetails\Views\_ViewImports.cshtml"
using StudentDetails;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VotingManageMentSystem\StudentDetails\Views\_ViewImports.cshtml"
using StudentDetails.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"133901dc5d5f0393b445fce180a9d902a07d1ace", @"/Views/Student/GetOrganizationData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"562f07bea4f56f07d452220edc3f37cafa0319b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_GetOrganizationData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentDetails.Models.Organization>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\VotingManageMentSystem\StudentDetails\Views\Student\GetOrganizationData.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 6 "D:\VotingManageMentSystem\StudentDetails\Views\Student\GetOrganizationData.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<p><b>Teacher List</b></p>\r\n\r\n<table>\r\n    <tr>\r\n        <th>EmpId</th>\r\n        <th>EmpName</th>\r\n        <th>Email</th>\r\n        <th>PhoneNumber</th>\r\n        <th>Age</th>\r\n    </tr>\r\n");
#nullable restore
#line 18 "D:\VotingManageMentSystem\StudentDetails\Views\Student\GetOrganizationData.cshtml"
     foreach (ITEmployee teacher in Model.ITEmployees)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 21 "D:\VotingManageMentSystem\StudentDetails\Views\Student\GetOrganizationData.cshtml"
   Write(teacher.EmpId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 22 "D:\VotingManageMentSystem\StudentDetails\Views\Student\GetOrganizationData.cshtml"
   Write(teacher.EmpName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 23 "D:\VotingManageMentSystem\StudentDetails\Views\Student\GetOrganizationData.cshtml"
   Write(teacher.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 24 "D:\VotingManageMentSystem\StudentDetails\Views\Student\GetOrganizationData.cshtml"
   Write(teacher.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 25 "D:\VotingManageMentSystem\StudentDetails\Views\Student\GetOrganizationData.cshtml"
   Write(teacher.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n</tr>\r\n");
#nullable restore
#line 27 "D:\VotingManageMentSystem\StudentDetails\Views\Student\GetOrganizationData.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentDetails.Models.Organization> Html { get; private set; }
    }
}
#pragma warning restore 1591

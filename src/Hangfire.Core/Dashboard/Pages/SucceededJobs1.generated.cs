﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangfire.Dashboard.Pages
{
    
    #line 2 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
    using System;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 3 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
    using Hangfire.Common;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
    using Hangfire.Dashboard.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class SucceededJobs : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");







            
            #line 7 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
  
    Layout = new LayoutPage("Succeeded Jobs");

    int from, perPage;

    int.TryParse(Query("from"), out from);
    int.TryParse(Query("count"), out perPage);

    var monitor = Storage.GetMonitoringApi();
    var pager = new Pager(from, perPage, monitor.SucceededListCount())
    {
        BasePageUrl = LinkTo("/jobs/succeeded")
    };

    var succeededJobs = monitor.SucceededJobs(pager.FromRecord, pager.RecordsPerPage);


            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");


            
            #line 26 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
   Write(RenderPartial(new SidebarMenu(JobsSidebarMenu.Items)));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <h1 class=\"page-header\">Succeed" +
"ed Jobs</h1>\r\n\r\n");


            
            #line 31 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
         if (pager.TotalPageCount == 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"alert alert-info\">\r\n                No succeeded jobs fou" +
"nd.\r\n            </div>\r\n");


            
            #line 36 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"js-jobs-list\">\r\n                <div class=\"btn-toolbar b" +
"tn-toolbar-top\">\r\n                    <button class=\"js-jobs-list-command btn bt" +
"n-sm btn-primary\"\r\n                            data-url=\"");


            
            #line 42 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                 Write(LinkTo("/jobs/succeeded/requeue"));

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                            data-loading-text=\"Enqueueing...\">\r\n              " +
"          <span class=\"glyphicon glyphicon-repeat\"></span>\r\n                    " +
"    Requeue jobs\r\n                    </button>\r\n\r\n                    ");


            
            #line 48 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
               Write(RenderPartial(new PerPageSelector(pager)));

            
            #line default
            #line hidden
WriteLiteral(@"
                </div>

                <table class=""table"">
                    <thead>
                    <tr>
                        <th class=""min-width"">
                            <input type=""checkbox"" class=""js-jobs-list-select-all""/>
                        </th>
                        <th class=""min-width"">Id</th>
                        <th>Job</th>
                        <th class=""min-width"">Total Duration</th>
                        <th class=""align-right"">Succeeded</th>
                    </tr>
                    </thead>
                    <tbody>
");


            
            #line 64 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                     foreach (var job in succeededJobs)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <tr class=\"js-jobs-list-row ");


            
            #line 66 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                Write(job.Value != null && !job.Value.InSucceededState ? "obsolete-data" : null);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 66 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                                                                                             Write(job.Value != null && job.Value.InSucceededState ? "hover" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            <td>\r\n");


            
            #line 68 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                 if (job.Value != null && job.Value.InSucceededState)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <input type=\"checkbox\" class=\"js-jobs-list-ch" +
"eckbox\" name=\"jobs[]\" value=\"");


            
            #line 70 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                                                                         Write(job.Key);

            
            #line default
            #line hidden
WriteLiteral("\"/>\r\n");


            
            #line 71 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </td>\r\n                            <td class=\"min-wid" +
"th\">\r\n                                <a href=\"");


            
            #line 74 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                    Write(LinkTo("/jobs/" + job.Key));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                    ");


            
            #line 75 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                               Write(Html.JobId(job.Key));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </a>\r\n");


            
            #line 77 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                 if (job.Value != null && !job.Value.InSucceededState)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <span title=\"Job\'s state has been changed whi" +
"le fetching data.\" class=\"glyphicon glyphicon-question-sign\"></span>\r\n");


            
            #line 80 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </td>\r\n\r\n");


            
            #line 83 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                             if (job.Value == null)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <td colspan=\"3\">\r\n                               " +
"     <em>Job has expired.</em>\r\n                                </td>\r\n");


            
            #line 88 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                            }
                            else
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <td>\r\n                                    <a clas" +
"s=\"job-method\" href=\"");


            
            #line 92 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                           Write(LinkTo("/jobs/" + job.Key));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                        ");


            
            #line 93 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                   Write(Html.DisplayJob(job.Value.Job));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    </a>\r\n                                </td>" +
"\r\n");



WriteLiteral("                                <td class=\"min-width align-right\">\r\n");


            
            #line 97 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                     if (job.Value.TotalDuration.HasValue)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        ");

WriteLiteral(" ");


            
            #line 99 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                      Write(Html.ToHumanDuration(job.Value.TotalDuration.Value, false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 100 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </td>\r\n");



WriteLiteral("                                <td class=\"min-width align-right\">\r\n");


            
            #line 103 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                     if (job.Value.SucceededAt.HasValue)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <span data-moment=\"");


            
            #line 105 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                      Write(JobHelper.ToTimestamp(job.Value.SucceededAt.Value));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                                ");


            
            #line 106 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                           Write(job.Value.SucceededAt);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                            </span>\r\n");


            
            #line 108 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </td>\r\n");


            
            #line 110 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </tr>\r\n");


            
            #line 112 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n");


            
            #line 116 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
            
            
            #line default
            #line hidden
            
            #line 116 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
       Write(RenderPartial(new Paginator(pager)));

            
            #line default
            #line hidden
            
            #line 116 "..\..\Dashboard\Pages\SucceededJobs.cshtml"
                                                
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>");


        }
    }
}
#pragma warning restore 1591

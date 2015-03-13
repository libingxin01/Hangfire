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
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 2 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
    using Hangfire.Common;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
    using Hangfire.Dashboard.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class DeletedJobsPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");






            
            #line 6 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
  
    Layout = new LayoutPage("Deleted Jobs");

    int from, perPage;

    int.TryParse(Query("from"), out from);
    int.TryParse(Query("count"), out perPage);

    var monitor = Storage.GetMonitoringApi();
    var pager = new Pager(from, perPage, monitor.DeletedListCount())
    {
        BasePageUrl = LinkTo("/jobs/deleted")
    };

    var jobs = monitor.DeletedJobs(pager.FromRecord, pager.RecordsPerPage);


            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");


            
            #line 25 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
   Write(RenderPartial(new SidebarMenu(JobsSidebarMenu.Items)));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <h1 class=\"page-header\">Deleted" +
" Jobs</h1>\r\n\r\n");


            
            #line 30 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
         if (pager.TotalPageCount == 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"alert alert-info\">\r\n                No deleted jobs found" +
".\r\n            </div>\r\n");


            
            #line 35 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"js-jobs-list\">\r\n                <div class=\"btn-toolbar b" +
"tn-toolbar-top\">\r\n                    <button class=\"js-jobs-list-command btn bt" +
"n-sm btn-primary\"\r\n                            data-url=\"");


            
            #line 41 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
                                 Write(LinkTo("/jobs/deleted/requeue"));

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                            data-loading-text=\"Enqueueing...\">\r\n              " +
"          <span class=\"glyphicon glyphicon-repeat\"></span>\r\n                    " +
"    Requeue jobs\r\n                    </button>\r\n                    ");


            
            #line 46 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
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
                        <th class=""align-right"">Deleted</th>
                    </tr>
                    </thead>
                    <tbody>
");


            
            #line 60 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
                     foreach (var job in jobs)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <tr class=\"js-jobs-list-row ");


            
            #line 62 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
                                                Write(job.Value != null && !job.Value.InDeletedState ? "obsolete-data" : null);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 62 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
                                                                                                                           Write(job.Value != null && job.Value.InDeletedState && job.Value != null ? "hover" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            <td>\r\n");


            
            #line 64 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
                                 if (job.Value != null && job.Value.InDeletedState)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <input type=\"checkbox\" class=\"js-jobs-list-ch" +
"eckbox\" name=\"jobs[]\" value=\"");


            
            #line 66 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
                                                                                                         Write(job.Key);

            
            #line default
            #line hidden
WriteLiteral("\"/>\r\n");


            
            #line 67 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </td>\r\n                            <td class=\"min-wid" +
"th\">\r\n                                <a href=\"");


            
            #line 70 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
                                    Write(LinkTo("/jobs/" + job.Key));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                    ");


            
            #line 71 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
                               Write(Html.JobId(job.Key));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </a>\r\n");


            
            #line 73 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
                                 if (job.Value != null && !job.Value.InDeletedState)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <span title=\"Job\'s state has been changed whi" +
"le fetching data.\" class=\"glyphicon glyphicon-question-sign\"></span>\r\n");


            
            #line 76 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </td>\r\n\r\n");


            
            #line 79 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
                             if (job.Value == null)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <td colspan=\"2\">\r\n                               " +
"     <em>Job has expired.</em>\r\n                                </td>\r\n");


            
            #line 84 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
                            }
                            else
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <td>\r\n                                    <a clas" +
"s=\"job-method\" href=\"");


            
            #line 88 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
                                                           Write(LinkTo("/jobs/" + job.Key));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                        ");


            
            #line 89 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
                                   Write(Html.DisplayJob(job.Value.Job));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    </a>\r\n                                </td>" +
"\r\n");



WriteLiteral("                                <td class=\"align-right\">\r\n");


            
            #line 93 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
                                     if (job.Value.DeletedAt.HasValue)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <span data-moment=\"");


            
            #line 95 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
                                                      Write(JobHelper.ToTimestamp(job.Value.DeletedAt.Value));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                                ");


            
            #line 96 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
                                           Write(job.Value.DeletedAt);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                            </span>\r\n");


            
            #line 98 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </td>\r\n");


            
            #line 100 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </tr>\r\n");


            
            #line 102 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n");


            
            #line 106 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
            
            
            #line default
            #line hidden
            
            #line 106 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
       Write(RenderPartial(new Paginator(pager)));

            
            #line default
            #line hidden
            
            #line 106 "..\..\Dashboard\Pages\DeletedJobsPage.cshtml"
                                                
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n\r\n");


        }
    }
}
#pragma warning restore 1591

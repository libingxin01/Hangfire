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
    
    #line 2 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
    using System;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    
    #line 3 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 4 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
    using Hangfire.Common;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
    using Hangfire.Dashboard.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class JobDetailsPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");








            
            #line 8 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
  
    var monitor = Storage.GetMonitoringApi();
    var job = monitor.JobDetails(JobId.ToString());

    string title = null;

    if (job != null)
    {
        title = job.Job != null ? Html.DisplayJob(job.Job) : null;
    }

    title = title ?? "Job";
    Layout = new LayoutPage(title);


            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");


            
            #line 25 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
   Write(RenderPartial(new SidebarMenu(JobsSidebarMenu.Items)));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <h1 class=\"page-header\">");


            
            #line 28 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                           Write(title);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n\r\n");


            
            #line 30 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
         if (job == null)
        {

            
            #line default
            #line hidden
WriteLiteral("            ");

WriteLiteral(" The job with id \'");


            
            #line 32 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                           Write(JobId);

            
            #line default
            #line hidden
WriteLiteral("\' has expired or could not be found on the server.\r\n");


            
            #line 33 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
        }
        else
        {
            if (job.ExpireAt.HasValue)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div class=\"alert alert-info\">\r\n                    <strong>The j" +
"ob has been finished</strong>.\r\n                    It will be removed automatic" +
"ally <em><abbr data-moment=\"");


            
            #line 40 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                                                                       Write(JobHelper.ToTimestamp(job.ExpireAt.Value));

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 40 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                                                                                                                   Write(job.ExpireAt);

            
            #line default
            #line hidden
WriteLiteral("</abbr></em>.\r\n                </div>\r\n");


            
            #line 42 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
            }


            
            #line default
            #line hidden
WriteLiteral("            <div class=\"job-snippet-header\">\r\n                <span class=\"job-sn" +
"ippet-tab\">\r\n                    Job ID: <span class=\"job-snippet-id\">");


            
            #line 46 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                                                    Write(Html.JobId(JobId.ToString(), false));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </span>\r\n\r\n                <span class=\"job-snippet-butt" +
"ons pull-right\">\r\n                    <button class=\"btn btn-xs btn-default\" dat" +
"a-ajax=\"");


            
            #line 50 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                                                                 Write(LinkTo("/jobs/actions/requeue/" + JobId));

            
            #line default
            #line hidden
WriteLiteral("\" data-loading-text=\"Enqueueing...\">Requeue</button>\r\n                    <button" +
" class=\"btn btn-xs btn-death\" data-ajax=\"");


            
            #line 51 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                                                               Write(LinkTo("/jobs/actions/delete/" + JobId));

            
            #line default
            #line hidden
WriteLiteral("\" data-loading-text=\"Deleting...\" data-confirm=\"Do you really want to delete this" +
" job?\">Delete</button>\r\n                </span>\r\n\r\n                <div class=\"c" +
"learfix\"></div>\r\n            </div>\r\n");



WriteLiteral("            <div class=\"job-snippet\">\r\n                <div class=\"job-snippet-co" +
"de\">\r\n");


            
            #line 58 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                     if (job.CreatedAt.HasValue)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div class=\"pull-right job-creation-date\">\r\n             " +
"               Created\r\n                            <span data-moment=\"");


            
            #line 62 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                                          Write(JobHelper.ToTimestamp(job.CreatedAt.Value));

            
            #line default
            #line hidden
WriteLiteral("\"></span>\r\n                        </div>\r\n");


            
            #line 64 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                    }

            
            #line default
            #line hidden

            
            #line 65 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                     if (job != null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <pre><code>");


            
            #line 67 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                              Write(JobMethodCallRenderer.Render(job.Job));

            
            #line default
            #line hidden
WriteLiteral("</code></pre>\r\n");


            
            #line 68 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <div class=\"clearfix\"></div>\r\n                </div>\r\n\r\n");


            
            #line 72 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                 if (job.Properties.Count > 0)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div class=\"job-snippet-properties\">\r\n                       " +
" <dl>\r\n");


            
            #line 76 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                             foreach (var property in job.Properties)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <dt>");


            
            #line 78 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                               Write(property.Key);

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n");



WriteLiteral("                                <dd>\r\n                                    <pre>");


            
            #line 80 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                                    Write(property.Value);

            
            #line default
            #line hidden
WriteLiteral("</pre>\r\n                                </dd>\r\n");


            
            #line 82 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </dl>\r\n                    </div>\r\n");


            
            #line 85 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n");


            
            #line 87 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"

            if (job.History.Count > 0)
            {

            
            #line default
            #line hidden
WriteLiteral("                <h3>History</h3>\r\n");


            
            #line 91 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                var index = 0;

                DateTime[] entriesCreationTime = job.History.Select(x => x.CreatedAt).ToArray();
                var nextEntry = 1;

                foreach (var entry in job.History)
                {
                    var background = index == 0
                        ? JobHistoryRenderer.GetForegroundStateColor(entry.StateName)
                        : JobHistoryRenderer.GetBackgroundStateColor(entry.StateName);


            
            #line default
            #line hidden
WriteLiteral("                    <div class=\"job-history ");


            
            #line 102 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                                        Write(index == 0 ? "job-history-current" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                        <div class=\"job-history-heading\" style=\"");


            
            #line 103 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                                                           Write(String.Format("background-color: {0};", background));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            <span class=\"pull-right\" data-moment-title=\"");


            
            #line 104 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                                                                    Write(JobHelper.ToTimestamp(entry.CreatedAt));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                ");


            
            #line 105 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                           Write(Html.ToHumanDuration(entry.CreatedAt - (nextEntry < entriesCreationTime.Length ? entriesCreationTime[nextEntry] : job.CreatedAt)));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 106 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                                   nextEntry++; 

            
            #line default
            #line hidden
WriteLiteral("                            </span>\r\n                            <h4 class=\"job-h" +
"istory-title\">\r\n                                ");


            
            #line 109 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                           Write(entry.StateName);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");


            
            #line 111 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                                 if (!String.IsNullOrWhiteSpace(entry.Reason))
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <small>");


            
            #line 113 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                                      Write(entry.Reason);

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n");


            
            #line 114 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </h4>\r\n                        </div>\r\n\r\n");


            
            #line 118 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                         if (JobHistoryRenderer.Exists(entry.StateName))
                        {
                            var rendered = Html.RenderHistory(entry.StateName, entry.Data);
                            if (rendered != null)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <div class=\"job-history-body\">\r\n                 " +
"                   ");


            
            #line 124 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                               Write(rendered);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </div>\r\n");


            
            #line 126 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                            }
                        }
                        else
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <div class=\"job-history-body\">\r\n                     " +
"           <dl class=\"dl-horizontal\">\r\n");


            
            #line 132 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                                     foreach (var item in entry.Data)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <dt>");


            
            #line 134 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                                       Write(item.Key);

            
            #line default
            #line hidden
WriteLiteral(":</dt>\r\n");



WriteLiteral("                                        <dd>");


            
            #line 135 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                                       Write(item.Value);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n");


            
            #line 136 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </dl>\r\n                            </div>\r\n");


            
            #line 139 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n");


            
            #line 141 "..\..\Dashboard\Pages\JobDetailsPage.cshtml"

                        index++;
                }
            }
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>");


        }
    }
}
#pragma warning restore 1591

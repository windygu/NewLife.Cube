﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    
    #line 2 "..\..\Areas\Admin\Views\Index\Main.cshtml"
    using System.Collections;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    
    #line 1 "..\..\Areas\Admin\Views\Index\Main.cshtml"
    using System.Diagnostics;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    using System.Net;
    
    #line 3 "..\..\Areas\Admin\Views\Index\Main.cshtml"
    using System.Reflection;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\Admin\Views\Index\Main.cshtml"
    using System.Runtime;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\Admin\Views\Index\Main.cshtml"
    using System.Runtime.Versioning;
    
    #line default
    #line hidden
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    
    #line 6 "..\..\Areas\Admin\Views\Index\Main.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Areas\Admin\Views\Index\Main.cshtml"
    using NewLife.Cube;
    
    #line default
    #line hidden
    using NewLife.Reflection;
    
    #line 8 "..\..\Areas\Admin\Views\Index\Main.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Index/Main.cshtml")]
    public partial class _Areas_Admin_Views_Index_Main_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_Index_Main_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 9 "..\..\Areas\Admin\Views\Index\Main.cshtml"
  
    Layout = NewLife.Cube.Setting.Current.Layout;

    ViewBag.Title = "服务器信息";

    var asm = Assembly.GetExecutingAssembly();
    var att = asm.GetCustomAttribute<TargetFrameworkAttribute>();
    var ver = att.FrameworkDisplayName ?? att.FrameworkName;
    var req = HttpContext.Current.Request;
    var httpContext = req.RequestContext.HttpContext;

    var mi = MachineInfo.Current ?? new MachineInfo();

    // GC设置
    //var gc = "IsServerGC={0},LatencyMode={1}".F(GCSettings.IsServerGC, GCSettings.LatencyMode);

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"table-responsive\"");

WriteLiteral(">\r\n    <table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\r\n        <thead>\r\n            <tr>\r\n                <th");

WriteLiteral(" colspan=\"4\"");

WriteLiteral(">\r\n                    服务器信息\r\n                </th>\r\n            </tr>\r\n        <" +
"/thead>\r\n        <tbody>\r\n            <tr>\r\n                <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    应用系统：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 40 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(HttpRuntime.AppDomainAppVirtualPath);

            
            #line default
            #line hidden
WriteLiteral("&nbsp;\r\n");

            
            #line 41 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 41 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                     if (this.Has((PermissionFlags)16))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1347), Tuple.Create("\"", 1376)
            
            #line 43 "..\..\Areas\Admin\Views\Index\Main.cshtml"
, Tuple.Create(Tuple.Create("", 1354), Tuple.Create<System.Object, System.Int32>(Url.Action("Restart")
            
            #line default
            #line hidden
, 1354), false)
);

WriteLiteral(" onclick=\"return confirm(\'仅重启ASP.Net应用程序域，而不是操作系统！\\n确认重启？\')\"");

WriteLiteral(">重启应用系统</a>\r\n");

            
            #line 44 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    &nbsp;&nbsp;&nbsp;&nbsp;");

            
            #line 45 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                       Write(req.GetRawUrl());

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    目录：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 51 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(HttpRuntime.AppDomainAppPath);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td" +
"");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    域名地址：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" title=\"SERVER_NAME\"");

WriteLiteral(">");

            
            #line 59 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                         Write(Request.ServerVariables["SERVER_NAME"]);

            
            #line default
            #line hidden
WriteLiteral("</span>，\r\n                    <span");

WriteLiteral(" title=\"LOCAl_ADDR\"");

WriteLiteral(">");

            
            #line 60 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                        Write(Request.ServerVariables["LOCAl_ADDR"]);

            
            #line default
            #line hidden
WriteLiteral(":");

            
            #line 60 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                                                               Write(Request.ServerVariables["Server_Port"]);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    &nbsp;<span");

WriteLiteral(" title=\"REMOTE_HOST\"");

WriteLiteral(">[");

            
            #line 61 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                                Write(Request.ServerVariables["REMOTE_HOST"]);

            
            #line default
            #line hidden
WriteLiteral("]</span>\r\n                    &nbsp;<span");

WriteLiteral(" title=\"真实\"");

WriteLiteral(">[");

            
            #line 62 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                       Write(httpContext.GetUserHost());

            
            #line default
            #line hidden
WriteLiteral("]</span>\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2340), Tuple.Create("\"", 2376)
            
            #line 63 "..\..\Areas\Admin\Views\Index\Main.cshtml"
, Tuple.Create(Tuple.Create("", 2347), Tuple.Create<System.Object, System.Int32>(Url.Action("Main/ServerVar")
            
            #line default
            #line hidden
, 2347), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" title=\"点击打开服务器变量列表\"");

WriteLiteral(">服务器变量列表</a>\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    计算机用户：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteAttribute("title", Tuple.Create(" title=\"", 2569), Tuple.Create("\"", 2585)
            
            #line 68 "..\..\Areas\Admin\Views\Index\Main.cshtml"
, Tuple.Create(Tuple.Create("", 2577), Tuple.Create<System.Object, System.Int32>(mi.UUID
            
            #line default
            #line hidden
, 2577), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 69 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(mi.Product);

            
            #line default
            #line hidden
WriteLiteral("，\r\n");

WriteLiteral("                    ");

            
            #line 70 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(Environment.UserName);

            
            #line default
            #line hidden
WriteLiteral("/");

            
            #line 70 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                     Write(Environment.MachineName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td" +
"");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    应用程序域：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 78 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(AppDomain.CurrentDomain.FriendlyName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2954), Tuple.Create("\"", 2989)
            
            #line 79 "..\..\Areas\Admin\Views\Index\Main.cshtml"
, Tuple.Create(Tuple.Create("", 2961), Tuple.Create<System.Object, System.Int32>(Url.Action("Main/Assembly")
            
            #line default
            #line hidden
, 2961), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" title=\"点击打开进程程序集列表\"");

WriteLiteral(">程序集列表</a>\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    .Net 版本：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 85 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(Environment.Version);

            
            #line default
            #line hidden
WriteLiteral(" &nbsp;");

            
            #line 85 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                          Write(ver);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td" +
"");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    操作系统：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteAttribute("title", Tuple.Create(" title=\"", 3416), Tuple.Create("\"", 3432)
            
            #line 92 "..\..\Areas\Admin\Views\Index\Main.cshtml"
, Tuple.Create(Tuple.Create("", 3424), Tuple.Create<System.Object, System.Int32>(mi.Guid
            
            #line default
            #line hidden
, 3424), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 93 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(mi.OSName);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 93 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                          Write(mi.OSVersion);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    Web服务器：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 99 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(ViewBag.WebServerName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td" +
"");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    处理器：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteAttribute("title", Tuple.Create(" title=\"", 3849), Tuple.Create("\"", 3866)
            
            #line 106 "..\..\Areas\Admin\Views\Index\Main.cshtml"
, Tuple.Create(Tuple.Create("", 3857), Tuple.Create<System.Object, System.Int32>(mi.CpuID
            
            #line default
            #line hidden
, 3857), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 107 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(mi.Processor);

            
            #line default
            #line hidden
WriteLiteral("，\r\n");

WriteLiteral("                    ");

            
            #line 108 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(Environment.ProcessorCount);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    核心，");

            
            #line 109 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                  Write(mi.CpuRate.ToString("p0"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 110 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 110 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                     if (mi.Temperature > 0)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <span>，");

            
            #line 112 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                          Write(mi.Temperature);

            
            #line default
            #line hidden
WriteLiteral(" ℃</span>\r\n");

            
            #line 113 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n                <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    时间：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(" title=\"这里使用了服务器默认的时间格式！后面是开机时间。\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 119 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(DateTimeOffset.Now);

            
            #line default
            #line hidden
WriteLiteral("，开机");

            
            #line 119 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                      Write(new TimeSpan(0, 0, 0, 0, Environment.TickCount));

            
            #line default
            #line hidden
WriteLiteral("，");

            
            #line 119 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                                                                        Write(mi.Temperature);

            
            #line default
            #line hidden
WriteLiteral(" ℃\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n");

            
            #line 123 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                
            
            #line default
            #line hidden
            
            #line 123 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   var process = Process.GetCurrentProcess();
            
            #line default
            #line hidden
WriteLiteral("\r\n                <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    内存：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n                    物理：");

            
            #line 128 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   Write((mi.AvailableMemory / 1024 / 1024).ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("M / ");

            
            #line 128 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                                                           Write((mi.Memory / 1024 / 1024).ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("M，\r\n                    工作/提交: ");

            
            #line 129 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                       Write((process.WorkingSet64 / 1024 / 1024).ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("M/");

            
            #line 129 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                                                               Write((process.PrivateMemorySize64 / 1024 / 1024).ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("M\r\n                    <br />\r\n                    GC: ");

            
            #line 131 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                    Write((GC.GetTotalMemory(false) / 1024 / 1024).ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("M，\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5094), Tuple.Create("\"", 5135)
            
            #line 132 "..\..\Areas\Admin\Views\Index\Main.cshtml"
, Tuple.Create(Tuple.Create("", 5101), Tuple.Create<System.Object, System.Int32>(Url.Action("Main/ProcessModules")
            
            #line default
            #line hidden
, 5101), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" title=\"点击打开进程模块列表\"");

WriteLiteral(">模块列表</a>\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5204), Tuple.Create("\"", 5236)
            
            #line 133 "..\..\Areas\Admin\Views\Index\Main.cshtml"
, Tuple.Create(Tuple.Create("", 5211), Tuple.Create<System.Object, System.Int32>(Url.Action("MemoryFree")
            
            #line default
            #line hidden
, 5211), false)
);

WriteLiteral(" title=\"点击释放进程内存\"");

WriteLiteral(">释放内存</a>\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    进程时间：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 139 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(process.TotalProcessorTime.TotalSeconds.ToString("N2"));

            
            #line default
            #line hidden
WriteLiteral("秒 启动于 ");

            
            #line 139 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                                                            Write(process.StartTime.ToFullString());

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td" +
"");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    Session：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 147 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(Session.Contents.Count);

            
            #line default
            #line hidden
WriteLiteral(" 个，");

            
            #line 147 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                         Write(Session.Timeout);

            
            #line default
            #line hidden
WriteLiteral(" 分钟，SessionID：");

            
            #line 147 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                                                       Write(Session.Contents.SessionID);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5836), Tuple.Create("\"", 5870)
            
            #line 148 "..\..\Areas\Admin\Views\Index\Main.cshtml"
, Tuple.Create(Tuple.Create("", 5843), Tuple.Create<System.Object, System.Int32>(Url.Action("Main/Session")
            
            #line default
            #line hidden
, 5843), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" title=\"点击打开Session列表\"");

WriteLiteral(">Session列表</a>\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    Cache：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 154 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(Cache.Count);

            
            #line default
            #line hidden
WriteLiteral(" 个，可用：");

            
            #line 154 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                  Write((Cache.EffectivePrivateBytesLimit / 1024).ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("KB\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 6193), Tuple.Create("\"", 6225)
            
            #line 155 "..\..\Areas\Admin\Views\Index\Main.cshtml"
, Tuple.Create(Tuple.Create("", 6200), Tuple.Create<System.Object, System.Int32>(Url.Action("Main/Cache")
            
            #line default
            #line hidden
, 6200), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" title=\"点击打开Cache列表\"");

WriteLiteral(">Cache列表</a>\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    </t" +
"able>\r\n    <table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(@">
        <thead>
            <tr>
                <th>名称</th>
                <th>标题</th>
                <th>文件版本</th>
                <th>内部版本</th>
                <th>编译时间</th>
                <th>描述</th>
            </tr>
        </thead>
        <tbody>
");

            
            #line 172 "..\..\Areas\Admin\Views\Index\Main.cshtml"
            
            
            #line default
            #line hidden
            
            #line 172 "..\..\Areas\Admin\Views\Index\Main.cshtml"
             foreach (AssemblyX item in ViewBag.MyAsms)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td>");

            
            #line 175 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td>");

            
            #line 176 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   Write(item.Title);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td>");

            
            #line 177 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   Write(item.FileVersion);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td>");

            
            #line 178 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   Write(item.Version);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td>");

            
            #line 179 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                    Write(item.Compile.Year <= 2000 ? "" : item.Compile.ToFullString());

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td>");

            
            #line 180 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   Write(item.Description);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                </tr>\r\n");

            
            #line 182 "..\..\Areas\Admin\Views\Index\Main.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");

        }
    }
}
#pragma warning restore 1591

#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a08576ca2fec78efc0df7c9932f906fa5ea39b5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Purchase.Pages_FytAdmin_Purchase_Index), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Purchase/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Purchase/Index.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Purchase.Pages_FytAdmin_Purchase_Index), @"{type?}")]
namespace FytSoa.Web.Pages.FytAdmin.Purchase
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{type?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a08576ca2fec78efc0df7c9932f906fa5ea39b5d", @"/Pages/FytAdmin/Purchase/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Purchase_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Index.cshtml"
  
    ViewData["Title"] = "采购管理";
    Layout = AdminLayout.Pjax(HttpContext);

#line default
#line hidden
            BeginContext(156, 1129, true);
            WriteLiteral(@"<div id=""container"">
    <div class=""list-wall"">
        <div class=""layui-form list-search"">
            <div class=""layui-inline"">
                <input class=""layui-input"" id=""key"" autocomplete=""off"" placeholder=""请输入关键字查询"">
            </div>
            采购日期：
            <div class=""layui-inline lay-time-icon"">
                <input class=""layui-input"" id=""times"" autocomplete=""off"" placeholder=""时间区间""><i class=""layui-icon layui-icon-date""></i>
            </div>
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolSearch""><i class=""layui-icon layui-icon-search""></i> 搜索</button>
        </div>
        <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
    </div>
    <script type=""text/html"" id=""toolbar"">
        <div class=""layui-btn-container"">
            <button type=""button"" class=""layui-btn layui-btn-sm"" lay-event=""toolAdd""><i class=""layui-icon""></i> 新增</button>
            <button type=""button"" class=""layui-btn layui-btn-sm"" lay-event=""tool");
            WriteLiteral("Del\"><i class=\"layui-icon\"></i> 删除</button>\r\n            <button style=\"margin-left:40px;\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1285, "\"", 1359, 3);
            WriteAttributeValue("", 1293, "layui-btn", 1293, 9, true);
            WriteAttributeValue(" ", 1302, "layui-btn-sm", 1303, 13, true);
#line 25 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Index.cshtml"
WriteAttributeValue("", 1315, Model.Type==1 ? "" :" layui-btn-disabled", 1315, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1360, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1363, 33, false);
#line 25 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Index.cshtml"
                                                                                                                                   Write(Model.Type == 1 ? "" : "disabled");

#line default
#line hidden
            EndContext();
            BeginContext(1397, 113, true);
            WriteLiteral(" lay-event=\"toolStatus\"><i class=\"layui-icon layui-icon-cart\"></i> 入库</button>\r\n            <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1510, "\"", 1584, 3);
            WriteAttributeValue("", 1518, "layui-btn", 1518, 9, true);
            WriteAttributeValue(" ", 1527, "layui-btn-sm", 1528, 13, true);
#line 26 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Index.cshtml"
WriteAttributeValue("", 1540, Model.Type==2 ? "" :" layui-btn-disabled", 1540, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1585, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1588, 33, false);
#line 26 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Index.cshtml"
                                                                                                         Write(Model.Type == 2 ? "" : "disabled");

#line default
#line hidden
            EndContext();
            BeginContext(1622, 112, true);
            WriteLiteral(" lay-event=\"toolStatus\"><i class=\"layui-icon layui-icon-rmb\"></i> 付款</button>\r\n            <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1734, "\"", 1808, 3);
            WriteAttributeValue("", 1742, "layui-btn", 1742, 9, true);
            WriteAttributeValue(" ", 1751, "layui-btn-sm", 1752, 13, true);
#line 27 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Index.cshtml"
WriteAttributeValue("", 1764, Model.Type==3 ? "" :" layui-btn-disabled", 1764, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1809, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1812, 33, false);
#line 27 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Index.cshtml"
                                                                                                         Write(Model.Type == 3 ? "" : "disabled");

#line default
#line hidden
            EndContext();
            BeginContext(1846, 917, true);
            WriteLiteral(@" lay-event=""toolStatus""><i class=""layui-icon layui-icon-file-b""></i> 到票</button>
        </div>
    </script>
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['table', 'layer', 'jquery', 'common', 'form', 'laydate'],
            function () {
                var table = layui.table,
                    layer = layui.layer,
                    $ = layui.jquery,
                    os = layui.common,
                    form = layui.form
                ,laydate = layui.laydate;
                form.render('select');
                laydate.render({
                    elem: '#times'
                    , theme: '#393D49'
                    , range: true
                });
                table.render({
                    toolbar: '#toolbar',
                    elem: '#tablist',
                    url: '/api/purchase/purchaselist?types=");
            EndContext();
            BeginContext(2764, 10, false);
#line 50 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\Index.cshtml"
                                                      Write(Model.Type);

#line default
#line hidden
            EndContext();
            BeginContext(2774, 5282, true);
            WriteLiteral(@"',
                    cols: [
                        [
                            { type: 'checkbox', fixed: 'left' },
                            { field: 'number',width:200, title: '采购单号', sort: true, fixed: 'left' },
                            { field: 'status', title: '入库状态' },
                            { field: 'supplier', title: '供应商', sort: true },
                            { field: 'addDate', title: '采购日期', sort: true },
                            { field: 'money', title: '订单总金额', sort: true },
                            { field: 'deliverDate', title: '交付日期', sort: true },
                            { field: 'deliverCity', title: '交付地点', sort: true },
                            { width: 100, title: '操作', templet: '#tool' }
                        ]
                    ],
                    page: { limits: [10, 20, 50, 100, 500, 1000, 5000, 10000], groups: 8 },
                    id: 'tables'
                });

                var guid = '', active = {
               ");
            WriteLiteral(@"     reload: function () {
                        table.reload('tables',
                            {
                                page: {
                                    curr: 1
                                },
                                where: {
                                    key: $(""#key"").val(),
                                    guid: $(""#branks"").val()
                                }
                            });
                    },
                    toolStatus: function () {
                        var checkStatus = table.checkStatus('tables')
                            , data = checkStatus.data;
                        if (data.length === 0) {
                            os.error(""请选择要变更的采购单~"");
                            return;
                        }
                        var str = '';
                        $.each(data, function (i, item) {
                            str += item.guid + "","";
                        });
                  ");
            WriteLiteral(@"      var loadindex = layer.load(1, {
                            shade: [0.1, '#000']
                        });
                        os.ajax('api/purchase/modifystatus/', { parm: str }, function (res) {
                            layer.close(loadindex);
                            if (res.statusCode === 200) {
                                active.reload();
                                os.success('变更成功！');
                            } else {
                                os.error(res.message);
                            }
                        });
                    },
                    toolSearch: function () {
                        active.reload();
                    },
                    toolAdd: function () {
                        os.Open('添加采购单', '/fytadmin/purchase/modify', '1200px', '700px', function () {
                            active.reload();
                        });
                    },
                    toolDel: function () {
             ");
            WriteLiteral(@"           var checkStatus = table.checkStatus('tables')
                            , data = checkStatus.data;
                        if (data.length === 0) {
                            os.error(""请选择要删除的项目~"");
                            return;
                        }
                        var str = '';
                        $.each(data, function (i, item) {
                            str += item.guid + "","";
                        });
                        layer.confirm('确定要执行批量删除吗？', function (index) {
                            layer.close(index);
                            var loadindex = layer.load(1, {
                                shade: [0.1, '#000']
                            });
                            os.ajax('api/goods/delbarcode/', { parm: str }, function (res) {
                                layer.close(loadindex);
                                if (res.statusCode === 200) {
                                    active.reload();
                         ");
            WriteLiteral(@"           os.success('删除成功！');
                                } else {
                                    os.error(res.message);
                                }
                            });
                        });

                    }
                };
                table.on('toolbar(tool)', function (obj) {
                    active[obj.event] ? active[obj.event].call(this) : '';
                });
                $('.list-search .layui-btn').on('click', function () {
                    var type = $(this).data('type');
                    active[type] ? active[type].call(this) : '';
                });
                //监听工具条
                table.on('tool(tool)', function (obj) {
                    var data = obj.data;
                    os.Open('修改采购单', '/fytadmin/purchase/modify?guid='+data.guid, '1200px', '700px', function () {
                        active.reload();
                    });
                });
            });
    </script>
    <script type=");
            WriteLiteral("\"text/html\" id=\"tool\">\r\n        <a class=\"layui-btn layui-btn-primary layui-btn-xs\" lay-event=\"edit\"><i class=\"layui-icon\"></i> 修改</a>\r\n    </script>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Purchase.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Purchase.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Purchase.IndexModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Purchase.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

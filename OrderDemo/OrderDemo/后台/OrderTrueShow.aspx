<%@ Page Title="" Language="C#" MasterPageFile="~/后台/ShowInfo.Master" AutoEventWireup="true" CodeBehind="OrderTrueShow.aspx.cs" Inherits="OrderDemo.后台.OrderTrueShow" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .td1 {
            width: 200px;
            height: 50px;
            text-align: right;
            background: #ffe4c4;
        }

        .td2 {
            width: 600px;
            height: 50px;
            text-align: left;
            background: white;
        }

        .tablea {
            width: 900px;
            height: auto;
        }

        .td3 {
            width: 200px;
            height: 40px;
            text-align: center;
            background: #ffe4c4;
        }
         .td4 {
            width: 200px;
            height: 40px;
            text-align: center;
            background: white;
        }
        #div1 {
            width: 900px;
            height: 40px;
            border-top: 1px #dee2e6 solid;
            background: #F6F5F3;
            margin-top: 0.5px;
            text-align: right;
        }
    </style>
    <div id="top1">
       <a href="OrderTrue.aspx">←返回上一层</a>
        <div>收货人信息</div>
        <table>
            <tr>
                <td class="td1">收货人:</td>
                <td class="td2">
                    &nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td class="td1">手机号码:</td>
                <td class="td2">
                    &nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td class="td1">收货地址:</td>
                <td class="td2">
                    &nbsp;&nbsp;<asp:Label ID="Label3" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
        <div>订单详细信息</div>
        <table class="tablea">
            <tr>
                <td class="td3">序号</td>
                <td class="td3">商品名称</td>
                <td class="td3">图片</td>
                <td class="td3">单价</td>
                <td class="td3">数量</td>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td class="td4"><%# Eval("OrderID") %></td>
                        <td class="td4"><%# Eval("FoodName") %></td>
                        <td class="td4">
                            <img style="width: 100px; height: 50px;" src="../img/img1.jpg" /></td>
                        <td class="td4"><%# Eval("UnitPrice") %></td>
                        <td class="td4"><%# Eval("Quatity") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
        <div id="div1">总价:￥<asp:Label ID="Label4" runat="server" ForeColor="Red" CssClass="lbl"></asp:Label></div>
    </div>
</asp:Content>

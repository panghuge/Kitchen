<%@ Page Title="" Language="C#" MasterPageFile="~/后台/ShowInfo.Master" AutoEventWireup="true" CodeBehind="FoodShow.aspx.cs" Inherits="OrderDemo.后台.FoodShow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 142px;
        }
        .auto-style2 {
            width: 142px;
            height: 31px;
        }
        .auto-style3 {
            height: 31px;
        }
    </style>
    <link href="../css/bootstrap.css" rel="stylesheet" />
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table class="table">
            <tr><td><a href="CaiPin.aspx">←返回上一层</a></td></tr>
            <tr>
                <td class="auto-style1">菜品名称:</td>
                <td>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">菜品类型:</td>
                <td>
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
            </tr>
               <tr>
                <td class="auto-style1">菜品单价:</td>
                <td>
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                   </td>
            </tr>
               <tr>
                <td class="auto-style1">菜品图片:</td>
                <td>
                    <asp:Image ID="Image1" runat="server" Height="84px" Width="134px" />
                   </td>
            </tr>
               <tr>
                <td class="auto-style1">订购次数:</td>
                <td>
                    <asp:Label ID="Label5" runat="server"></asp:Label>
                   </td>
            </tr>
               <tr>
                <td class="auto-style2">上市时间:</td>
                <td class="auto-style3">
                    <asp:Label ID="Label6" runat="server"></asp:Label>
                   </td>
            </tr>
                <tr>
                <td class="auto-style1">菜品备注:</td>
                <td>
                    <asp:Label ID="Label7" runat="server"></asp:Label>
                    </td>
            </tr>
        </table>

    </div>
</asp:Content>

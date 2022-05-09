<%@ Page Title="" Language="C#" MasterPageFile="~/后台/ShowInfo.Master" AutoEventWireup="true" CodeBehind="UserShow.aspx.cs" Inherits="OrderDemo.后台.UserShow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../css/bootstrap.css" rel="stylesheet" />
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <table class="table">
        <tr><td><a href="UserInfo.aspx">←返回上一层</a></td></tr>
            <tr>
                <td class="auto-style1">用户名:</td>
                <td>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">用户类型:</td>
                <td>
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
            </tr>
               <tr>
                <td class="auto-style1">真实姓名:</td>
                <td>
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                   </td>
            </tr>
               <tr>
                <td class="auto-style1">性别:</td>
                <td>
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                   </td>
            </tr>
               <tr>
                <td class="auto-style1">联系方式:</td>
                <td>
                    <asp:Label ID="Label5" runat="server"></asp:Label>
                   </td>
            </tr>
               <tr>
                <td class="auto-style2">详细地址:</td>
                <td class="auto-style3">
                    <asp:Label ID="Label6" runat="server"></asp:Label>
                   </td>
            </tr>
        </table>
</asp:Content>

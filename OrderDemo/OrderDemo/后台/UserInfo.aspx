<%@ Page Title="" Language="C#" MasterPageFile="~/后台/ShowInfo.Master" AutoEventWireup="true" CodeBehind="UserInfo.aspx.cs" Inherits="OrderDemo.后台.UserInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <link href="../css/bootstrap.css" rel="stylesheet" />
    <asp:Label ID="Label1" runat="server" Text="用户类型:"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" Height="25px" Width="133px" DataTextField="UserTypeName" DataValueField="UserTypeID">
</asp:DropDownList>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OrderingDBConnectionString7 %>" SelectCommand="SELECT * FROM [UserType]"></asp:SqlDataSource>
    <asp:Button ID="Button1" runat="server" Text="查看" Height="29px" OnClick="Button1_Click" Width="92px" />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table" AllowPaging="True" DataKeyNames="UserID" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDeleting="GridView1_RowDeleting" PageSize="5">
    <Columns>
        <asp:BoundField DataField="UserID" HeaderText="序号" />
        <asp:BoundField DataField="UserName" HeaderText="用户名" />
        <asp:BoundField DataField="UserTypeName" HeaderText="用户类型" />
        <asp:BoundField DataField="RealName" HeaderText="真是姓名" />
        <asp:BoundField DataField="Sex" HeaderText="性别" />
        <asp:TemplateField HeaderText="操作">
            <ItemTemplate>
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/del.jpg" OnClick="ImageButton1_Click"/>
                <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/detail.jpg" OnClick="ImageButton2_Click"/>
                <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/img/edit.jpg" OnClick="ImageButton3_Click"/>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
</asp:Content>

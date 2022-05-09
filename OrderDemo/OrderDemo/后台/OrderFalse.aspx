<%@ Page Title="" Language="C#" MasterPageFile="~/后台/ShowInfo.Master" AutoEventWireup="true" CodeBehind="OrderFalse.aspx.cs" Inherits="OrderDemo.后台.OrderFalse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <link href="../css/bootstrap.css" rel="stylesheet" />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="序号" />
            <asp:BoundField DataField="RealName" HeaderText="客户姓名" />
            <asp:BoundField DataField="DateCreate" HeaderText="下单时间" />
            <asp:BoundField DataField="Totle" HeaderText="订单总额" />
            <asp:TemplateField HeaderText="订单状态">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text="未付款"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="操作">
                <ItemTemplate>
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/detail.jpg" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>

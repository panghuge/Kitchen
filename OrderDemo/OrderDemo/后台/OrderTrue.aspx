<%@ Page Title="" Language="C#" MasterPageFile="~/后台/ShowInfo.Master" AutoEventWireup="true" CodeBehind="OrderTrue.aspx.cs" Inherits="OrderDemo.后台.OrderTrue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../css/bootstrap.css" rel="stylesheet" />
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="5">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="序号" />
            <asp:BoundField DataField="RealName" HeaderText="客户姓名" />
            <asp:BoundField DataField="DateCreate" HeaderText="下单时间" />
            <asp:BoundField DataField="Totle" HeaderText="订单总额" />
            <asp:TemplateField HeaderText="订单状态">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text="已付款"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="操作">
                <ItemTemplate>
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/detail.jpg" OnClick="ImageButton1_Click"/>
                    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/accept.jpg" OnClick="ImageButton2_Click"/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>

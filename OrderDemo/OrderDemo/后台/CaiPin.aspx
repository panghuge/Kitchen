<%@ Page Title="" Language="C#" MasterPageFile="~/后台/ShowInfo.Master" AutoEventWireup="true" CodeBehind="CaiPin.aspx.cs" Inherits="OrderDemo.后台.CaiPin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../css/bootstrap.css" rel="stylesheet" />
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <asp:Label ID="Label1" runat="server" Text="菜品类型:"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="FoodTypeName" DataValueField="FoodTypeID" Height="25px" Width="182px"></asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OrderingDBConnectionString3 %>" SelectCommand="SELECT * FROM [FoodType]"></asp:SqlDataSource>
<asp:Button ID="Button1" runat="server" Height="28px" OnClick="Button1_Click" Text="查询" Width="86px" />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True" CssClass="table" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="5" DataKeyNames="FoodID" Width="780px" OnRowEditing="GridView1_RowEditing" OnRowCancelingEdit="GridView1_RowCancelingEdit">
    <Columns>
        <asp:BoundField HeaderText="序号" DataField="FoodID" />
        <asp:BoundField HeaderText="菜品名称" DataField="FoodName" />
        <asp:BoundField HeaderText="菜品类型" DataField="FoodTypeName" />
        <asp:BoundField HeaderText="菜品价格" DataField="Price" />
        <asp:BoundField HeaderText="订购次数" DataField="SalesVolume" />
        <asp:BoundField HeaderText="上市时间" DataField="AddDate" />
        <asp:TemplateField HeaderText="操作">
            <ItemTemplate>
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/del.jpg" OnClick="ImageButton1_Click"/>
                <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/detail.jpg" OnClick="ImageButton2_Click"/>
                <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/img/edit.jpg" OnClick="ImageButton3_Click" CommandName="Updatess" OnRowUpdating="GridVIew_RowUpdating"/>
            </ItemTemplate>
        </asp:TemplateField>      
    </Columns>
</asp:GridView>
</asp:Content>

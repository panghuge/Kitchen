<%@ Page Title="" Language="C#" MasterPageFile="~/后台/ShowInfo.Master" AutoEventWireup="true" CodeBehind="FoodADD.aspx.cs" Inherits="OrderDemo.后台.FoodADD" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 429px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <link href="../css/bootstrap.css" rel="stylesheet" />
    <div class="auto-style1">
        <table class="table">
            <tr>
                <td>
                    <asp:Label runat="server" Text="菜品名称:"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="请输入菜品名称" ForeColor="Red"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="菜品类型:" ID="label1"></asp:Label></td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="30px" Width="150px" DataSourceID="SqlDataSource1" DataTextField="FoodTypeName" DataValueField="FoodTypeID">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OrderingDBConnectionString6 %>" SelectCommand="SELECT * FROM [FoodType]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="单价:" ID="label2"></asp:Label></td>
                <td>
                    <asp:TextBox runat="server" ID="textbox2" Height="26px" TextMode="Number"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="textbox2" ErrorMessage="请输入菜品价格" ForeColor="Red"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="图片:" ID="label3"></asp:Label></td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                    &nbsp;&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="FileUpload1" ErrorMessage="请上传菜品图片" ForeColor="Red"></asp:RequiredFieldValidator>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Text="上传" Width="53px" OnClick="Button1_Click" />
                    <br />
                    <asp:Image ID="Image1" runat="server" Height="111px" Width="181px" /></td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="备注:" ID="label4"></asp:Label></td>
                <td>
                    <asp:TextBox runat="server" ID="textbox4" Height="66px" TextMode="MultiLine"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Height="29px" Text="保存" Width="65px" OnClick="Button2_Click" /></td>
                <td>
                    <asp:Label ID="Label5" runat="server"></asp:Label>
                    <br />
                </td>
            </tr>
        </table>
    </div>

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/前台/IndexInfo.Master" AutoEventWireup="true" CodeBehind="zhuce.aspx.cs" Inherits="OrderDemo.前台.zhuce" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <style>
        #loginUser {
          display:none;
        }
          .div1 {
           padding-left:30px;
           background-color:aliceblue;
          }
          .div2 {
           float:right;
           margin-top:-350px;
           margin-right:50px;
          }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="all">
        <h2>注册新用户</h2>
        <div class="div1">
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="用户名"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="22px" Width="156px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="用户名不能为空" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Label ID="Label2" runat="server" Text="密码"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"  TextMode="Password" Height="22px" Width="156px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="密码不能为空" ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
             &nbsp;&nbsp;&nbsp;
             <asp:Label ID="Label3" runat="server" Text="确认密码"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"  TextMode="Password"  Height="22px" Width="156px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="请再次确认密码" ControlToValidate="TextBox3" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="两次密码不一致" ForeColor="Red"></asp:CompareValidator>
            <br />
            <br />
             &nbsp;&nbsp;&nbsp;
             <asp:Label ID="Label4" runat="server" Text="真实姓名"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server"  Height="22px" Width="156px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="请输入您的姓名" ControlToValidate="TextBox4" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Label ID="Label5" runat="server" Text="性别"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="sex" Checked="true" />男
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="sex"/>女
             
            <br />
            <br />
             &nbsp;&nbsp;&nbsp;
             <asp:Label ID="Label6" runat="server" Text="联系方式"></asp:Label>
            &nbsp;
            <asp:TextBox ID="TextBox6" runat="server"  Height="22px" Width="156px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="请输入联系方式" ControlToValidate="TextBox6" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
             &nbsp;&nbsp;&nbsp;
             <asp:Label ID="Label7" runat="server" Text="详细地址"></asp:Label>
            &nbsp;
            <asp:TextBox ID="TextBox7" runat="server"  Height="22px" Width="156px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="请输入地址" ControlToValidate="TextBox7" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="保存" Height="33px" Width="93px" OnClick="Button1_Click"/>
            <br />
            <br /><br />
        </div>
        <div class="div2">
            <img src="../img/person.bmp" />
        </div>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/前台/IndexInfo.Master" AutoEventWireup="true" CodeBehind="OrderOK.aspx.cs" Inherits="OrderDemo.前台.OrderOK" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        #div2 {
            width: 970px;
            height: 500px;
            background: white;
            margin: 15px auto;
        }

        #div1 {
            margin: 0 auto;
            width: 1000px;
            height: 600px;
            background: Bisque;
        }

        #div3 {
            width: 160px;
            height: 30px;
            font-size: 25px;
            font-weight: bold;
            text-align: right;
        }

        #div4 {
            width: 300px;
            height: 300px;
            background: #ffefbc;
            margin: 30px auto;
            text-align: center;
            line-height: 90px;
            font-weight: bold;
        }

        .btn-btn {
            width: 100px;
            height: 40px;
            border-radius: 5px;
            border-style: none;
            background: black;
            color: white;
            font-weight: bold;
            margin-top:70px;
        }
    </style>
    <div id="div1">
        <div id="div3">模拟支付平台</div>
        <div id="div2">
            <h4>应支付:￥<asp:Label ID="Label1" runat="server" Text=""></asp:Label></h4>
            <span></span>
            <div id="div4">
                单击确认支付,则模拟支付成功!
                <div>
                    <asp:Button ID="Button1" runat="server" Text="确认支付" CssClass="btn-btn" OnClick="Button1_Click" />
                </div>
            </div>
        </div>
    </div>


</asp:Content>

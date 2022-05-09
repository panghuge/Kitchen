<%@ Page Title="" Language="C#" MasterPageFile="~/前台/IndexInfo.Master" AutoEventWireup="true" CodeBehind="OrderXqShow.aspx.cs" Inherits="OrderDemo.前台.OrderXqShow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <style type="text/css">
        .auto-style1 {
            height: 33px;
        }

        .btn-btn {
            width: 100px;
            height: 40px;
            border-radius: 5px;
            border-style: none;
            background: black;
            color: white;
            font-weight: bold;
        }

        #tables {
            width: 900px;
            height: auto;
            margin: 0 auto;
        }

        #tablea {
            width: 900px;
            height: auto;
            margin: 0 auto;
        }

        #div1 {
            width: 900px;
            height: 40px;
            border-top: 1px #dee2e6 solid;
            background: #F6F5F3;
            margin-top: 0.5px;
            margin-left: 26px;
            text-align: right;
        }

        .lbl {
            font-weight: bold;
        }

        #div2 {
            width: 900px;
            height: 40px;
            border-top: 1px #dee2e6 solid;
            background: #F6F5F3;
            margin-top: 0.5px;
            margin-left: 26px;
            text-align: right;
        }
    </style>
    <link href="../css/bootstrap.css" rel="stylesheet" />
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <div style="width: 1000px; height: auto; background: #ffe4c4">
        <div style="width: 250px; height: 40px; font-size: 25px; font-weight: bold; margin-left: 30px;">复核并确认订单信息</div>
        <div style="width: 950px; height: auto; background: white; margin: 10px auto;">
            <table class="table" id="tables">
                <tr>
                    <th>收件人信息</th>
                </tr>
                <tr>
                    <td class="td_right" style="background: Bisque; text-align: right;">下单客户：</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" BorderColor="#FFDD00" ReadOnly="True"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style1" style="background: Bisque; text-align: right;">联系方式：</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBox2" runat="server" BorderColor="#FFDD00" ReadOnly="True"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="td_right" style="background: Bisque; text-align: right;">收货地址：</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" BorderColor="#FFDD00" ReadOnly="True" Width="461px"></asp:TextBox></td>
                </tr>
            </table>
            <table class="table" id="tablea">
                <tr>
                    <th>订单详细信息</th>
                </tr>
                <tr>
                    <td style="background: Bisque; text-align: center;">序号</td>
                    <td style="background: Bisque; text-align: center;">商品名称</td>
                    <td style="background: Bisque; text-align: center;">图片</td>
                    <td style="background: Bisque; text-align: center;">单价</td>
                    <td style="background: Bisque; text-align: center;">数量</td>
                </tr>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td style="background: #F6F5F3; text-align: center;"><%# Eval("FoodID") %></td>
                            <td style="background: #F6F5F3; text-align: center;"><%# Eval("FoodName") %></td>
                            <td style="background: #F6F5F3; text-align: center;">
                                <img style="width: 200px; height: 50px;" src="../img/img1.jpg" /></td>
                            <td style="background: #F6F5F3; text-align: center;"><%# Eval("Price") %></td>
                            <td style="background: #F6F5F3; text-align: center;"><%# Eval("Count") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
            <div id="div1">总价:￥<asp:Label ID="Label1" runat="server" ForeColor="Red" CssClass="lbl"></asp:Label></div>
        </div>
    </div>
</asp:Content>

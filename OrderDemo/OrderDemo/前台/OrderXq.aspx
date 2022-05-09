<%@ Page Title="" Language="C#" MasterPageFile="~/前台/IndexInfo.Master" AutoEventWireup="true" CodeBehind="OrderXq.aspx.cs" Inherits="OrderDemo.前台.OrderXq" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link href="../css/bootstrap.css" rel="stylesheet" />
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <style>
        #div1 {
            margin: 0 auto;
            width: 1000px;
            height: 600px;
            background: Bisque;
        }

        #div2 {
            width: 970px;
            height: 500px;
            background: white;
            margin: 15px auto;
        }

        #div3 {
            width: 160px;
            height: 30px;
            font-size: 25px;
            font-weight: bold;
            margin-left: 10px;
        }

        #div4 {
            width: 400px;
            height: 30px;
            margin-left: 35px;
            font-weight: bold;
        }

        .td2 {
            width: 240px;
            height: 50px;
            text-align: center;
            background: #ffe4c4;
        }

        .td1 {
            width: 50px;
            height: 50px;
            text-align: center;
            background: #ffe4c4;
        }

        .td3 {
            width: 200px;
            height: 50px;
            text-align: center;
            background: #ffe4c4;
        }

        .tablea {
            width: 900px;
            height: auto;
            margin: 0 auto;
        }

        </style>
    <div id="div1">
        <div id="div3">订单信息</div>
        <div id="div2">
            <div id="div4">
                <asp:Label ID="Label1" runat="server" Text="订单状态:"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" Height="24px" Width="170px">
                    <asp:ListItem>派送中</asp:ListItem>
                    <asp:ListItem Value="已完成"></asp:ListItem>
                    <asp:ListItem Value="未付款"></asp:ListItem>
                    <asp:ListItem Value="已付款"></asp:ListItem>
                    <asp:ListItem Value="已接单"></asp:ListItem>
                </asp:DropDownList>
                <asp:Button ID="Button4" runat="server" Text="查询" Width="71px"  OnClick="Button4_Click"/>
            </div>
            <table class="tablea">
                <tr>
                    <td class="td1">序号</td>
                    <td class="td2">下单时间</td>
                    <td class="td3">订单总额</td>
                    <td class="td3">订单状态</td>
                    <td class="td3">操作</td>
                </tr>
                <asp:Repeater ID="Repeater1" runat="server" OnItemCreated="Repeater1_ItemCreated">
                    <ItemTemplate>
                        <asp:HiddenField ID="HiddenField1" runat="server" Value='<%# Eval("id") %>' />
                        <tr>
                            <td style="background: #F6F5F3; text-align: center; width: 50px; height: 50px;"><%# Eval("id") %></td>
                            <td style="background: #F6F5F3; text-align: center; width: 240px; height: 50px;"><%# Eval("DateCreate") %></td>
                            <td style="background: #F6F5F3; text-align: center; width: 200px; height: 50px;"><%# Eval("Totle") %></td>
                            <td style="background: #F6F5F3; text-align: center; width: 200px; height: 50px;"><%# Eval("OrderState") %></td>
                            <td style="background: #F6F5F3; text-align: center; width: 200px; height: 50px;">
                                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/detail.jpg" OnClick="ImageButton1_Click" />
                                <asp:ImageButton ID="images" runat="server" ImageUrl="~/img/cancel.jpg" OnClick="images_Click" CommandName="Delete"/>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
<%--            <div style="width:900px;height:60px;margin-left:30px;">
                <asp:Button ID="Button2" runat="server" Text="上一页" OnClick="Button2_Click" CssClass="btn" />
                <asp:TextBox ID="TextBox1" runat="server" style="display:none"></asp:TextBox>
                <asp:TextBox ID="TextBox2" runat="server" style="display:none"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Text="当前第："></asp:Label>
                <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                <asp:Label ID="Label4" runat="server" Text="页"></asp:Label>
                <asp:Button ID="Button3" runat="server" Text="下一页" OnClick="Button3_Click" CssClass="btn" />
            </div>--%>
        </div>
    </div>
</asp:Content>

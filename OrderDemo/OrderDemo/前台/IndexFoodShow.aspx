<%@ Page Title="" Language="C#" MasterPageFile="~/前台/IndexInfo.Master" AutoEventWireup="true" CodeBehind="IndexFoodShow.aspx.cs" Inherits="OrderDemo.前台.IndexFoodShow" EnableEventValidation="false"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../css/bootstrap.css" rel="stylesheet" />
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <style>
        #loginUser {
            display: none;
        }

        .btn1 {
            border-radius: 5px;
            font-size: 15px;
            font-weight: bold;
            border-style: none;
        }

        .btn {
            border-radius: 5px;
            font-size: 10px;
            font-weight: bold;
            border-style: none;
        }

        .btn3 {
            border-radius: 5px;
            font-size: 15px;
            font-weight: bold;
            border-style: none;
        }
    </style>
    
    <div style="float: left; height: 58px; width: 998px;">
        <asp:Button runat="server" Text="主食" Height="44px" Width="150px" BackColor="#5A362D" BorderColor="#5A362D" CssClass="btn1" OnClick="Unnamed_Click5" />
        &nbsp;
        <asp:Button runat="server" Text="热菜系列" Height="43px" Width="150px" BackColor="#9D262C" BorderColor="#9D262C" CssClass="btn1" OnClick="Unnamed_Click" />
        &nbsp;
        <asp:Button runat="server" Text="经典凉拌" Height="43px" Width="150px" BackColor="#C7810D" BorderColor="#C7810D" CssClass="btn1" OnClick="Unnamed_Click1" />
        &nbsp;
        <asp:Button runat="server" Text="海鲜盛宴" Height="43px" Width="150px" BackColor="#680035" BorderColor="#680035" CssClass="btn1" OnClick="Unnamed_Click2" />
        &nbsp;
        <asp:Button runat="server" Text="传统烧烤" Height="43px" Width="150px" BackColor="#275A87" BorderColor="#275A87" CssClass="btn1" OnClick="Unnamed_Click3" />
        &nbsp;
        <asp:Button runat="server" Text="餐后甜点" Height="43px" Width="150px" BackColor="#679E3D" BorderColor="#679E3D" CssClass="btn1" OnClick="Unnamed_Click4" />
    </div>
    <br />

    <div>
        <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound" OnItemCommand="Repeater1_ItemCommand">
            <ItemTemplate>
                <div style="width: 80%">
                    <dl style="float: left; margin-left: 10px; margin-top: 10px;background: #5A362D; color: white">
                        <dt>
                          <%--  <img src="../img/img1.jpg" style="width: 200px; height: 120px;" /></dt>--%>
                            <img src="<%# Eval("PicUrl")%>" style="width: 200px; height: 120px;" /></dt>
                        <dd><%# Eval("FoodName")%></dd>
                        <dd>￥<%# Eval("Price") %></dd>
                        <dd>
                            <asp:Button ID="Button1" runat="server"  ToolTip='<%# Eval("FoodID") %>' Text="加入订单" Width="80px" Height="25px" CssClass="btn" BackColor="White" OnClick="Button1_Click1" /></dd>
                    </dl>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
        <table class="table" style="width: auto; height: auto; float: right; position:absolute; right:300px;top:150px; border: 1px solid red; background: #FFDD00">
            <tr style="border: 1px solid red">
                <th>我的购物车</th>
            </tr>
            <asp:Repeater ID="rpgwc" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("FoodName") %><br />
                            ¥ <%# Eval("Price") %></td>
                        <td>
                            <asp:Button ID="btnjian" runat="server" Text=" - " ToolTip='<%# Eval("FoodID") %>' OnClick="btnjian_Click" />
                            <%# Eval("Count") %>
                            <asp:Button ID="btnjia" runat="server" Text=" + " ToolTip='<%# Eval("FoodID") %>' OnClick="btnjia_Click" /></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            <tr>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="立即下单" Width="80px" Height="30px" BackColor="Red" ForeColor="White" CssClass="btn3" OnClick="Button2_Click" />&nbsp;&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 总计:<asp:Label ID="Label1" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
    </div>
   
</asp:Content>

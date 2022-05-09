<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="OrderDemo.后台.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../css/manager.css" rel="stylesheet" />
    <style>
        #title {
            height: 42px;
            width: 300px;
            line-height: 42px;
            text-align: center;
            color: white;
            background-image: url('../img/login_title.png');
            background-repeat: repeat-x;
            margin-left: 300px;
        }

        .huyong {
            margin-left: 100px;
        }

        .row_input {
            margin-top: 30px;
            line-height: 50px;
            font-size: 12px;
            font-family: "微软雅黑";
        }

        #c1 {
            margin-left: 180px;
        }

        .btn {
            height: 40px;
            width: 80px;
            background-image: url('../img/login_btn.png');
            margin-left: 200px;
        }

        #zhong {
            margin-left: 200px;
        }
    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
            <div id="top">
                邻家小厨后台管理系统
            </div>
            <div id="login">
                <div id="title">
                    邻家小厨后台管理系统登录
                </div>
                <div id="zhong">
                    <asp:Label ID="Label1" runat="server" Text="用户名：" CssClass="huyong"></asp:Label>
                    <asp:TextBox ID="txtUser" runat="server" CssClass="row_input" Height="30px" Width="207px"></asp:TextBox>
                    <br />

                    &nbsp;<asp:Label ID="Label2" runat="server" Text="密码：" CssClass="huyong"></asp:Label>
                    &nbsp;
                    <asp:TextBox ID="TextBox2"  TextMode="Password" runat="server" CssClass="row_input" Height="30px" Width="205px"></asp:TextBox>
                    <br />

                    <asp:Label ID="Label3" runat="server" Text="验证码：" CssClass="huyong"></asp:Label>
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="row_input" Height="30px" Width="112px"></asp:TextBox>

                    <a href="#" style="text-decoration: none" onclick="hh()">看不清</a>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="验证码必须输入" ControlToValidate="TextBox3" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <div id="div1">
                        <canvas id="c1" runat="server"></canvas>
                    </div>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/login_btn.png" OnClick="ImageButton1_Click" />
                </div>

            </div>
            <div id="bottom">
                版权所有：邻家小厨
            </div>
        </div>
    </form>
</body>
<script>
    function hh() {
        var div1 = document.getElementById("div1");//得到div
        var can = document.getElementsByTagName("canvas");//得到画布
        div1.removeChild(can[0]);//移出画布
        var d = document.createElement("canvas");//创建画布
        d.setAttribute("width", "100px");//宽度
        d.setAttribute("height", "40px");//高度
        d.setAttribute("id", "c1");//设置ID
        d.setAttribute("border", "red 1px solid");//加个边框
        div1.appendChild(d);//将创建好的画布赋值给div
        var v = ["1", "2", "3", "4", "5", "6", "7", "8", "9", "0",
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        ];
        var r = Math.floor(Math.random() * 255);
        var g = Math.floor(Math.random() * 255);
        var b = Math.floor(Math.random() * 255);
        var cc = document.getElementById("c1");//获取画布
        var content = cc.getContext("2d");//设置画笔
        //content.fillStyle = "blue"; //画布填充色
        //content.fillRect(0,0,cc.width,cc.height);
        var size = Math.floor(Math.random() * 10) + 20;//声明字体大小

        content.fillStyle = 'rgba(' + r + ',' + g + ',' + b + ')';//设置字体颜色
        //content.fillStyle(r,g,b);
        content.font = size + "px 微软雅黑";//声明字体大小
        //alert(size);
        var arrays = new Array();
        var x = new Array();
        var y = new Array();
        //绘制点
        for (var i = 0; i < 20; i++) {
            r = Math.floor(Math.random() * 255);
            g = Math.floor(Math.random() * 255);
            b = Math.floor(Math.random() * 255);
            var q = Math.floor(Math.random() * cc.width);//得到画布的宽度
            var w = Math.floor(Math.random() * cc.height);//得到画布的高度
            //0-100  x   0-40  y    80   20   81    21
            content.moveTo(q, w);//绘制点
            content.lineTo(q + 1, w + 1);//点结束的位置
            content.lineWidth = 1;//绘制线
            content.strokeStyle = 'rgba(' + r + ',' + g + ',' + b + ',0.9)';//设置绘制的颜色和不透明度
            content.stroke();//开始绘制点

        }
        //绘制中心的内容
        for (var i = 0; i < 4; i++) {
            r = Math.floor(Math.random() * 255);
            g = Math.floor(Math.random() * 255);
            b = Math.floor(Math.random() * 255);
            arrays[i] = v[Math.floor(Math.random() * v.length)];
            x[i] = i * 20 + 10;
            y[i] = Math.random() * 20 + 20;
            content.fillText(arrays[i], x[i], y[i]);
        }
        //绘制线
        for (var i = 0; i < 10; i++) {
            r = Math.floor(Math.random() * 255);
            g = Math.floor(Math.random() * 255);
            b = Math.floor(Math.random() * 255);
            // x 0-100   y 0-40//起始  x50   y 20   x30   y50
            content.moveTo(Math.floor(Math.random() * cc.width), Math.floor(Math.random() * cc.height));
            content.lineTo(Math.floor(Math.random() * cc.width), Math.floor(Math.random() * cc.height));
            content.lineWidth = "0.8";
            content.strokeStyle = 'rgba(' + r + ',' + g + ',' + b + ')';
            content.stroke();
        }
    }
    hh();
</script>
</html>

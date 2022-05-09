<%@ Page Title="" Language="C#" MasterPageFile="~/前台/IndexInfo.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="OrderDemo.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/index.css" rel="stylesheet" />
    <script src="../js/jquery-1.11.0.min.js"></script>
    <style>
        #loginUser {
          display:none;
        }
    </style> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   
  <script>
        var index1 = 0;
        var index2 = 0;
        var time;
        //自动播放
        function ss() {
            time = window.setInterval(
                function () {
                    show();
                }, 2000);
        }
        //停止播放
        function aa() {
            window.clearInterval(time);
        }
        function show(index) {
            index2 = index1;
            if (arguments.length > 0) {
                index1 = index;
            }
            else {
                index1 = index1 < 3 ? ++index1 : 0;
            }
            var left = (-1) * 1000 * index1;
            $("#imgarea").stop(true).animate({ "left": left }, 1000);
            $("#imgID li").eq(index2).removeClass("current");
            $("#imgID li").eq(index1).addClass("current");
        }
        $(function () {
            $("#main").hover(
                function () { aa(); },
                function () { ss(); }
            );
            $("#imgID li").each(function (index) {
                $(this).mouseover(function () {
                    show(index);
                });
            });
            ss();
        });
    </script>
    <div id="banner">
        <div id="main">
            <ul id="imgarea">
                <li><a href="#">
                    <img src="../img/img1.jpg" /></a></li>
                <li><a href="#">
                    <img src="../img/img2.jpg" /></a></li>
                <li><a href="#">
                    <img src="../img/img3.jpg" /></a></li>
                <li><a href="#">
                    <img src="../img/img4.jpg" /></a></li>
            </ul>
            <ul id="imgID">
                <li class="current"></li>
                <li></li>
                <li></li>
                <li></li>
            </ul>
        </div>
    </div>
    <div id="bottom">
        <div>
            <img src="../img/home1.jpg" alt="" />
        </div>
        <div>
            <img src="../img/home2.jpg" alt="" />
        </div>
        <div>
            <img src="../img/home3.jpg" alt="" />
        </div>
        <div>
            <img src="../img/home4.jpg" alt="" />
        </div>
    </div>
</asp:Content>

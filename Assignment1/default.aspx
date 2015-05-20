<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Assignment1._default" %>
<%@ Register Src="~/Game.ascx" TagName="game" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <!--Game 1-->
        <asp:Label ID="lblGame1" runat="server" Text="Game 1" Font-Bold="True" Font-Size="Large"></asp:Label>
        <uc1:game ID="game1" runat="server" />
    </div>
    <div>
        <!--Game 2-->
        <asp:Label ID="lblGame2" runat="server" Text="Game 2" Font-Bold="True" Font-Size="Large"></asp:Label>
        <uc1:game ID="game2" runat="server" />
    </div>
    <div>
        <!--Game 3-->
        <asp:Label ID="lblGame3" runat="server" Text="Game 3" Font-Bold="True" Font-Size="Large"></asp:Label>
        <uc1:game ID="game3" runat="server" />
    </div>
    <div>
        <!--Game 4-->
        <asp:Label ID="lblGame4" runat="server" Text="Game 4" Font-Bold="True" Font-Size="Large"></asp:Label>
        <uc1:game ID="game4" runat="server" />
    </div>
</asp:Content>

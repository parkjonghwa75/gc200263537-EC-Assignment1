﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Game.ascx.cs" Inherits="Assignment1.Game" %>
<asp:Panel ID="pnlGame" runat="server" BorderColor="Red" BackColor="#FFFF99" BorderStyle="Solid" BorderWidth="1px">
    
    <div>
        <!-- A radio button list for Result.  Choices are Win / Lose. -->
        <asp:Label ID="lblResult" runat="server" Text="Result: "></asp:Label>
        <asp:RadioButtonList ID="rdlResult" runat="server">
            <asp:ListItem Value="Win" Text="Win"></asp:ListItem>
            <asp:ListItem Value="Lose" Text="Lose"></asp:ListItem>
        </asp:RadioButtonList>
    </div>
    <div>
        <!-- An input for Points Scored  -->
        <asp:Label ID="lblPointsScored" runat="server" Text="Points Scored: " ></asp:Label>
        <asp:TextBox ID="txtPointsScored" runat="server" TextMode="Number"></asp:TextBox>
    </div>
    <div>
        <!-- An input for Points Allowed -->
        <asp:Label ID="lblPointsAllowed" runat="server" Text="Points Allowed: "></asp:Label>
        <asp:TextBox ID="txtPointsAllowed" runat="server" TextMode="Number"></asp:TextBox>
    </div>
    <div>
        <!-- An input for Spectators (the # of people watched the game)-->
        <asp:Label ID="lblSpectators" runat="server" Text="# of Spectators: "></asp:Label>
        <asp:TextBox ID="txtSpectators" runat="server" TextMode="Number"></asp:TextBox>
    </div>
</asp:Panel>
<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Assignment1._default" %>
<%@ Register Src="~/Game.ascx" TagName="game" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Display summary information below-->
    <div>
        <asp:Label ID="lblSummaryTitle" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" Font-Italic="True"></asp:Label>
    </div>
    <div>
        <asp:Label ID="lblNumberOfWins" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
    </div>
    <div>
        <asp:Label ID="lblNumberOfLosts" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
    </div>
    <div>
        <asp:Label ID="lblWinningRate" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
    </div>
    <div>
        <asp:Label ID="lblTotalPointsScored" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
    </div>
    <div>
        <asp:Label ID="lblTotalPointsAllowed" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
    </div>
    <div>
        <asp:Label ID="lblPointsDifferential" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
    </div>
    <div>
        <asp:Label ID="lblTotalSpectators" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
    </div>
    <div>
        <asp:Label ID="lblAverageSpectators" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
    </div>
    <!-- End of summary display -->

    <div>
        <asp:Table ID="Table1" runat="server" CellPadding="2" CellSpacing="2">
            <asp:TableRow>
                <asp:TableCell Width="220">
                    <!--Game 1-->
                    <asp:Label ID="lblGame1" runat="server" Text="Game 1" Font-Bold="True" Font-Size="Large"></asp:Label>
                    <uc1:game ID="game1" runat="server" />
                </asp:TableCell>
                <asp:TableCell Width="220">
                    <!--Game 2-->
                    <asp:Label ID="lblGame2" runat="server" Text="Game 2" Font-Bold="True" Font-Size="Large"></asp:Label>
                    <uc1:game ID="game2" runat="server" />
                </asp:TableCell>
                <asp:TableCell Width="220">
                    <!--Game 3-->
                    <asp:Label ID="lblGame3" runat="server" Text="Game 3" Font-Bold="True" Font-Size="Large"></asp:Label>
                    <uc1:game ID="game3" runat="server" />
                </asp:TableCell>
                <asp:TableCell Width="220">
                    <!--Game 4-->
                    <asp:Label ID="lblGame4" runat="server" Text="Game 4" Font-Bold="True" Font-Size="Large"></asp:Label>
                    <uc1:game ID="game4" runat="server" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>

    </div>

    <!--Submit button goes here-->
    <div>
        <asp:Button ID="submit" runat="server" Text="Calculate" OnClick="submit_Click" CssClass="btn active" />
    </div>



</asp:Content>

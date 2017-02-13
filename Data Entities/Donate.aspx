<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Donate.aspx.cs" Inherits="Donate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Donate</title>
     <link rel="stylesheet" href="stylesheet.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Donate</h1>
        <p>How much would you like to donate?</p>
        <p>
            $<asp:TextBox ID="DonationTextBox" runat="server" TextMode="Number"></asp:TextBox></p>
        <asp:Button ID="DonateButton" runat="server" Text="Donate" OnClick="DonateButton_Click" />
        <p><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></p>
    </div>
    </form>
</body>
</html>

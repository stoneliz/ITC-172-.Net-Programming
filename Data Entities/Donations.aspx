<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Donations.aspx.cs" Inherits="Donations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link rel="stylesheet" href="stylesheet.css"/>
    <title>Donations</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Your Donations </h1>
        <p>Thank you for your donation!</p>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>

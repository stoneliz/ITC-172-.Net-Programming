<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calendar of Events</title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Bank Holidays</h1>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged">
            <DayHeaderStyle Font-Bold="True" />
            <NextPrevStyle Font-Bold="True" />
            <OtherMonthDayStyle Font-Bold="True" />
            <SelectedDayStyle BackColor="Orange" />
            <TitleStyle BackColor="Navy" Font-Bold="True" />
            <WeekendDayStyle BackColor="LightCyan" />
        </asp:Calendar>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        
    </div>
    </form>
</body>
</html>

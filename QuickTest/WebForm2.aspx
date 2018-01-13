<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="QuickTest.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label Text="Nom" runat="server" />
            <asp:TextBox ID="NameTextBox" runat="server" />
            <br />
            <br />
            <asp:Button ID="ClickButton" OnClick="ClickButton_Click" Text="Click Me!!!" runat="server" />
            <br />
            <br />
            <asp:Label ID="NameLabel" Text="Bonjour" runat="server" />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="PasswordValidations.FirstPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body> 
    <form id="form1" runat="server">
        <div>
            <label>Login</label>
            <asp:TextBox ID="myLogin" runat="server" />
            <br />
            <label>Password</label>
            <asp:TextBox ID="myPassword" runat="server" />
            <br />
            <br />
            <asp:Button runat="server" OnClick="Submit_Click"/>
        </div>
    </form>
</body>
</html>

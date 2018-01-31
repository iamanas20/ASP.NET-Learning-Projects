<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="LoginAndPasswordValidation.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nom D'utilisateur:
            <br />
            <asp:TextBox ID="LoginTextBox" runat="server" />
            <br /><br /><br />
            Mot de passe: 
            <br />
            <asp:TextBox ID="PasswordTextBox" runat="server" />
            <br /><br /><br />
            <asp:Button ID="SubmitButton" Text="Valider" runat="server" OnClick="SubmitButton_Click" />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonCheckForm.aspx.cs" Inherits="ASP_02_Homework1.PersonCheckForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Write the text from the image
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" Height="213px" Width="204px" />
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Check Person"/>
    
    </div>
    </form>
</body>
</html>

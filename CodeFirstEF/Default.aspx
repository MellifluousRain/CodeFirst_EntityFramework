<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CodeFirstEF.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="txtDefault"/>  
            <asp:Button Text="OK" runat="server" ID="OK" OnClick="OK_Click"/>
        </div>
    </form>
</body>
</html>

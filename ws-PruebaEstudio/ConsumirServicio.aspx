<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsumirServicio.aspx.cs" Inherits="ws_PruebaEstudio.ConsumirServicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelUsuario" runat="server" Text="Usuario"></asp:Label>
            <asp:TextBox ID="TextBoxUsuario" runat="server" style="margin-left: 33px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelContrasenna" runat="server" Text="Contrasenna"></asp:Label>
            <asp:TextBox ID="TexboBoxContrasenna" runat="server" style="margin-left: 8px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="ButtonVerificar" runat="server" style="margin-left: 120px" Text="Verificar" OnClick="ButtonVerificar_Click" />
            <br />
            <asp:Label ID="LabelResultado" runat="server" Text=""></asp:Label>
            
        </div>
    </form>
</body>
</html>

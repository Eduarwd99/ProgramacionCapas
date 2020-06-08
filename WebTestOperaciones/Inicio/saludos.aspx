<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="saludos.aspx.cs" Inherits="WebTestOperaciones.Inicio.saludos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            Ingrese su nombre&nbsp;
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblSaludos" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="El resultado del sumando del vector es:"></asp:Label>
&nbsp;<asp:TextBox ID="txtR" runat="server" Width="83px"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Mostrar" Width="124px" />
        </div>
    </form>
</body>
</html>

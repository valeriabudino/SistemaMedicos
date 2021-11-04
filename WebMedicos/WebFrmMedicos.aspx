<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFrmMedicos.aspx.cs" Inherits="WebMedicos.WebFrmMedicos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             
            <asp:Label ID="lblId" runat="server" Text="Id"></asp:Label>
            <asp:TextBox ID="txtId" runat="server" Width="117px"></asp:TextBox>
            <br />
            <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server" Width="117px"></asp:TextBox>
            <br />
            <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label>
            <asp:TextBox ID="txtApellido" runat="server" Width="117px"></asp:TextBox>
            <br />
            <asp:Label ID="lblEspecialidades" runat="server" Text="Especialidad "></asp:Label>
            <asp:DropDownList ID="dropEspecialidades" runat="server" Height="17px" Width="127px"> </asp:DropDownList>
            <br />
            <asp:Label ID="lblMatricula" runat="server" Text="Matricula"></asp:Label>
            <asp:TextBox ID="txtMatricula" runat="server" Width="117px"></asp:TextBox>
            <br />
            <asp:Button ID="btnGuardar" runat="server" style="margin-top: 0px" Text="Guardar" OnClick="btnGuardar_Click" />
            <asp:Button ID="btnModificar" runat="server" style="margin-top: 0px" Text="Modificar" OnClick="btnModificar_Click" />
            <asp:Button ID="btnEliminar" runat="server" style="margin-top: 0px" Text="Eliminar" OnClick="btnEliminar_Click" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Traer por especialidad "></asp:Label>
            <asp:DropDownList ID="dropEspecialidad" runat="server" Height="17px" Width="127px" OnSelectedIndexChanged="dropEspecialidad_SelectedIndexChanged"> </asp:DropDownList>
            <asp:GridView ID="grid" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>

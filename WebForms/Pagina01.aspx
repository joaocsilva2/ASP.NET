<%@ Page Title="Pagina 01" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pagina01.aspx.cs" Inherits="WebForms.Pagina01" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Pagina 01</h3>
    <hr />
    <asp:Label ID="lblNome" runat="server"  Text="Insira seu Nome:"></asp:Label>
    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvNome" ControlToValidate="txtNome" runat="server" ErrorMessage="Nome é Obrigatório" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="lblSobreNome" runat="server"  Text="Insira seu SobreNome:"></asp:Label>
    <asp:TextBox ID="txtSobreNome" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblTelefone" runat="server"  Text="Insira seu Telefone:"></asp:Label>
    <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
    <br />
    <hr />
    <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
    <hr />
    <br />
    <asp:Label ID="lblResultado" Text="" runat="server" />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red"/>
</asp:Content>

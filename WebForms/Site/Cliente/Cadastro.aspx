<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="WebForms.Site.Cliente.Cadastro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Cliente</h3>
    <hr />
    <div class="form-group">
        <asp:Label Text="CPF" runat="server" />
        <asp:TextBox ID="txtCPF" runat="server" CssClass="form-control" MaxLength="11"/>
    </div>
    <div class="form-group">
        <asp:Label Text="Nome" runat="server" />
        <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" MaxLength="50"/>
    </div>
    <div class="form-group">
        <asp:Label Text="Telefone" runat="server" />
        <asp:TextBox ID="txtTelefone" runat="server" CssClass="form-control" MaxLength="20"/>
    </div>
    <div class="form-group">
        <asp:Label Text="Endereço" runat="server" />
        <asp:TextBox ID="txtEndereco" runat="server" CssClass="form-control" MaxLength="50"/>
    </div>
    <hr />
    <div class="form-group">
        <asp:Button ID="btnSalvar" Text="Salvar" runat="server" CssClass="btn btn-primary" OnClick="btnSalvar_Click" />
        <asp:Button ID="btnVoltar" Text="Voltar" runat="server" CssClass="btn btn-primary" OnClick="btnVoltar_Click"  />
        <br />
        <span id="msg" runat="server"></span>
    </div>
</asp:Content>

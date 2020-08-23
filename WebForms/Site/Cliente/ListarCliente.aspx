<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarCliente.aspx.cs" Inherits="WebForms.Site.Cliente.ListarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Lista de Clientes</h3>
    <hr />
    <div class="form-group">
        <asp:LinkButton ID="btnNovo" runat="server" CssClass="btn btn-primary" Text="Novo Cliente" OnClick="btnNovo_Click"></asp:LinkButton>
    </div>
    <hr />
    <div>
        <asp:GridView ID="gdvDados" runat="server" CssClass="table table-striped" AutoGenerateColumns="false" OnRowCommand="gdvDados_RowCommand" GridLines="None">
            <Columns >
                <asp:BoundField DataField="ID" HeaderText="ID"/>
                <asp:BoundField DataField="Nome" HeaderText="Nome"/>
                <asp:BoundField DataField="CPF" HeaderText="CPF"/>
                <asp:BoundField DataField="Telefone" HeaderText ="Telefone"/>
                <asp:BoundField DataField="Endereco" HeaderText="Endereço" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton runat="server" CssClass="btn btn-info" Text="Editar" CommandName="Editar" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "ID") %>' ></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton runat="server" CssClass="btn btn-danger" Text="Excluir" CommandName="Excluir" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "ID") %>' ></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

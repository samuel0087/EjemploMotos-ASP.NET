<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="formMoto.aspx.cs" Inherits="EjemploMotos.Formulario_web1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col">
            <div class="mb-3">
                <label for="txtId" class="form-label">Id</label>
                <asp:TextBox runat="server" ID="txtId" CssClass="form-control"/>
            </div>

            <div class="mb-3">
                <label for="txtMarca" class="form-label">Marca</label>
                <asp:DropDownList runat="server" ID="ddlMarcas" CssClass="form-select"></asp:DropDownList>
            </div>

            <div class="mb-3">
                <label for="txtModelo" class="form-label">Modelo</label>
                <asp:TextBox ID="txtModelo" CssClass="form-control" runat="server" />
            </div>

            <div class="mb-3">
                   <label for="txtDescripcion" class="form-label">Descripcion</label>
                   <asp:TextBox ID="txtDescripcion" CssClass="form-control" TextMode="MultiLine" runat="server" />
            </div>
            
            <div class="mb-3">
                <label for="ddlColores" class="form-label">Color</label>
                <asp:DropDownList runat="server" ID="ddlColores" CssClass="form-select"></asp:DropDownList>
            </div>

            <div class="mb-3">
                <label for="txtDescripcion" class="form-label">Descripcion</label>
                <asp:TextBox ID="TextBox1" CssClass="form-control" TextMode="MultiLine" runat="server" />
            </div>

<!--
        public string Color { get; set; }
        public string FechaFabricacion { get; set; }
        public bool Usado {  get; set; }
        public bool Importado { get; set; }
    }--%>
        </div>
    </div>

</asp:Content>

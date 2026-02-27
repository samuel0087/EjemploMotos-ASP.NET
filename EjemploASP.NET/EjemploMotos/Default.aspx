<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EjemploMotos._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>

        <div class="row">
            <div class="col"></div>
            <div class="col-6">
                <asp:GridView ID="dgvMotos" AutoGenerateColumns="false" CssClass="table table-dark table-striped " runat="server">
                    <Columns>
                        <asp:BoundField DataField="Marca" HeaderText="Marca" />
                        <asp:BoundField DataField="Modelo" HeaderText="Modelo" />
                        <asp:BoundField DataField="Color" HeaderText="Color" />
                        <asp:CheckBoxField DataField="Usado" HeaderText="Usado" />
                        <asp:CheckBoxField DataField="Importado" HeaderText="Importado" />
                    </Columns>
                </asp:GridView>

                <a href="formMoto" class="btn btn-primary">Agregar</a>
            </div>
            <div class="col"></div>
        </div>

    </main>

</asp:Content>

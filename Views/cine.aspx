<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Cinestar.Master" AutoEventWireup="true" CodeBehind="cine.aspx.cs" Inherits="webCinestar_WebForms_202620.Views.Cine" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <br /><h1>Nuestros Cines</h1><br />

    <asp:FormView ID="fvCine" runat="server">
        <ItemTemplate>
            <div class="contenido-cine">
                <div class="cine-info">
                    <h2><%# Eval("RazonSocial") %></h2>
                    <p><strong>Dirección:</strong> <%# Eval("Direccion") %></p>
                    <p><strong>Teléfonos:</strong> <%# Eval("Telefonos") %></p>
                    <p><%# Eval("Detalle") %></p>
                </div>
                <img src="../Contents/img/cine/<%# Eval("id") %>.1.jpg" width="227" height="170" /><br /><br />
            </div>
        </ItemTemplate>
    </asp:FormView>

    <div class="cine-tarifas">
        <h3>Tarifas</h3>
        <div class="tabla">
            <asp:Repeater ID="rptTarifas" runat="server">
                <ItemTemplate>
                    <div class="fila">
                        <div class="celda-titulo"><%# Eval("DiasSemana") %></div>
                        <div class="celda"><%# Eval("Precio") %></div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
    <br />

    <div class="cine-horarios">
        <h3>Películas y Horarios</h3>
        <div class="tabla">
            <asp:Repeater ID="rptHorarios" runat="server">
                <ItemTemplate>
                    <div class="fila">
                        <div class="celda-titulo"><%# Eval("Titulo") %></div>
                        <div class="celda"><%# Eval("Horarios") %></div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
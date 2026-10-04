<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Cinestar.Master" AutoEventWireup="true" CodeBehind="cines.aspx.cs" Inherits="webCinestar_WebForms_202620.Views.cines" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
  <br/><h1>Nuestros Cines</h1><br/>
  <asp:Repeater ID="rptCines" runat="server">
    <ItemTemplate>
      <div class="contenido-cine">
        <img src="../Contents/img/cine/<%#Eval("id") %>.1.jpg" width="227" height="170"/>
        <div class="datos-cine">
          <h4><%#Eval("RazonSocial") %></h4><br/>
          <span><%#Eval("Direccion") %> - <%#Eval("Detalle") %><br/><br/>Teléfono: <%#Eval("Telefonos") %></span>
        </div>
        <br/>
        <a href="cine.aspx?id=<%#Eval("id") %>">
          <img src="../Contents/img/varios/ico-info2.png" width="150" height="40"/>
        </a>
      </div>
    </ItemTemplate>
  </asp:Repeater>
  <div class="contenido-cine">
    <img src="../Contents/img/cine/1.1.jpg" width="227" height="170"/>
    <div class="datos-cine">
      <h4>Excelsior</h4><br/>
      <span>Jirón de la Unión 780 - Lima<br/><br/>Teléfono: 714-1865 anexo 865</span>
    </div>
    <br/>
    <a href="cine.aspx">
      <img src="../Contents/img/varios/ico-info2.png" width="150" height="40"/>
    </a>
  </div>
</asp:Content>


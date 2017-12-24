<%@ Page Title="" Language="C#" MasterPageFile="~/ServerDB.master" AutoEventWireup="true" CodeFile="Template.aspx.cs" Inherits="Template" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Image ID="Image1" runat="server" />
    <h1 id="ProductTitle" runat="server">Product-Name</h1><br /><br />
    <h2>Item Description</h2>
    <p id="description" runat="server"></p><br /><br />
    <asp:Label ID="Price" runat="server" Text="Price:"></asp:Label><br />
    <asp:Label ID="Quantity" runat="server" Text="Quantity:"></asp:Label><asp:TextBox ID="TextBox1" runat="server" MaxLength="2"></asp:TextBox><br />
    <asp:Label ID="Color" runat="server" Text="color:"></asp:Label>
    <asp:DropDownList ID="Color_Select" runat="server">
    </asp:DropDownList>
    
</asp:Content>


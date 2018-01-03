<%@ Page Title="" Language="C#" MasterPageFile="~/ServerDB.master" AutoEventWireup="true" CodeFile="ProfilePage.aspx.cs" Inherits="ProfilePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>profile page</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <asp:GridView ID="imgGV" runat="server"></asp:GridView>

        <asp:Label ID="UserNamelbl" runat="server" Text="Welcome"></asp:Label>
        <br />
        <asp:FileUpload ID="imgUpload" runat="server" />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/ServerDB.master" AutoEventWireup="true" CodeFile="AdminPage.aspx.cs" Inherits="AdminPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Admin Page</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <h1>All Users</h1><br />
        <asp:GridView ID="allUserGV" runat="server"></asp:GridView>
    </div>
    <br />
    <div>
        <h1>Add User</h1>
            <asp:TextBox ID="txtFirstName" runat="server" placeholder="First Name"></asp:TextBox>
    <br /><br />
    <asp:TextBox ID="txtLastName" runat="server" placeholder="Last Name"></asp:TextBox>
    <br /><br />
    <asp:TextBox ID="txtUserName" runat="server" placeholder="UserName"></asp:TextBox>
    <br /><br />
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox>
    <br /><br />
    <asp:TextBox ID="txtPasswordComfirm" runat="server" TextMode="Password" placeholder="Confirm Password"></asp:TextBox>
    <br /><br />
    <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" placeholder="Email"></asp:TextBox>
    <br /><br />
    <asp:Button ID="Button1" runat="server" Text="Send" OnClick="Button1_Click" />
    </div>
    <br />
    <div>
        <h1>Search for users</h1>
        <asp:TextBox ID="txtSearchByName" runat="server" placeholder="Enter Name"></asp:TextBox><asp:Button ID="btnSearch" runat="server" Text="search" OnClick="btnSearch_Click" />
        <br />
        <asp:TextBox ID="txtSearchByID" runat="server" placeholder="Enter Id"></asp:TextBox>
        <asp:GridView ID="searchGV" runat="server"></asp:GridView>
    </div>
    <br />
    <div>
        <h1>delete users</h1>
        <br />
        <asp:TextBox ID="txtById" runat="server" placeholder="Enter Id"></asp:TextBox>
        <asp:Button ID="btnSearchD" runat="server" Text="search" OnClick="btnSearchD_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="delete" OnClick="btnDelete_Click" OnClientClick="return confirm(`Are you sure?`)"/>
        <asp:GridView ID="deleteGV" runat="server"></asp:GridView>
    </div>
    
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AdminPage.aspx.cs" Inherits="AdminPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Admin Page</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script>
        function Confirm() {
            var confirm_value = document.createElement("INPUT");
            confirm_value.type = "hidden";
            confirm_value.name = "confirm_value";
            if (confirm("Are you sure you want to delete this User?")) {
                confirm_value.value = "Yes";
            } else {
                confirm_value.value = "No";
            }
            document.forms[0].appendChild(confirm_value);
        }

    </script>
    
    
    <div>
        <h1>display all users</h1>
        <asp:GridView ID="UsersGV" runat="server"></asp:GridView>
    </div>
    <br /><br />
    <div>
        <h1>search for user</h1>
        <asp:TextBox ID="txtByUser" runat="server" placeholder="Search by UserName"></asp:TextBox>
        <asp:TextBox ID="txtByID" runat="server" placeholder="Search by ID"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" Text="Button" />
        <asp:GridView ID="SearchGV" runat="server"></asp:GridView>
    </div>
    <br /><br />
    <div>
        <h1>Delete users</h1>
        <asp:TextBox ID="txtDeleteByUser" runat="server" placeholder="Search by UserName"></asp:TextBox>
        <asp:TextBox ID="txtDeleteByID" runat="server" placeholder="Search by ID"></asp:TextBox>
        <asp:Button UseSubmitBehavior="false" ID="btnDelete" runat="server" Text="Button" OnClientClick="Confirm()" OnClick="btnDelete_Click" />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
</asp:Content>


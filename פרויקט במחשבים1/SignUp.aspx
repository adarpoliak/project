<%@ Page Title="" Language="C#" MasterPageFile="~/ServerDB.master" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>Sign Up</title>
    <link rel="stylesheet" href="SignUp.css" />
    <script>
        function Validation() {
            document.getElementById("txtUserName").setCustomValidity("taken");
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="box2">
        <h2>Register</h2>
        <br />
        <div class="inputBox">
            <asp:TextBox ID="txtFirstName" required="" runat="server" AutoCompleteType="Disabled"  ></asp:TextBox>
            <asp:Label ID="UserNamelbl" runat="server" AssociatedControlID="txtFirstName" Text="Label">First Name</asp:Label>
        </div>

        <div class="inputBox">
            <asp:TextBox ID="txtLastName" runat="server" required="" AutoCompleteType="Disabled"  ></asp:TextBox>
            <asp:Label ID="Label1" runat="server" AssociatedControlID="txtLastName" Text="Label">Last Name</asp:Label>
        </div>
        
        <div class="inputBox">
            <asp:TextBox ID="txtUserName" runat="server" required="" AutoCompleteType="Disabled"  ></asp:TextBox>
            <asp:Label ID="Label2" runat="server" AssociatedControlID="txtUserName" Text="Label">UserName</asp:Label>
        </div>
        
        <div class="inputBox">    
            <asp:TextBox ID="txtPassword" runat="server" required="" TextMode="Password"  ></asp:TextBox>
            <asp:Label ID="Passwordlbl" runat="server" AssociatedControlID="txtPassword" Text="Label">Password</asp:Label>
        </div>
        
        <div class="inputBox">
            <asp:TextBox ID="txtPasswordComfirm" runat="server" required="" TextMode="Password"  ></asp:TextBox>
            <asp:Label ID="Label3" runat="server" AssociatedControlID="txtPasswordComfirm" Text="Label">Confirm Password</asp:Label>
        </div>
        
        <div class="inputBox">
            <asp:TextBox AutoCompleteType="Disabled" ID="txtEmail" required="" runat="server" TextMode="Email"  ></asp:TextBox>
            <asp:Label ID="Label4" runat="server" AssociatedControlID="txtEmail" Text="Label">Email</asp:Label>
        </div>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Button"  OnClick="Button2_Click" />
        <asp:Button ID="Button1" runat="server" Text="Send" OnClick="Button1_Click"  />
    </div>
</asp:Content>



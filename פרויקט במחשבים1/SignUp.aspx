<%@ Page Title="" Language="C#" MasterPageFile="~/ServerDB.master" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Sign Up</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:TextBox ID="txtFirstName" runat="server" AutoCompleteType="Disabled" placeholder="First Name"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstName" ErrorMessage="*" ForeColor="#FF3300" ToolTip="First name cannot be empty" ValidationGroup="group2"></asp:RequiredFieldValidator>
    <br /><br />
    <asp:TextBox ID="txtLastName" runat="server" AutoCompleteType="Disabled" placeholder="Last Name"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastName" ErrorMessage="*" ForeColor="#FF3300" ToolTip="Last name cannot be empty" ValidationGroup="group2"></asp:RequiredFieldValidator>
    <br /><br />
    <asp:TextBox ID="txtUserName" runat="server" AutoCompleteType="Disabled" placeholder="UserName"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ForeColor="#FF3300" ControlToValidate="txtUserName" ToolTip="UserName cannot be empty" ValidationGroup="group2"></asp:RequiredFieldValidator>
    <br /><br />
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPassword" ErrorMessage="*" ForeColor="#FF3300" ToolTip="Password cannot be empty" ValidationGroup="group2"></asp:RequiredFieldValidator>
    <br /><br />
    <asp:TextBox ID="txtPasswordComfirm" runat="server" TextMode="Password" placeholder="Confirm Password"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtPasswordComfirm" ErrorMessage="*" ForeColor="#FF3300" ToolTip="Password cannot be empty" ValidationGroup="group2"></asp:RequiredFieldValidator>
    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtPasswordComfirm" ErrorMessage="*" ToolTip="passwords don`t match" ForeColor="#FF3300" ValidationGroup="group2"></asp:CompareValidator>
    <br /><br />
    <asp:TextBox AutoCompleteType="Disabled" ID="txtEmail" runat="server" TextMode="Email" placeholder="Email"></asp:TextBox>
    <br /><br />
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ValidationGroup="group2" runat="server" ErrorMessage="*" ControlToValidate="txtEmail" EnableClientScript="False" ValidationExpression="^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$" ToolTip="Email not valid"></asp:RegularExpressionValidator>
    <asp:Button ID="Button1" runat="server" Text="Send" OnClick="Button1_Click" ValidationGroup="group2" />
</asp:Content>



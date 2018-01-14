<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="signup.aspx.cs" Inherits="signup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Sign In</h2>
            <div class="inputBox">
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                <asp:label runat="server" text="lblFirstName">UserName</asp:label>
            </div>
            <div class="inputBox">

            </div>
            <div class="inputBox">
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                <asp:label runat="server" text="lblPassword">Password</asp:label>
            </div>
    <div class="inputBox"></div>
    <div class="inputBox"></div>
    <div class="inputBox"></div>
            
</asp:Content>


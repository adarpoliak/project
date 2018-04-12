<%@ Page Title="" Language="C#" MasterPageFile="~/ServerDB.master" AutoEventWireup="true" CodeFile="ProfilePage.aspx.cs" Inherits="ProfilePage" EnableEventValidation="false"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>profile page</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <h1 id="HeadLine" runat="server"></h1>
        
        <div class="dropdown2">
        <asp:Button ID="btnChangePass" runat="server" Text="Change Password" CssClass="dropbtn2" UseSubmitBehavior="False" OnClientClick="toggleChangePass(); return false;" />
        <div id="ChangePassDiv" class="box3" >
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:TextBox ID="txtOldPass" runat="server" placeholder="Old Password" TextMode="Password"></asp:TextBox><br/>
                    <asp:TextBox ID="txtNewPass" runat="server" ToolTip="Password must match" TextMode="Password" placeholder="New Password"></asp:TextBox><br/>
                    <asp:TextBox ID="txtConfirmPass" runat="server" ToolTip="Password must match" TextMode="Password" placeholder="Conirm Password"></asp:TextBox><br />
                    <asp:Label ID="lblError" runat="server" Text="" CssClass="Errorlbl"></asp:Label><br />
                    <asp:Button ID="btnChangePassword" runat="server" Text="Submit" OnClick="btnChangePass_Click" AutoPostBack="False" CausesValidation="False" UseSubmitBehavior="False" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        </div>
        <br/>

        <script>
            /* When the user clicks on the button,toggle between hiding and showing the dropdown content */
            function toggleChangePass() {
                document.getElementById("ChangePassDiv").classList.toggle("show");
            }

        </script>
    </div>
</asp:Content>


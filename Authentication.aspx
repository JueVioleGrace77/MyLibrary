<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Authentication.aspx.cs" Inherits="Authentication" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
&nbsp;<asp:Label ID="lblUserAuthentication" runat="server" ForeColor="Blue"></asp:Label>
    </p>
    <p>
&nbsp;<asp:Button ID="btnLogIn" runat="server" OnClick="btnLogIn_Click" Text="Log In" />
&nbsp;<asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" Text="Log Out" />
&nbsp;<asp:Label ID="lblCheckLoggedUser" runat="server" ForeColor="Red"></asp:Label>
    </p>
</asp:Content>


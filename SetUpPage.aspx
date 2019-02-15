<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SetupPage.aspx.cs" Inherits="SetUpPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Setup Page</h1>
    <link id="lnkCSS" href="css/LibraryCollection.css" runat="server" rel="stylesheet" type="text/css" />
    <p>
        Please choose your prefered background scheme:
        &nbsp;&nbsp;
        <asp:Button ID="btnDarkTheme" runat="server" Text="Dark Theme" OnClick="Button1_Click" />
&nbsp;&nbsp;
        <asp:Button ID="btnLightTheme" runat="server" Text="Light Theme" OnClick="btnLightTheme_Click" />

    </p>
</asp:Content>


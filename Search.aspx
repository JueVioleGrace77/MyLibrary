<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Search book from you collection</h1>
    <p>
        Genre:<br  />
        <asp:DropDownList ID="genreDropDownList" runat="server" ></asp:DropDownList>
    </p>
    <p>
        Name Of A Friend Landed To:<br />
        <asp:DropDownList ID="friendLandedToDropDownList" runat="server"></asp:DropDownList>
    </p>
    <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="Button1_Click" />
    <asp:Label ID="recordLabel" runat="server" ForeColor="Red" ViewStateMode="Disabled"></asp:Label>
    <br />
    <br />
    <asp:GridView ID="grid" runat="server" ViewStateMode="Disabled"></asp:GridView>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BookDetailspage.aspx.cs" Inherits="BookDetailspage" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:67%">
        <tr>
            <th><h2 style="color:white">Book Details Page</h2></th>
        </tr>
    </table>
    <table style="width:35%">
        <tr>
            <td class="auto-style5">Book Title</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtBookTitle" runat="server"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td class="auto-style4">Author</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtAuthorName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">ISBN</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtIsbnNumber" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Genre</td>
            <td class="auto-style4">
        <asp:TextBox ID="txtGenre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Number Of Page</td>
            <td class="auto-style4">
        <asp:TextBox ID="txtNumberOfPage" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Name Of Friend</td>
            <td class="auto-style4">
        <asp:TextBox ID="txtNameToAFriendLanded" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Comment</td>
            <td class="auto-style4">
        <textarea id="AreaComment" cols="40" rows="4" runat="server" name="S1"></textarea></td>
        </tr>

    </table>
    
    <p>
        <asp:Button ID="btnEdit" runat="server" ForeColor="#0033CC" Text="Edit" OnClick="btnEdit_Click" />
&nbsp;<asp:Button ID="btnUpload" runat="server" ForeColor="#0033CC" Text="Upload" OnClick="btnUpload_Click" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
&nbsp;<asp:Button ID="btnDelete" runat="server" ForeColor="Red" Text="Delete" OnClick="btnDelete_Click" />

</asp:Content>


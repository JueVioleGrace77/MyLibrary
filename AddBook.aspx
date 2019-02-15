<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddBook.aspx.cs" Inherits="AddBook" %>

<%@ Register Src="~/WebUserControl.ascx" TagPrefix="uc1" TagName="WebUserControl" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Add book to your collection</h1>
    <uc1:WebUserControl runat="server" ID="book" />
    <p>
        Genre:<br />
        <asp:DropDownList ID="drpGenre" runat="server"></asp:DropDownList>
    </p>
    <p>
        Number of Page:<br />
        <asp:TextBox ID="txtNumberOfPage" runat="server"></asp:TextBox>
    </p>
    <p>
        Landed to a friend:<asp:CheckBox ID="chkLandedToAFriend" runat="server" 
            AutoPostback="True"
            Checked="False"
            OnCheckedChanged="landedToAFriend_CheckedChanged"  />
        <br />
    </p>
    <p>
        Name to a friend Landed<br />
        <asp:TextBox ID="txtNameToAFriendLanded" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
            ControlToValidate="txtNameToAFriendLanded"
            ForeColor="Red"
            Enabled="False"
            ErrorMessage="Friend name field is required"
            Display="Dynamic" ></asp:RequiredFieldValidator>
    </p>
    <p>
        Comment<br />
        <textarea id="AreaComment" cols="40" rows="4" runat="server"></textarea>
    <p>
        <asp:Button ID="save" runat="server" Text="Save" OnClick="save_Click" />
        &nbsp;
        &nbsp;
        &nbsp;
        &nbsp;
        &nbsp;
        &nbsp;
        &nbsp;<asp:Button ID="cancel" Text="Cancel" 
            CausesValidation="False" 
            OnClick="cancel_Click" 
            runat="server" /></p>
</asp:Content>


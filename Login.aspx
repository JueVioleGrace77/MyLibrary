<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:50%">        
        <tr>
            <th>Login Page</th>
        </tr>
    </table>
    <table style="width:50%;">
            <tr>
                <td>User Name</td>
                <td>
    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
    &nbsp;<asp:RequiredFieldValidator ID="reqUserName" runat="server"
        ControlToValidate="txtUserName"
        ErrorMessage="Please enter user name" 
        ForeColor="Red"
        Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td> 
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="reqPass" runat="server"
            ControlToValidate="txtPassword"
            ErrorMessage="Please enter password" 
            ForeColor="Red"
            Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Remmber me</td>
                <td><asp:CheckBox ID="chkPersist" runat="server" /></td>
            </tr>
            <tr>
                <td><asp:Button ID="btn_Login" runat="server" Text="Login" OnClick="btn_Login_Click" /></td>
                <td><asp:Button ID="btn_cancel" runat="server" Text="Cancel" OnClick="btn_cancel_Click" CausesValidation="False" /></td>
            </tr>
        </table>
    <p>
        <asp:Label ID="lblLoginChecker" runat="server" ForeColor="Red" ></asp:Label>
    </p>
</asp:Content>


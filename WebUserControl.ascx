<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WebUserControl.ascx.cs" Inherits="WebUserControl" %>
<p>
        Book Title:<br />
        <asp:TextBox ID="txtBookTitle" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
            ControlToValidate="txtBookTitle"
            ForeColor="Red"
            ErrorMessage="Book Title field is required"
            Display="Dynamic"></asp:RequiredFieldValidator>
    </p>
    <p>
        Author:<br />
        <asp:TextBox ID="txtAuthorName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
            ControlToValidate="txtAuthorName"
            ForeColor="Red"
            ErrorMessage="Author field is required"
            Display="Dynamic"></asp:RequiredFieldValidator>
    </p>
    <p>
        ISBN:<br />
        <asp:TextBox ID="txtIsbnNumber" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
            ControlToValidate="txtIsbnNumber"
            ForeColor="Red"
            ErrorMessage="ISBN field is required"
            Display="Dynamic"
            ></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" 
            ControlToValidate ="txtIsbnNumber"
            MinimumValue ="1000000000000"
            MaximumValue ="9999999999999"
            ForeColor="Red"
            Display="Dynamic"
            ErrorMessage="ISBN field must contain 13 numbers"></asp:RangeValidator>
    </p>
<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Book.aspx.cs" Inherits="Book" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1>User Book Collection</h1>
    <p>View book info:</p>
    <p>
        <asp:GridView ID="grid" runat="server" AutoGenerateColumns="False" OnRowCommand="gird_RowCommand">
            <Columns>
                <asp:BoundField DataField="BookId" HeaderText="Book ID" />
                <asp:BoundField DataField="BookTitle" HeaderText="Book Title" />
                <asp:BoundField DataField="Author" HeaderText="Author" />
                <asp:BoundField DataField="ISBN" HeaderText="ISBN" />
                <asp:CommandField ShowSelectButton="true" >
                <ControlStyle ForeColor="Blue" />
                </asp:CommandField>
            </Columns>
        </asp:GridView>
    </p>

<%--    <br />
    <p>
        <asp:DetailsView ID="bookDetails" runat="server" AutoGenerateRows="False"
            OnModeChanging="bookDetails_ModeChanging" OnItemDeleting="bookDetails_ItemDeleting" OnItemUpdating="bookDetails_ItemUpdating">
            <HeaderTemplate>
                Book Info
            </HeaderTemplate>
            <Fields>
                <asp:TemplateField HeaderText="Book ID">
                    <ItemTemplate>
                        <asp:Label ID="bookIDLabel" runat="server" Text='<%# Bind("BookID") %>'></asp:Label>
                    </ItemTemplate>
                    </asp:TemplateField>
                <asp:TemplateField HeaderText="Genre">
                    <ItemTemplate>
                        <asp:Label ID="genreLabel" runat="server" Text='<%# Bind("Genre") %>'></asp:Label>
                    </ItemTemplate>
                     <EditItemTemplate>
                        <asp:TextBox ID="editGenreTextBox" runat="server" Text='<%# Bind("Genre") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Number Of Page">
                    <ItemTemplate>
                        <asp:Label ID="numberOfPageLabel" runat="server" Text='<%# Bind("NumberOfPage") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="editNumberOfPageTextBox" runat="server" Text='<%# Bind("NumberOfPage") %>'></asp:TextBox>
                     </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Landed To A Friend">
                    <ItemTemplate>
                        <asp:Label ID="landedToAFriendLabel" runat="server" Text='<%# Bind("LandedToAFriend") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="editlandedToAFriendTextBox" runat="server" Text='<%# Bind("LandedToAFriend") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Name Of A Friend">
                    <ItemTemplate>
                        <asp:Label ID="nameOfFriendLabel" runat="server" Text='<%# Bind("NameOfFriend") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="editnameOfFriendTextBox" runat="server" Text='<%# Bind("NameOfFriend") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Comment">
                    <ItemTemplate>
                        <asp:Label ID="commentLabel" runat="server" Text='<%# Bind("Comment") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="editCommentTextBox" runat="server" Text='<%# Bind("Comment") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowDeleteButton="True" >
                <ControlStyle ForeColor="Red" />
                </asp:CommandField>
                <asp:CommandField ShowEditButton="True">
                <ControlStyle ForeColor="Blue" />
                </asp:CommandField>
            </Fields>
        </asp:DetailsView>
    </p>--%>
</asp:Content>

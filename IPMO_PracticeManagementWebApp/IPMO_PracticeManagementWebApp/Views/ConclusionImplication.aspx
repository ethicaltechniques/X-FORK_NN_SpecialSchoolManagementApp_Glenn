<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConclusionImplication.aspx.cs" Inherits="IPMO_PracticeManagementWebApp.Views.ConclusionImplication" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />

        <p>
            <h1>7 Form Conclusion/Implication</h1>
            <asp:Button ID="AttachmentButton" runat="server" Text="+Attachment" />
        </p>
        <br />

        <p>
            <asp:Table runat="server" BorderWidth="10px">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell BorderWidth="10px">Conclusion</asp:TableHeaderCell>
                    <asp:TableHeaderCell BorderWidth="10px">Implication</asp:TableHeaderCell>
                    <asp:TableHeaderCell BorderWidth="10px">Name and Role</asp:TableHeaderCell>
                    <asp:TableHeaderCell BorderWidth="10px">Signature</asp:TableHeaderCell>
                    <asp:TableHeaderCell BorderWidth="10px">Date and Place</asp:TableHeaderCell>
                </asp:TableHeaderRow>
                <asp:TableRow>
                    <asp:TableCell BorderWidth="10px">
                        <textarea id="ConclusionTextArea1" rows="2" cols="20"></textarea>
                  
                    </asp:TableCell>
                    <asp:TableCell BorderWidth="10px">
                        <textarea id="ImplicationTextArea1" rows="2" cols="20"></textarea>                
                        
                    </asp:TableCell>
                    <asp:TableCell BorderWidth="10px">
                         <asp:TextBox ID="NameAndRoleTextBox1" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell BorderWidth="10px">
                         <asp:TextBox ID="SignatureTextBox1" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell BorderWidth="10px">
                         <asp:TextBox ID="DateAndPlaceTextBox1" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <p>
                <asp:Button ID="FieldsButton" runat="server" Text="+fields" />
            </p>
    </div>

</asp:Content>

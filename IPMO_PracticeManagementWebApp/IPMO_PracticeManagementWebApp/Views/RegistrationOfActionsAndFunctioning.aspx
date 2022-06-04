<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrationOfActionsAndFunctioning.aspx.cs" Inherits="IPMO_PracticeManagementWebApp.Views.RegistrationOfActionsAndFunctioning" %>

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
            <h1>5 Form Registration of Actions and Functioning</h1>
            <asp:Button ID="AttachmentButton" runat="server" Text="+Attachment" />
        </p>
        <br />

        <p>
            <asp:Table runat="server" BorderWidth="10px">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell BorderWidth="10px">Sl. No.</asp:TableHeaderCell>
                    <asp:TableHeaderCell BorderWidth="10px">Actions Related to Goals</asp:TableHeaderCell>
                    <asp:TableHeaderCell BorderWidth="10px">Data</asp:TableHeaderCell>
                </asp:TableHeaderRow>
                <asp:TableRow>
                    <asp:TableCell BorderWidth="10px">
                        1
                    </asp:TableCell>
                    <asp:TableCell BorderWidth="10px">
                        <textarea id="ActionsRelatedToGoalsTextArea1" rows="2" cols="20"></textarea>       
                    </asp:TableCell>
                    <asp:TableCell BorderWidth="10px">
                        <asp:TextBox ID="DataTextBox1" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <p>
                <asp:Button ID="FieldsButton" runat="server" Text="+fields" />
            </p>
    </div>

</asp:Content>

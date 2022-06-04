<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ResultsAppliedMeans.aspx.cs" Inherits="IPMO_PracticeManagementWebApp.Views.ResultsAppliedMeans" %>

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
            <h1>6 Form Result (applied means)</h1>
            <asp:Button ID="AttachmentButton" runat="server" Text="+Attachment" />
        </p>
        <br />

        <p>
            <asp:Table runat="server" BorderWidth="10px">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell BorderWidth="10px">Sl. No.</asp:TableHeaderCell>
                    <asp:TableHeaderCell BorderWidth="10px">Result Goals</asp:TableHeaderCell>
                    <asp:TableHeaderCell BorderWidth="10px">Applied Means</asp:TableHeaderCell>
                </asp:TableHeaderRow>
                <asp:TableRow>
                    <asp:TableCell BorderWidth="10px">
                        1
                    </asp:TableCell>
                    <asp:TableCell BorderWidth="10px">
                        <asp:TextBox ID="ResultGoalsTextBox1" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell BorderWidth="10px">
                         <textarea id="AppliedMeansTextArea1" rows="2" cols="20"></textarea>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <p>
                <asp:Button ID="FieldsButton" runat="server" Text="+fields" />
            </p>
    </div>

</asp:Content>

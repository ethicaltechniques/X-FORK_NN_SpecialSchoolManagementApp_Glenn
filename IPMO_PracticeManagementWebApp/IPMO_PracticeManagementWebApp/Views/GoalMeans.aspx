<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GoalMeans.aspx.cs" Inherits="IPMO_PracticeManagementWebApp.Views.GoalMeans" %>

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
            <h1>4 Form Goal-Means (Plan)</h1>
            <asp:Button ID="AttachmentButton" runat="server" Text="+Attachment" />
        </p>
        <br />

        <p>
            <asp:PlaceHolder ID="GoalMeansPlaceHolder" runat="server">
                <asp:Table runat="server" BorderWidth="10px">
                    <asp:TableHeaderRow>
                        <asp:TableHeaderCell BorderWidth="10px">Sl. No.</asp:TableHeaderCell>
                        <asp:TableHeaderCell BorderWidth="10px">Goals</asp:TableHeaderCell>
                        <asp:TableHeaderCell BorderWidth="10px">Means Planned</asp:TableHeaderCell>
                    </asp:TableHeaderRow>
                    <asp:TableRow>
                        <asp:TableCell BorderWidth="10px">
                        1
                        </asp:TableCell>
                        <asp:TableCell BorderWidth="10px">
                            <asp:TextBox ID="GoalsTextBox1" runat="server"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell BorderWidth="10px"><textarea id="MeansTextArea1" rows="2" cols="20"></textarea></asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </asp:PlaceHolder>
            <p>
                <asp:Button ID="FieldsButton" runat="server" Text="+fields" OnClick="FieldsButton_Click" />
            </p>
    </div>

</asp:Content>

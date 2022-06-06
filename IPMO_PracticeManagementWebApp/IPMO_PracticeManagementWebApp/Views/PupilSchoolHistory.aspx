<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PupilSchoolHistory.aspx.cs" Inherits="IPMO_PracticeManagementWebApp.Views.PupilSchoolHistory" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <asp:PlaceHolder ID="PupilSchoolHistoryPlaceHolder" runat="server">
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />

            <asp:Panel ID="ValidationPanelForPupilSchoolHistory" runat="server">
            </asp:Panel>

            <p>
                <h1>2a Form for Pupil School History</h1>
                <asp:Button ID="AttachmentButton" runat="server" Text="+Attachment" />
            </p>
            <br />

            <p>
                <h5>
                    <asp:TextBox ID="PassportNumberLabel" runat="server" Text="Passport Number"></asp:TextBox>
                </h5>
            </p>
            <p>
                <asp:TextBox ID="PassportNumberTextBox" runat="server" TextMode="MultiLine"></asp:TextBox>

            </p>

            <asp:Table ID="table" runat="server"></asp:Table>

        </asp:PlaceHolder>

        <p>
            <asp:Button ID="FieldsButton" runat="server" Text="+fields" OnClick="AddFieldButton_Click" />
        </p>

        <p>
            <asp:Button ID="PupilSchoolHistoryButton" runat="server" Text="Submit Pupil School History" OnClick="PupilSchoolHistoryButton_Click" />
        </p>
    </div>

    <%--</asp:PlaceHolder>--%>
</asp:Content>

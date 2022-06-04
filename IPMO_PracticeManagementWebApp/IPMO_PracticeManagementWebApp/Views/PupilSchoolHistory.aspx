<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PupilSchoolHistory.aspx.cs" Inherits="IPMO_PracticeManagementWebApp.Views.PupilSchoolHistory" %>

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
            <h1>2a Form for Pupil School History</h1>
            <asp:Button ID="AttachmentButton" runat="server" Text="+Attachment" />
        </p>
        <br />

        <p>
            <h5>Primary Education</h5>
            <textarea id="PrimaryEducationTextArea" cols="20" rows="2"></textarea>
        </p>
        <p>
            <h5>Secondary Education</h5>
            <textarea id="SecondaryEducationTextArea" cols="20" rows="2"></textarea>
        </p>
        <p>
            <asp:Button ID="FieldsButton" runat="server" Text="+fields" />
        </p>
    </div>

</asp:Content>

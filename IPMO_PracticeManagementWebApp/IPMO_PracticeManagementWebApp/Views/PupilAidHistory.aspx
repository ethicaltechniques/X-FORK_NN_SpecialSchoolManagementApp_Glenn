<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PupilAidHistory.aspx.cs" Inherits="IPMO_PracticeManagementWebApp.Views.PupilAidHistory" %>

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
            <h1>2b Form for Pupil Aid History</h1>
            <asp:Button ID="AttachmentButton" runat="server" Text="+Attachment" />
        </p>
        <br />

        <p>
            <h5>IQ</h5>
            <textarea id="IQTextArea" cols="20" rows="2"></textarea>
        </p>
        <p>
            <h5>Didactic</h5>
            <textarea id="DidacticTextArea" cols="20" rows="2"></textarea>
        </p>
        <p>
            <h5>Diagnosis</h5>
            <textarea id="DiagnosisTextArea" cols="20" rows="2"></textarea>
        </p>
        <p>
            <h5>System</h5>
            <textarea id="SystemTextArea" cols="20" rows="2"></textarea>
        </p>
        <p>
            <asp:Button ID="FieldsButton" runat="server" Text="+fields" />
        </p>
    </div>

</asp:Content>

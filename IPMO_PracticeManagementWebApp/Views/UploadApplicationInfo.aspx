<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UploadApplicationInfo.aspx.cs" Inherits="IPMO_PracticeManagementWebApp.Views.UploadApplicationInfo" %>

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
            <h1>Upload all your application info</h1>
        </p>
        <p>
            <asp:Button ID="AttachmentButton" runat="server" Text="+Attachment" /></p>

        <p>Info will automatically uploaded to database.</p>
        <p>You may add absent info or additional new info in the next forms.</p>
        <p>If your application is incomplete, you will be contacted.</p>
    </div>
</asp:Content>

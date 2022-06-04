<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProtectiveRiskFactors.aspx.cs" Inherits="IPMO_PracticeManagementWebApp.Views.ProtectiveRiskFactors" %>

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
            <h1>3 Form Protective/Risk Factor</h1>
            <asp:Button ID="AttachmentButton" runat="server" Text="+Attachment" />
        </p>
        <br />

        <p>
            <h5>Protective Factor</h5>
            <textarea id="ProtectiveFactorTextArea" cols="20" rows="2"></textarea>
        </p>
        <p>
            <h5>Risk Factor</h5>
            <textarea id="RiskFactorTextArea" cols="20" rows="2"></textarea>
        </p>
        <p>
            <asp:Button ID="FieldsButton" runat="server" Text="+fields" />
        </p>
    </div>

</asp:Content>

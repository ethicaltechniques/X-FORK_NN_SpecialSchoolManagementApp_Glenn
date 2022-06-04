<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReferringSchoolInfo.aspx.cs" Inherits="IPMO_PracticeManagementWebApp.Views.ReferringSchoolInfo" %>

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
            <h1>1c Form Referring School</h1>
            <asp:Button ID="AttachmentButton" runat="server" Text="+Attachment" />
        </p>
        <br />

        <p>
            <h5>School Name</h5>
            <asp:TextBox ID="SchoolNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <h5>Address</h5>
            <textarea id="AddressTextArea" cols="20" rows="2"></textarea>
        </p>
        <p>
            <h5>Telephone Number</h5>
            <asp:TextBox ID="TelephoneNumberTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <h5>Email</h5>
            <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <h5>Contact Person</h5>
            <asp:TextBox ID="ContactPersonTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <h5>Email Contact</h5>
            <asp:TextBox ID="EmailContactTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <h5>Explain Agreement</h5>
            <asp:TextBox ID="ExplainAgreementTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <h5>Referal Name</h5>
            <asp:TextBox ID="ReferalNameTextBox" runat="server"></asp:TextBox>
        </p>
    </div>

</asp:Content>

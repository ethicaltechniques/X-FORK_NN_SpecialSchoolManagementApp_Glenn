﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReferringSchoolInfo.aspx.cs" Inherits="IPMO_PracticeManagementWebApp.Views.ReferringSchoolInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />

        <asp:Panel ID="ValidationPanelForReferringSchoolInfo" runat="server">
        </asp:Panel>

        <p>
            <h1>1c Form Referring School</h1>
            <asp:Button ID="AttachmentButton" runat="server" Text="+Attachment" />
        </p>
        <br />

        <asp:PlaceHolder ID="ReferringSchoolInfoPlaceHolder" runat="server">

            <p>
                <h5>
                    <asp:Label ID="SchoolNameLabel" runat="server" Text="School Name"></asp:Label></h5>
                <asp:TextBox ID="SchoolNameTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <h5>
                    <asp:Label ID="AddressLabel" runat="server" Text="Address"></asp:Label></h5>
                <%--<textarea id="AddressTextArea1" cols="20" rows="2"></textarea>--%>
                <asp:TextBox ID="AddressTextArea" runat="server" TextMode="MultiLine" Rows="2" Columns="20"></asp:TextBox>
            </p>
            <p>
                <h5>
                    <asp:Label ID="TelephoneNumberLabel" runat="server" Text="Telephone Number"></asp:Label></h5>
                <asp:TextBox ID="TelephoneNumberTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <h5>
                    <asp:Label ID="EmailLabel" runat="server" Text="Email"></asp:Label></h5>
                <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <h5>
                    <asp:Label ID="ContactPersonLabel" runat="server" Text="Contact Person"></asp:Label></h5>
                <asp:TextBox ID="ContactPersonTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <h5>
                    <asp:Label ID="EmailContactLabel" runat="server" Text="Email Contact"></asp:Label></h5>
                <asp:TextBox ID="EmailContactTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <h5>
                    <asp:Label ID="ExplainAgreementLabel" runat="server" Text="Explain Agreement"></asp:Label></h5>
                <asp:TextBox ID="ExplainAgreementTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <h5>
                    <asp:Label ID="ReferalNameLabel" runat="server" Text="Referal Name"></asp:Label></h5>
                <asp:TextBox ID="ReferalNameTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <h5>
                    <asp:Label ID="PassportNumberLabel" runat="server" Text="Passport Number"></asp:Label></h5>
                <asp:TextBox ID="PassportNumberTextBox" runat="server"></asp:TextBox>
            </p>

        </asp:PlaceHolder>

        <p>
            <asp:Button ID="ReferringSchoolInfoButton" runat="server" Text="Submit Referring School Info" OnClick="ReferringSchoolInfoButton_Click" />
        </p>
    </div>

</asp:Content>

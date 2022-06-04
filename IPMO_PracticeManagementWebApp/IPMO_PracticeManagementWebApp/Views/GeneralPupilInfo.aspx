<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GeneralPupilInfo.aspx.cs" Inherits="IPMO_PracticeManagementWebApp.Views.GeneralPupilInfo" %>

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
            <h1>1a Form for General Pupil Info</h1>
            <asp:Button ID="AttachmentButton" runat="server" Text="+Attachment" />
        </p>
        <br />
        
        <p><h5>First Name</h5> <asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox> </p>
        <p><h5>Initials</h5> <asp:TextBox ID="InitialsTextBox" runat="server"></asp:TextBox></p>
        <p><h5>Date Of Birth</h5> <asp:TextBox ID="DateOfBirthTextBox" runat="server"></asp:TextBox><asp:Calendar runat="server"></asp:Calendar></p>
        <p><h5>Country</h5> <asp:TextBox ID="CountryTextBox" runat="server"></asp:TextBox></p>
        <p><h5>Address</h5> <textarea id="AddressTextArea" cols="20" rows="2"></textarea></p>
        <p><h5>City</h5> <asp:TextBox ID="CityTextBox" runat="server"></asp:TextBox></p>
        <p><h5>Mobile</h5> <asp:TextBox ID="MobileTextBox" runat="server"></asp:TextBox></p>
        <p><h5>Email</h5> <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox></p>
    </div>
</asp:Content>

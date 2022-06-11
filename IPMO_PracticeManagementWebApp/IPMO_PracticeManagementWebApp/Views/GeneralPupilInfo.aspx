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

        <asp:Panel ID="ValidationPanelForGeneralPupilInfo" runat="server">
        </asp:Panel>

        <p>
            <h1>1a Form for General Pupil Info</h1>
            <asp:Button ID="AttachmentButton" runat="server" Text="+Attachment" />
        </p>
        <br />

        <asp:PlaceHolder ID="GeneralPupilInfoPlaceHolder" runat="server">
            <p>
                <h5>
                    <asp:Label ID="FirstNameLabel" runat="server" Text="First Name"></asp:Label></h5>
                <asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <h5>
                    <asp:Label ID="InitialsLabel" runat="server" Text="Initials"></asp:Label></h5>
                <asp:TextBox ID="InitialsTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <h5>
                    <asp:Label ID="DateOfBirthLabel" runat="server" Text="Date Of Birth"></asp:Label></h5>
                <asp:TextBox ID="DateOfBirthTextBox" runat="server"></asp:TextBox><asp:Calendar runat="server" ID="DOBCalendar" OnSelectionChanged="Unnamed1_SelectionChanged"></asp:Calendar>
            </p>
            <p>
                <h5>
                    <asp:Label ID="CountryLabel" runat="server" Text="Country"></asp:Label></h5>
                <asp:TextBox ID="CountryTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <h5>
                    <asp:Label ID="AddressLabel" runat="server" Text="Address"></asp:Label></h5>
                <asp:TextBox ID="AddressTextArea" runat="server" TextMode="MultiLine" Rows="2" Columns="20"></asp:TextBox>
            </p>
            <p>
                <h5>
                    <asp:Label ID="CityLabel" runat="server" Text="City"></asp:Label></h5>
                <asp:TextBox ID="CityTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <h5>
                    <asp:Label ID="MobileLabel" runat="server" Text="Mobile"></asp:Label></h5>
                <asp:TextBox ID="MobileTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <h5>
                    <asp:Label ID="EmailLabel" runat="server" Text="Email"></asp:Label></h5>
                <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <h5>
                    <asp:Label ID="PassportNumberLabel" runat="server" Text="Passport Number"></asp:Label></h5>
                <asp:TextBox ID="PassportNumberTextBox" runat="server"></asp:TextBox>
            </p>
            <br />
            <br />
            <p>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="GeneralPupilInfoButton_Click" class="btn btn-primary btn-md pull-left btn-sm" Style="margin-right: 4px;" />
                <asp:Button ID="Button2" runat="server" Text="View" OnClick="GeneralPupilInfoViewButton_Click" class="btn btn-primary btn-md pull-left btn-sm" Style="margin-right: 4px;" />
                <asp:Button ID="Button3" runat="server" Text="Update" OnClick="GeneralPupilInfoUpdateButton_Click" class="btn btn-primary btn-md pull-left btn-sm" Style="margin-right: 4px;" />
            </p>
        </asp:PlaceHolder>
        <br />
        <br />
    </div>
</asp:Content>

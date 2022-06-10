<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegisterPupilInfo.aspx.cs" Inherits="IPMO_PracticeManagementWebApp.Views.RegisterPupilInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />

        <asp:Panel ID="ValidationPanelForRegisterPupilInfo" runat="server">
        </asp:Panel>

        <p>
            <h1>1b Form for Registering Pupil</h1>
            <asp:Button ID="AttachmentButton" runat="server" Text="+Attachment" />
        </p>
        <br />

        <asp:PlaceHolder ID="RegisterPupilInfoPlaceHolder" runat="server">
            <p>
                <h5>
                    <asp:Label ID="PassportNumberLabel" runat="server" Text="Passport Number"></asp:Label></h5>
                <asp:TextBox ID="PassportNumberTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <h5>
                    <asp:Label ID="IdNumberLabel" runat="server" Text="Id Number"></asp:Label></h5>
                <asp:TextBox ID="IdNumberTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <h5>
                    <asp:Label ID="InsuranceOrgLabel" runat="server" Text="Insurance Org"></asp:Label></h5>
                <asp:TextBox ID="InsuranceOrgTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <h5>
                    <asp:Label ID="InsuranceNumberLabel" runat="server" Text="Insurance Number"></asp:Label></h5>
                <asp:TextBox ID="InsuranceNumberTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <h5>
                    <asp:Label ID="MotherCaretakerLabel" runat="server" Text="Mother/Caretaker"></asp:Label></h5>
                <asp:TextBox ID="MotherTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <h5>
                    <asp:Label ID="FatherCaretakerLabel" runat="server" Text="Father/Caretaker"></asp:Label></h5>
                <asp:TextBox ID="FatherTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <h5>
                    <asp:Label ID="MobileMotherLabel" runat="server" Text="Mobile Mother"></asp:Label></h5>
                <asp:TextBox ID="MobileMotherTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <h5>
                    <asp:Label ID="MobileFatherLabel" runat="server" Text="Mobile Father"></asp:Label></h5>
                <asp:TextBox ID="MobileFatherTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <h5>
                    <asp:Label ID="EmailCaretakerLabel" runat="server" Text="Email Caretaker"></asp:Label></h5>
                <asp:TextBox ID="EmailCaretakerTextBox" runat="server"></asp:TextBox>
            </p>
        </asp:PlaceHolder>
        <p>
            <asp:Button ID="RegisterPupilInfoButton" runat="server" Text="Register Pupil Info" OnClick="RegisterPupilInfoButton_Click" />

        </p>
         <p>
            <asp:Button ID="RegisterPupilInfoViewButton" runat="server" Text="View Registered Pupil Info" OnClick="RegisterPupilInfoViewButton_Click" />
        </p>
        <p>
            <asp:Button ID="RegisterPupilInfoUpdateButton" runat="server" Text="Update Registered Pupil Info" OnClick="RegisterPupilInfoUpdateButton_Click" />
        </p>

    </div>

</asp:Content>

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

        <p>
            <h1>1b Form for Registering Pupil</h1>
            <asp:Button ID="AttachmentButton" runat="server" Text="+Attachment" />
        </p>
        <br />

        <p>
            <h5>Passport Number</h5>
            <asp:TextBox ID="PassportNumberTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <h5>Id Number</h5>
            <asp:TextBox ID="IdNumberTextBox" runat="server"></asp:TextBox></p>
        <p>
            <h5>Insurance Org</h5>
            <asp:TextBox ID="InsuranceOrgTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <h5>Insurance Number</h5>
            <asp:TextBox ID="InsuranceNumberTextBox" runat="server"></asp:TextBox></p>
        <p>
            <h5>Mother/Caretaker</h5>
            <asp:TextBox ID="MotherTextBox" runat="server"></asp:TextBox></p>
        <p>
            <h5>Father/Caretaker</h5>
            <asp:TextBox ID="FatherTextBox" runat="server"></asp:TextBox></p>
        <p>
            <h5>Mobile Mother</h5>
            <asp:TextBox ID="MobileMotherTextBox" runat="server"></asp:TextBox></p>
        <p>
            <h5>Mobile Father</h5>
            <asp:TextBox ID="MobileFatherTextBox" runat="server"></asp:TextBox></p>
        <p>
            <h5>Email Caretaker</h5>
            <asp:TextBox ID="EmailCaretakerTextBox" runat="server"></asp:TextBox></p>
    </div>

</asp:Content>

<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewPupilData.aspx.cs" Inherits="IPMO_PracticeManagementWebApp.Views.ViewPupilData" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p></p>
    <br />
    <asp:PlaceHolder ID = "PlaceHolderForPupilRegistration" runat="server" />
    <p></p>
    <br />
    <asp:PlaceHolder ID = "PlaceHolderForRiskFactors" runat="server" />
    <p></p>
    <br />
    <asp:PlaceHolder ID = "PlaceHolderForSchoolResults" runat="server" />
    <p></p>
    <br />
 </asp:Content>

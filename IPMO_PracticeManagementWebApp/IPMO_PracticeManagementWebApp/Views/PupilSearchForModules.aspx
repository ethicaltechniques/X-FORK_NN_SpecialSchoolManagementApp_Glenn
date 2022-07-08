<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PupilSearchForModules.aspx.cs" Inherits="IPMO_PracticeManagementWebApp.Views.PupilSearchForModules" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        /* (A) GRID CONTAINER */
        .grid-wrap {
            display: grid;
            grid-template-columns: auto auto;
        }

            /* (B) OPTIONAL COSMETICS */
            .grid-wrap > * {
                box-sizing: border-box;
                padding: 10px;
                background: #f3ffe0;
            }
    </style>

    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />

    <div class="grid-wrap">
        <div id="searchSection">
            <table>
                <tr>
                    <td>Search:</td>
                    <td>
                        <input type="text" id="searchValue" />
                    </td>

                    <td>
                        <input type="button" value="Search" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <br />
                        <span>
                            <input type="radio" id="GeneralPupilInfo" name="form" value="General Pupil Info" />
                            <label for="GeneralPupilInfo">General Pupil Info</label><br />
                        </span>
                        <br />
                        <span>
                            <input type="radio" id="TrackingPupilScore" name="form" value="Tracking Pupil Score" />
                            <label for="TrackingPupilScore">Tracking Pupil's Score</label><br />
                        </span>
                        <br />
                        <span>
                            <input type="radio" id="RegisteringPupilDaily" name="form" value="Registering Pupil Daily Functioning" />
                            <label for="RegisteringPupilDaily Functioning">Registering Pupil's Daily Functioning</label><br />
                        </span>
                        <br />
                        <span>
                            <input type="radio" id="ReferringSchoolInfo" name="form" value="Referring School Info" />
                            <label for="ReferringSchoolInfo">Referring School Info</label><br />
                        </span>
                        <br />
                        <span>
                            <input type="radio" id="PupilSchoolHistory" name="form" value="Pupil School History" />
                            <label for="PupilSchoolHistory">Pupil School History</label><br />
                        </span>
                        <br />
                        <span>
                            <input type="radio" id="PupilAidHistory" name="form" value="Pupil Aid History" />
                            <label for="PupilAidHistory">Pupil Aid History</label><br />
                        </span>
                        <br />
                        <span>
                            <input type="radio" id="ProtectiveRiskFactors" name="form" value="Protective Risk Factors" />
                            <label for="ProtectiveRiskFactors">Protective/Risk Factors</label><br />
                        </span>
                        <br />
                        <span>
                            <input type="radio" id="GoalMeans" name="form" value="Goal Means" />
                            <label for="GoalMeans">Goals - Means (Plan)</label><br />
                        </span>
                        <br />
                        <span>
                            <input type="radio" id="RegistrationOfActionsAndFunctioning" name="form" value="Registration Of Actions And Functioning" />
                            <label for="RegistrationOfActionsAndFunctioning">Registration Of Actions And Functioning</label><br />
                        </span>
                        <br />
                        <span>
                            <input type="radio" id="ResultsAppliedMeans" name="form" value="Results Applied Means" />
                            <label for="ResultsAppliedMeans">Results Applied Means</label><br />
                        </span>
                        <br />
                        <span>
                            <input type="radio" id="ConclusionImplication" name="form" value="Registration Of Actions And Functioning" />
                            <label for="ConclusionImplication">Conclusion/Implication</label><br />
                        </span>
                        <br />
                    </td>
                </tr>
            </table>
        </div>
        <div id="formSection">
        </div>
    </div>

</asp:Content>

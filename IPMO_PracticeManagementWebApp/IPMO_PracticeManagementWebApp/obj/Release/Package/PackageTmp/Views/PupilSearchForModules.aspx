<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PupilSearchForModules.aspx.cs" Inherits="IPMO_PracticeManagementWebApp.Views.PupilSearchForModules" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <form id="form1">
        <head>
            <title>Pupil Search</title>
            <meta charset="utf-8" />
            <meta name="viewport" content="width=device-width, initial-scale=1" />
            <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css" />
            <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
            <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>

            <style>
                .grid-wrap {
                    display: grid;
                    grid-template-columns: auto auto;
                }

                    .grid-wrap > * {
                        box-sizing: border-box;
                        padding: 10px;
                        background: #f3ffe0;
                    }
            </style>

            <head>
                <title>Pupil Search</title>
                <meta charset="utf-8" />
                <meta name="viewport" content="width=device-width, initial-scale=1" />
                <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css" />
                <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
                <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>

                <script type="text/javascript">

                    function getAllData() {
                        var data = [];
                        var searchValue = $('#searchValue').val();
                        var formName = "General Pupil Info";

                        if (searchValue != undefined) {
                            var alldata = {
                                'SearchValue': searchValue,
                                'FormName': formName
                            }

                            data.push(alldata);
                        }

                        console.log(data);
                        return data;
                    }

                    function loadPupilData() {

                        var data = JSON.stringify(getAllData());

                        $.ajax({
                            url: 'PupilSearchForModules.aspx/SearchData',
                            type: 'POST',
                            dataType: 'json',
                            contentType: 'application/json; charset=utf-8',
                            data: JSON.stringify({ 'allData': data }),
                            success: function (message) {

                                if (message.d.includes("Error")) {
                                    $("#validationMessage").html('<div class="alert alert-danger">' + message.d + '</div>');
                                }
                                else {
                                    data = message;

                                    var htmlValue = '<table id="thetable" class="table"><tr><td></td><td><b>First Name</b></td><td><b>Passport Number</b></td></tr>';


                                    for (var i = 0; i < data.d.length; i++) {

                                        htmlValue += '<tr><td> <input type=\'radio\' name=\'fieldValue\' id=' + data.d[i].PassportNumber + ' /> </td>' +
                                            '<td>' + data.d[i].FirstName +
                                            '</td><td>' + data.d[i].PassportNumber + '</td></tr>';
                                    }

                                    htmlValue += '</table>';
                                    $('#formSection').append(htmlValue);

                                    htmlValue = '';

                                    $("#validationMessage").html('<div class="alert alert-success">Search Results Retrieved Successfully</div>');
                                }
                            },
                            error: function (message) {
                                $("#validationMessage").html('<div class="alert alert-danger">' + message.d + '</div>');
                            }
                        });
                    }

                    function getSelectedData() {

                        var formName = '';
                        var passportNumber = '';
                        var dataForFormName = document.getElementsByName('form');
                        var dataForUser = document.getElementsByName('fieldValue');

                        for (let i of dataForFormName) {

                            if (i.checked) {
                                formName = i.value;
                            }
                        }

                        for (let j of dataForUser) {

                            if (j.checked) {
                                passportNumber = j.id;
                            }
                        }

                        var data = [];

                        if (searchValue != undefined) {
                            var alldata = {
                                'SearchValue': passportNumber,
                                'FormName': formName
                            }

                            data.push(alldata);
                        }

                        console.log(data);
                        return data;
                    }

                    function openForm() {

                        var data = JSON.stringify(getSelectedData());

                        $.ajax({
                            url: 'PupilSearchForModules.aspx/SearchFormData',
                            type: 'POST',
                            dataType: 'json',
                            contentType: 'application/json; charset=utf-8',
                            data: JSON.stringify({ 'allData': data }),
                            success: function (message) {

                                if (message.d.includes("Error")) {
                                    $("#validationMessage").html('<div class="alert alert-danger">' + message.d + '</div>');
                                }
                                else {
                                    data = message;
                                    var pageToLoad = '';

                                    if (data.d.length > 0) {
                                        var formName = data.d[0].FormName.split(' ').join('');
                                        pageToLoad = formName;
                                    }
                                    else {
                                        var formnameArray = getSelectedData();
                                        pageToLoad = formnameArray[0].FormName.split(' ').join('');
                                    }

                                    $("#myiframe").get(0).contentWindow.location.href = pageToLoad + '.aspx';
                                }
                            },
                            error: function (message) {
                                $("#validationMessage").html('<div class="alert alert-danger">' + message.d + '</div>');
                            }
                        });
                    }

                </script>
            </head>

            <body>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />

                <div id="validationMessage"></div>

                <div class="grid-wrap">
                    <div id="searchSection">
                        <table>
                            <tr>
                                <td>Search:</td>
                                <td>
                                    <input type="text" id="searchValue" />
                                </td>

                                <td>
                                    <button type="button" onclick="loadPupilData()" id="searchButton" class="btn btn-primary btn-md pull-left btn-sm" style="margin-right: 4px;">Search</button>
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
                                        <input type="radio" id="TrackingPupilScore" name="form" value="Tracking Pupil Scores" />
                                        <label for="TrackingPupilScore">Tracking Pupil's Score</label><br />
                                    </span>
                                    <br />
                                    <span>
                                        <input type="radio" id="RegisteringPupilDaily" name="form" value="Registering Pupil Daily Functioning" />
                                        <label for="RegisteringPupilDailyFunctioning">Registering Pupil's Daily Functioning</label><br />
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
                                        <input type="radio" id="ConclusionImplication" name="form" value="Conclusion Implication" />
                                        <label for="ConclusionImplication">Conclusion/Implication</label><br />
                                    </span>
                                    <br />
                                </td>
                            </tr>
                        </table>
                    </div>

                    <div id="containerForAnotherAspxPage" style="width: auto; height: auto">
                        <iframe id="myiframe" style="width: 120%; height: 100%"></iframe>
                    </div>

                    <div id="formSection" class="table-responsive">
                    </div>

                    <div id="buttonSection">
                        <input type="button" value="Open Form" onclick="openForm()" class="btn btn-primary btn-md pull-left btn-sm" style="margin-right: 4px;" />
                    </div>
                </div>


            </body>
    </form>
</asp:Content>

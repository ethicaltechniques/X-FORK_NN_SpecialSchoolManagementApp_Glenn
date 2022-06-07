<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PupilSchoolHistory.aspx.cs" Inherits="IPMO_PracticeManagementWebApp.Views.PupilSchoolHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1">
        <head>
            <title>Form for Pupil School History</title>
            <meta charset="utf-8" />
            <meta name="viewport" content="width=device-width, initial-scale=1" />
            <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css" />
            <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
            <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>

            <script type="text/javascript">  
                $(document).ready(function () {
                    $(document).on("click", ".classAdd", function () {
                        var rowCount = $('.data-contact-person').length + 1;
                        var contactdiv = '<tr class="data-contact-person">' +
                            '<td><input type="text" name="f-name' + rowCount + '" class="form-control f-name01" /></td>' +
                            '<td><textarea name="l-name' + rowCount + '" class="form-control l-name01" cols="20" rows="2" /></td>' +
                            '<td><button type="button" id="btnDelete" class="deleteContact btn btn btn-danger btn-xs">Remove</button></td>' +
                            '</tr>';
                        $('#maintable').append(contactdiv);
                    });

                    $(document).on("click", ".deleteContact", function () {
                        $(this).closest("tr").remove();
                    });

                    function getAllData() {
                        var data = [];
                        $('tr.data-contact-person').each(function () {
                            var fieldName = $(this).find('.f-name01').val();
                            var fieldValue = $(this).find('.l-name01').val();
                            var passportNumber = $('#passportNumberValue').val();

                            var alldata = {
                                'FieldName': fieldName,
                                'FieldValue': fieldValue,
                                'StudentUniqueId': passportNumber
                            }
                            data.push(alldata);
                        });
                        console.log(data);  
                        return data;
                    }
                    $("#btnSubmit").click(function () {
                        var data = JSON.stringify(getAllData());

                        $.ajax({
                            url: 'PupilSchoolHistory.aspx/SaveData',
                            type: 'POST',
                            dataType: 'json',
                            contentType: 'application/json; charset=utf-8',
                            data: JSON.stringify({ 'allData': data }),
                            success: function (message) {
                                $("#validationMessage").html('<div class="alert alert-success">' + message.d + '</div>');
                            },
                            error: function (message) {
                                $("#validationMessage").html('<div class="alert alert-danger">' + message.d + '</div>');
                            }
                        });
                    });
                });
            </script>

        </head>
        <body>

            <div class="container">
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />

                <div id="validationMessage"></div>

                <p>
                    <h1>2a Form for Pupil School History</h1>
                    <asp:Button ID="AttachmentButton" runat="server" Text="+Attachment" />
                </p>
                <br />

                <table class="table" id="maintable">
                    <tbody>
                        <tr class="data-contact-person">
                            <td>
                                <input id="passportNumberField" type="text" name="f-name01" class="form-control f-name01" value="Passport Number" /></td>
                            <td>
                                <input type="text" id="passportNumberValue" name="l-name01" class="form-control l-name01" /></td>
                            <td>
                                <button type="button" id="btnAdd" class="btn btn-xs btn-primary classAdd">+ Fields</button>
                            </td>
                        </tr>
                    </tbody>
                </table>
                <button type="button" id="btnSubmit" class="btn btn-primary btn-md pull-right btn-sm">Submit</button>
            </div>
        </body>
    </form>
</asp:Content>

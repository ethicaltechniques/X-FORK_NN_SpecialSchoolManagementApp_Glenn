<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConclusionImplication.aspx.cs" Inherits="IPMO_PracticeManagementWebApp.Views.ConclusionImplication" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1">
        <head>
            <title>Conclusion/Implication</title>
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
                            url: 'GoalMeans.aspx/SaveData',
                            type: 'POST',
                            dataType: 'json',
                            contentType: 'application/json; charset=utf-8',
                            data: JSON.stringify({ 'allData': data }),
                            success: function (message) {

                                if (message.d.includes("Error")) {
                                    $("#validationMessage").html('<div class="alert alert-danger">' + message.d + '</div>');
                                }
                                else {
                                    $("#validationMessage").html('<div class="alert alert-success">' + message.d + '</div>');
                                }
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
                    <h1>7 Form Conclusion/Implication</h1>
                    <asp:Button ID="AttachmentButton" runat="server" Text="+Attachment" />
                </p>
                <br />

                <table class="table">
                    <thead>
                        <tr class="data-contact-person">
                            <td>
                                <input id="passportNumberField" type="text" name="f-name01" class="form-control f-name01" value="Passport Number" />
                            </td>
                            <td>
                                <input type="text" id="passportNumberValue" name="l-name01" class="form-control l-name01" />
                            </td>
                        </tr>
                        <tr>
                            <td><span class="label label-warning">Conclusion</span></td>
                            <td><span class="label label-warning">Implication</span></td>
                        </tr>
                    </thead>
                    <tbody>
                        <tr class="data-contact-person">
                            <td>
                                <textarea name="f-name01" class="form-control f-name01" rows="2" cols="20"></textarea>
                            </td>
                            <td>
                                <textarea name="l-name02" class="form-control l-name01" cols="20" rows="2"></textarea>
                            </td>
                        </tr>
                    </tbody>
                </table>

                <table class="table" id="maintable">
                    <thead>
                        <tr>
                            <td>
                                <button type="button" id="btnAdd" class="btn btn-xs btn-primary classAdd">+ Fields</button>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <b>
                                    <span class="label label-warning">Name and Role</span>
                                </b>
                            </td>
                            <td>
                                <b>
                                    <span class="label label-warning">Signatures</span>
                                </b>
                            </td>
                        </tr>
                    </thead>
                    <tbody>
                        <tr class="data-contact-person">
                            <td>
                                <input type="text" name="f-name02" class="form-control f-name01" />
                            </td>
                            <td>
                                <textarea name="l-name02" class="form-control l-name01" cols="20" rows="2"></textarea>
                            </td>
                        </tr>
                        <tr class="data-contact-person">
                            <td>
                                <input type="text" name="f-name03" class="form-control f-name01" />
                            </td>
                            <td>
                                <textarea name="l-name03" class="form-control l-name01" cols="20" rows="2"></textarea>
                            </td>
                        </tr>                       
                    </tbody>
                </table>

                <table class="table">
                    <thead>
                        <tr>
                           <%-- <td><span class="label label-warning">Date and Place</span></td>--%>
                        </tr>
                    </thead>
                    <tbody>
                        <tr class="data-contact-person">
                             <td>
                                <input type="text" name="f-name02" class="form-control f-name01" value="Date and Place" />
                            </td>
                            <td>
                                <textarea name="l-name03" class="form-control l-name01" cols="20" rows="2"></textarea>
                            </td>
                        </tr>
                    </tbody>
                </table>

                <button type="button" id="btnSubmit" class="btn btn-primary btn-md pull-right btn-sm">Submit</button>
            </div>
        </body>
    </form>

</asp:Content>

"use strict";

$(document).ready(function () {
    $("#btnPartial").click(function () {
        $.get("Persons/PartialEdit/1", function (data, status) {
            console.log("Data: " + data + "\nStatus: " + status);

            $("#targetPartial").html(data);
        });
    })
})
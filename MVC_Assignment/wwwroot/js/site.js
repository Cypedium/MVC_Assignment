"use strict";

$(document).ready(function () {
    $("#btnPartial").click(function () {
        $.get("Persons/PersonPartialEdit/1", function (data, status) {
            console.log("Data: " + data + "\nStatus: " + status);

            $("#targetPartial").html(data);
        });
    })
})

$(document).ready(function () {
    $("#aPersonPartialEdit").click(function (e)
    {
        e.preventDefault(); var_this = $(this);
        $.get(_this.attr("Persons/PersonPartialEdit/"), function (res) {                  //_this.attr("href")
            $('#' + _this.data("targetPartial2")).html(res);
        });
    });
})

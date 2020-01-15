"use strict";

$(document).ready(function () {
    $("#btnPartial").click(function () {
        $.get("Persons/PersonPartialEdit/1", function (data, status) {
            console.log("Data: " + data + "\nStatus: " + status);

            $("#targetPartial").html(data);
        });
    })
})

//$(document).ready(function () {
//    $("#aPartialPersonEdit").click(function (e)
//    {
//        e.preventDefault();
//        var _this = $(this);
//        console.log(_this);

//        $.get(_this.attr("href"), function (res)
//        {                  //_this.attr("href")
//            console.log(_this.data("target"));
//            $('#' + _this.data("target")).html(res);
//        });
//    });
//})

//document.getElementById("aPartialPersonEdit").addEventListener("click", function () { });

//document.getElementById("PartialViewId").addEventListener("click", function (e) {

//    e.preventDefault();
//    var _this = $(this);
//    console.log(this);
//    console.log(_this.attr("href"));
//    $.get(_this.attr("href"), function (res) {
//        $('#' + _this.data("target")).html(res);
//    });
//});

function partialLink (event) {
    event.preventDefault();
    console.log(event);
    var _this = event.target;
    
    console.log(_this.href);
    $.get(_this.href, function (res) {
        console.log(res);
        $('#' + _this.dataset.target).html(res);
    });
}
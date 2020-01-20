"use strict";

function getPartialLink (event) {
    event.preventDefault();
    console.log("Get");
    console.log(event);
    var _this = event.target;
  
    $.get(_this.href, function (getResult) {
       
        $('#' + _this.dataset.target).html(getResult);
    });
}

function getPartialCreate(event) {
    event.preventDefault();
    console.log("Get");

    var _this = event.target;

    $.get(_this.href, function (getResult) {

        $('#' + _this.dataset.target).append(getResult);
    });
}
function postLink(event) {
    event.preventDefault();
    
    var _this = event.target;
    console.log(event);
    
    $.post(_this.action + "/",
        {
            Name: _this[0].value, Country: _this[1].value
        },
        function (postResult) {
            $('#' + _this.dataset.target).append(postResult);
    });
}
function postRename(event) {
    event.preventDefault();

    var _this = event.target;

    $.post(_this.action, {
        Name: Greger,
        Country: Germany
    },
        function (postResult) {
            $('#' + _this.dataset.target).replaceWith(postResult);
        });
}

//$(document).ready(function () {
//    $("#btnPartial").click(function () {
//        $.get("Persons/PersonPartialEdit/1", function (data, status) {
//            console.log("Data: " + data + "\nStatus: " + status);

//            $("#targetPartial").html(data);
//        });
//    })
//})
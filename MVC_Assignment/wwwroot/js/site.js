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
    console.log("Get");
    
    var _this = event.target;
  
    $.get(_this.href, function (getResult) {
       
        $('#' + _this.dataset.target).html(getResult);
    });
}

function postLink(event) {
    event.preventDefault();
    console.log("Post");
    console.log(event);
    var _this = event.target;
    
    $.post(_this.action, { Name: "Ida", Country: "Sverige" }, function (postResult) {
        $('#' + _this.dataset.target).html(postResult);
    });
}


//$.post(_this.action, { Name: _this.form.elements[0].value, Country: _this.form.elements[1].value },  function (postResult) {
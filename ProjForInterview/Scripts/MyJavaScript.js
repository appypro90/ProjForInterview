//Unobtrusive javascript. Seperately kept in another file.
$(function () {
    $("#btn1").mouseover(function () {
        $("#btn1").css("backgroundColor", "red");
    });
    $("#btn1").mouseout(function () {
        $("#btn1").css("backgroundColor", "grey");
    });
});

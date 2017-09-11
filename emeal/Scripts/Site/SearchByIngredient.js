"use strict";
$(function () {

    $("#add").click(function () {

        var text = document.getElementById("ingredientSearch").value; //.value gets input values

        var li = document.createElement("li");
        var delButton = "<button class='btnDel btn btn-danger btn-xs'>x</button>";
        li.innerHTML = "<div class='btn btn-success btn-sm'>" + text + delButton + "</div>";

        document.getElementById("list").appendChild(li);
        document.getElementById("ingredientSearch").value = "";
    });

    $(document).on("click", ".btnDel", function (e) {
        var ingredient = $(this).parent().parent();
        ingredient.remove();
    });

});
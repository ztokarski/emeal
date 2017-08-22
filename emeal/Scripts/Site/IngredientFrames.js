"use strict";
$(function () {
    var frameCount = 0;

    $("#add-ingredient-frame").click(function (event) {
        event.preventDefault();

        var ingredientFrameIdString = "ingredients-frame-" + frameCount.toString();
        var ingredientFrameHTMLContent = "<div id='" + ingredientFrameIdString + "'>\
            <a href='#' class='btn btn-danger' id='delete-frame'>Delete</a>\
            <h6>Ingredient</h6>\
            <input type='text'/>\
            </div>";

        $("#recipe-ingredient-frames").append(ingredientFrameHTMLContent);
        frameCount += 1;
    });

    $("#delete-frame").click(function (event) {
        
    });

});
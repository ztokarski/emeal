"use strict";
$(function () {


    var ingredientFrameCount = 0;

    $("#add-ingredient-frame").click(function () {
        var ingredientFrameIdString = "Ingredients[" + ingredientFrameCount + "]";
        var ingredientFrameHTMLContent = "\
            <div class='col-md-3' id='" + ingredientFrameIdString + "'>\
                <label for='Ingredients[" + ingredientFrameCount + "].Name'>Name</label>\
                <input name='Ingredients[" + ingredientFrameCount + "]' type='text'/>\
                <button class='btn btn-danger delete-ingredient-frame'>Delete</button>\
            </div>";

        $("#ingredient-frames").append(ingredientFrameHTMLContent);
        ingredientFrameCount += 1;
    });


    $('#ingredient-frames').on('click', '.delete-ingredient-frame', function () {
        $(this).parent().remove();
    });
});
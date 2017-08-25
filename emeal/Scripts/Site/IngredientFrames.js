"use strict";
$(function () {
    var ingredient_container = $("#Ingredients");
    var ingredient_warning = $("#ingredient-warning");
    ingredient_warning.hide();

    $("#add-ingredient-frame").click(function (event) {
        event.preventDefault();

        var frame = document.createElement("div");
        frame.innerText = "Loading...";

        ingredient_container.append(frame);
        $(frame).load("/Ingredient/PartialIngredient", function (response, status) {
            if (status === "error") {
                ingredient_warning.innerText = "You smart, you loyal... but an error occured! Try again.";
                ingredient_warning.show();
                $(this).remove()
            }
        });
    });

    ingredient_container.on("click", ".delete-ingredient-frame", function (event) {
        event.preventDefault();
        $(this).parent().remove();
    });
});
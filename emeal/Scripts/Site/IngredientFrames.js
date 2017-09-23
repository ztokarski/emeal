"use strict";
$(function() {
    var ingredientContainer = $("#Ingredients");
    var ingredientWarning = $("#ingredient-warning");
    ingredientWarning.hide();

    $("#add-ingredient-frame").click(function(event) {
        event.preventDefault();

        var frame = document.createElement("div");
        frame.innerText = "Loading...";

        ingredientContainer.append(frame);
        $(frame).load("/Ingredient/PartialIngredient",
            function(response, status) {
                if (status === "error") {
                    ingredientWarning.innerText = "You smart, you loyal... but an error occured! Try again.";
                    ingredientWarning.show();
                    $(this).remove();
                }
            });
    });

    ingredientContainer.on("click",
        ".delete-ingredient-frame",
        function(event) {
            event.preventDefault();
            $(this).parent().remove();
        });
});
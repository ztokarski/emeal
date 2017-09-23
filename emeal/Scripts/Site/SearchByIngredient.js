"use strict";
$(function() {
    var ingredientResults = $("#ingredients-search-results");

    $("#ingredient-search-input").select2({
        placeholder: "Enter your ingredients here...",
        tags: false
    });

    $("#ingredient-search-form").submit(function(event) {
        event.preventDefault();

        if ($(this).valid()) {
            $.ajax({
                url: this.action,
                type: "POST",
                data: $(this).serialize(),
                complete: function(response, status) {
                    if (status === "error") {
                        ingredientResults.innerText = "An error occured. Please try again. :(";
                    } else {
                        // KURWO DZIAŁAJ
                        ingredientResults.innerText = response;
                    }

                }
            });
        }
    });
});
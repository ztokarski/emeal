"use strict";
$(function() {
    var ingredientResults = $("#ingredient-search-results");

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
                success: function(responseData) {
                    ingredientResults.html(responseData);
                },
                error: function() {
                    ingredientResults.html("<h3>An error occured. Please try again. :(</h3>");
                }
            });
        }
    });
});
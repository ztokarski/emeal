﻿$(function (): void {
	var ingredientResults: JQuery<HTMLElement> = $(".ingredient-search-result-container");

	$("#ingredient-search-input").select2({
		placeholder: "Enter your ingredients here...",
		tags: false
	});

	$("#my-allergies-input").select2({
		placeholder: "These products will be excluded from the search...",
		tags: false
	});

	$("#ingredient-search-form").submit(
		function (this: JQuery<HTMLElement>, event: JQuery.Event<EventTarget, null>): void {
			event.preventDefault();

			$.ajax({
				url: (<any>this).action,
				type: "POST",
				data: $(this).serialize(),
				success: function (responseData: string): void {
					ingredientResults.html(responseData);
				},
				error: () => {
					ingredientResults.html("<h3>An error occured. Please try again. :(</h3>");
				}
			});
		});
});
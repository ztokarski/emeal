$(() => {
	const ingredientContainer = $("#Ingredients");
	const ingredientWarning = $("#ingredient-warning");
	ingredientWarning.hide();

	$("#add-ingredient-frame").click(event => {
		event.preventDefault();

		const frame: HTMLElement = document.createElement("div");
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
		event => {
			event.preventDefault();
			$(this).parent().remove();
		});
});
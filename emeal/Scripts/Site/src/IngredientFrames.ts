$(function () {
	const ingredientContainer: JQuery<HTMLElement> = $("#ingredients");
	const ingredientWarning: JQuery<HTMLElement> = $("#ingredient-warning");
	ingredientWarning.hide();

	$("#add-ingredient-frame").click(event => {
		event.preventDefault();

		const frame: HTMLElement = document.createElement("div");
		frame.innerText = "Loading...";

		ingredientContainer.append(frame);
		$(frame).load("/Ingredient/PartialIngredient",
			function (response, status) {
				if (status === "error") {
					ingredientWarning.text("You smart, you loyal... but an error occured! Try again.");
					ingredientWarning.show();
					$(this).remove();
				}
			});
	});

	ingredientContainer.on("click", ".delete-ingredient-frame",
		function (this: HTMLElement, event) {
			event.preventDefault();
			$(this).parent().remove();
		});
});
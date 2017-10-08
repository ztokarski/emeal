$(function (): void {
	const ingredientContainer: JQuery<HTMLElement> = $("#ingredients");
	const ingredientWarning: JQuery<HTMLElement> = $("#ingredient-warning");
	ingredientWarning.hide();

	$("#add-ingredient-frame").click(event => {
		event.preventDefault();

		const frame: HTMLElement = document.createElement("div");
		frame.innerText = "Loading...";

		ingredientContainer.append(frame);
		$(frame).load("/Ingredient/PartialIngredient",
			function (response: string, status: JQuery.Ajax.TextStatus): void {
				if (status === "error") {
					ingredientWarning.text("You smart, you loyal... but an error occured! Try again.");
					ingredientWarning.show();
					$(this).remove();
				}
			});
	});

	ingredientContainer.on("click", ".delete-ingredient-frame",
		function (this: HTMLElement, event: JQuery.Event<EventTarget, null>): void {
			event.preventDefault();
			$(this).parent().remove();
		});
});
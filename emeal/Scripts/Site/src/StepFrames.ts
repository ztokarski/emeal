$(function (): void {
	var stepContainer: JQuery<HTMLElement> = $("#steps");
	var stepWarning: JQuery<HTMLElement> = $("#step-warning");

	stepWarning.hide();

	$("#add-step-frame").click(
		function (event: JQuery.Event<EventTarget, null>): void {
			event.preventDefault();
			stepWarning.hide(250);

			const frame: HTMLElement = document.createElement("div");
			frame.innerText = "Loading...";

			stepContainer.append(frame);
			$(frame).load("/Step/PartialStep",
				function (response: string, status: string): void {
					if (status === "error") {
						stepWarning.text("You smart, you loyal... but an error occured! Try again.");
						stepWarning.show(250);
						$(this).remove();
					}
				});
		});

	stepContainer.on("click", ".delete-step-frame",
		function (event: JQuery.Event<EventTarget, null>): void {
			event.preventDefault();
			$(this).parent().remove();
		});
});
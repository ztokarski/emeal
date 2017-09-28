$(function () {	
var stepContainer = $("#steps");
var stepWarning = $("#step-warning");

stepWarning.hide();

$("#add-step-frame").click(
	function (event: JQuery.Event<EventTarget, null>) {
		event.preventDefault();
		stepWarning.hide(250);

		const frame = document.createElement("div");
		frame.innerText = "Loading...";

		stepContainer.append(frame);
		$(frame).load("/Step/PartialStep",
			function (response: Response, status: string) {
				if (status === "error") {
					stepWarning.text("You smart, you loyal... but an error occured! Try again.");
					stepWarning.show(250);
					$(this).remove();
				}
			});
	});

stepContainer.on("click", ".delete-step-frame",
	function (event: JQuery.Event<EventTarget, null>) {
		event.preventDefault();
		$(this).parent().remove();
	});
});
"use strict";
$(function() {
    var stepContainer = $("#Steps");
    var stepWarning = $("#step-warning");
    stepWarning.hide();

    $("#add-step-frame").click(function(event) {
        event.preventDefault();
        stepWarning.hide(250);

        var frame = document.createElement("div");
        frame.innerText = "Loading...";

        stepContainer.append(frame);
        $(frame).load("/Step/PartialStep",
            function(response, status) {
                if (status === "error") {
                    stepWarning.val = "You smart, you loyal... but an error occured! Try again.";
                    stepWarning.show(250);
                    $(this).remove();
                }
            });
    });

    stepContainer.on("click",
        ".delete-step-frame",
        function(event) {
            event.preventDefault();
            $(this).parent().remove();
        });
});
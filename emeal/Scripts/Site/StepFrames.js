"use strict";
$(function () {
    var step_container = $("#Steps");
    var step_warning = $("#step-warning");
    step_warning.hide();

    $("#add-step-frame").click(function (event) {
        event.preventDefault();
        step_warning.hide(250);

        var frame = document.createElement("div");
        frame.innerText = "Loading...";

        step_container.append(frame);
        $(frame).load("/Step/PartialStep", function (response, status) {
            if (status === "error") {
                step_warning.val = "You smart, you loyal... but an error occured! Try again.";
                step_warning.show(250);
                $(this).remove()
            }
        });
    });

    step_container.on('click', '.delete-step-frame', function (event) {
        event.preventDefault();
        $(this).parent().remove();
    });
});
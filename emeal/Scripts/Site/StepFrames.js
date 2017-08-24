"use strict";
$(function () {


    var stepFrameCount = 0;

    $("#add-step-frame").click(function () {
        var stepFrameIdString = "Steps[" + stepFrameCount + "]";
        var stepFrameHTMLContent = "\
            <div class='col-md-3' id='" + stepFrameIdString + "'>\
                <label for='Step[" + stepFrameCount + "].Name'>Name</label>\
                <input name='Step[" + stepFrameCount + "]' type='text'/>\
                <button class='btn btn-danger delete-step-frame'>Delete</button>\
            </div>";

        $("#step-frames").append(stepFrameHTMLContent);
        stepFrameCount += 1;
    });


    $('#step-frames').on('click', '.delete-step-frame', function () {
        $(this).parent().remove();
    });
});
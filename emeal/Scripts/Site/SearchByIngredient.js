"use strict";
$(function() {

    $("#add").click(function() {

    //First things first, we need our text:
    var text = document.getElementById("ingredientSearch").value; //.value gets input values

    //Now construct a quick list element
    var li = document.createElement("li");
    var delButton = "<button class='btnDel btn btn-danger btn-xs'>x</button>";
    li.innerHTML = "<div class=\"btn btn-success btn-sm\">" + text + delButton + "</div>";

    //Now use appendChild and add it to the list!
    document.getElementById("list").appendChild(li);
    document.getElementById("ingredientSearch").value = "";
    });

    //used event delegation
    $(document).on("click", ".btnDel", function(e) {
        var ingredient = $(this).parent().parent();
        ingredient.remove();
    });

});


//<li><div class="btn btn-success btn-sm">afdsgdhf<div style="margin-left: 10%" class="btnDel btn btn-danger btn-xs">x</div></div></li>
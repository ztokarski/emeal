"use strict";
$(function () {
    const ingredientContainer = $("#ingredients");
    const ingredientWarning = $("#ingredient-warning");
    ingredientWarning.hide();
    $("#add-ingredient-frame").click(event => {
        event.preventDefault();
        const frame = document.createElement("div");
        frame.innerText = "Loading...";
        ingredientContainer.append(frame);
        $(frame).load("/Ingredient/PartialIngredient", function (response, status) {
            if (status === "error") {
                ingredientWarning.text("You smart, you loyal... but an error occured! Try again.");
                ingredientWarning.show();
                $(this).remove();
            }
        });
    });
    ingredientContainer.on("click", ".delete-ingredient-frame", function (event) {
        event.preventDefault();
        $(this).parent().remove();
    });
});
//# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiSW5ncmVkaWVudEZyYW1lcy5qcyIsInNvdXJjZVJvb3QiOiIiLCJzb3VyY2VzIjpbIi4uL3NyYy9JbmdyZWRpZW50RnJhbWVzLnRzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiI7QUFBQSxDQUFDLENBQUM7SUFDRCxNQUFNLG1CQUFtQixHQUF3QixDQUFDLENBQUMsY0FBYyxDQUFDLENBQUM7SUFDbkUsTUFBTSxpQkFBaUIsR0FBd0IsQ0FBQyxDQUFDLHFCQUFxQixDQUFDLENBQUM7SUFDeEUsaUJBQWlCLENBQUMsSUFBSSxFQUFFLENBQUM7SUFFekIsQ0FBQyxDQUFDLHVCQUF1QixDQUFDLENBQUMsS0FBSyxDQUFDLEtBQUssQ0FBQyxFQUFFO1FBQ3hDLEtBQUssQ0FBQyxjQUFjLEVBQUUsQ0FBQztRQUV2QixNQUFNLEtBQUssR0FBZ0IsUUFBUSxDQUFDLGFBQWEsQ0FBQyxLQUFLLENBQUMsQ0FBQztRQUN6RCxLQUFLLENBQUMsU0FBUyxHQUFHLFlBQVksQ0FBQztRQUUvQixtQkFBbUIsQ0FBQyxNQUFNLENBQUMsS0FBSyxDQUFDLENBQUM7UUFDbEMsQ0FBQyxDQUFDLEtBQUssQ0FBQyxDQUFDLElBQUksQ0FBQywrQkFBK0IsRUFDNUMsVUFBVSxRQUFRLEVBQUUsTUFBTTtZQUN6QixFQUFFLENBQUMsQ0FBQyxNQUFNLEtBQUssT0FBTyxDQUFDLENBQUMsQ0FBQztnQkFDeEIsaUJBQWlCLENBQUMsSUFBSSxDQUFDLDBEQUEwRCxDQUFDLENBQUM7Z0JBQ25GLGlCQUFpQixDQUFDLElBQUksRUFBRSxDQUFDO2dCQUN6QixDQUFDLENBQUMsSUFBSSxDQUFDLENBQUMsTUFBTSxFQUFFLENBQUM7WUFDbEIsQ0FBQztRQUNGLENBQUMsQ0FBQyxDQUFDO0lBQ0wsQ0FBQyxDQUFDLENBQUM7SUFFSCxtQkFBbUIsQ0FBQyxFQUFFLENBQUMsT0FBTyxFQUFFLDBCQUEwQixFQUN6RCxVQUE2QixLQUFLO1FBQ2pDLEtBQUssQ0FBQyxjQUFjLEVBQUUsQ0FBQztRQUN2QixDQUFDLENBQUMsSUFBSSxDQUFDLENBQUMsTUFBTSxFQUFFLENBQUMsTUFBTSxFQUFFLENBQUM7SUFDM0IsQ0FBQyxDQUFDLENBQUM7QUFDTCxDQUFDLENBQUMsQ0FBQyIsInNvdXJjZXNDb250ZW50IjpbIiQoZnVuY3Rpb24gKCkge1xyXG5cdGNvbnN0IGluZ3JlZGllbnRDb250YWluZXI6IEpRdWVyeTxIVE1MRWxlbWVudD4gPSAkKFwiI2luZ3JlZGllbnRzXCIpO1xyXG5cdGNvbnN0IGluZ3JlZGllbnRXYXJuaW5nOiBKUXVlcnk8SFRNTEVsZW1lbnQ+ID0gJChcIiNpbmdyZWRpZW50LXdhcm5pbmdcIik7XHJcblx0aW5ncmVkaWVudFdhcm5pbmcuaGlkZSgpO1xyXG5cclxuXHQkKFwiI2FkZC1pbmdyZWRpZW50LWZyYW1lXCIpLmNsaWNrKGV2ZW50ID0+IHtcclxuXHRcdGV2ZW50LnByZXZlbnREZWZhdWx0KCk7XHJcblxyXG5cdFx0Y29uc3QgZnJhbWU6IEhUTUxFbGVtZW50ID0gZG9jdW1lbnQuY3JlYXRlRWxlbWVudChcImRpdlwiKTtcclxuXHRcdGZyYW1lLmlubmVyVGV4dCA9IFwiTG9hZGluZy4uLlwiO1xyXG5cclxuXHRcdGluZ3JlZGllbnRDb250YWluZXIuYXBwZW5kKGZyYW1lKTtcclxuXHRcdCQoZnJhbWUpLmxvYWQoXCIvSW5ncmVkaWVudC9QYXJ0aWFsSW5ncmVkaWVudFwiLFxyXG5cdFx0XHRmdW5jdGlvbiAocmVzcG9uc2UsIHN0YXR1cykge1xyXG5cdFx0XHRcdGlmIChzdGF0dXMgPT09IFwiZXJyb3JcIikge1xyXG5cdFx0XHRcdFx0aW5ncmVkaWVudFdhcm5pbmcudGV4dChcIllvdSBzbWFydCwgeW91IGxveWFsLi4uIGJ1dCBhbiBlcnJvciBvY2N1cmVkISBUcnkgYWdhaW4uXCIpO1xyXG5cdFx0XHRcdFx0aW5ncmVkaWVudFdhcm5pbmcuc2hvdygpO1xyXG5cdFx0XHRcdFx0JCh0aGlzKS5yZW1vdmUoKTtcclxuXHRcdFx0XHR9XHJcblx0XHRcdH0pO1xyXG5cdH0pO1xyXG5cclxuXHRpbmdyZWRpZW50Q29udGFpbmVyLm9uKFwiY2xpY2tcIiwgXCIuZGVsZXRlLWluZ3JlZGllbnQtZnJhbWVcIixcclxuXHRcdGZ1bmN0aW9uICh0aGlzOiBIVE1MRWxlbWVudCwgZXZlbnQpIHtcclxuXHRcdFx0ZXZlbnQucHJldmVudERlZmF1bHQoKTtcclxuXHRcdFx0JCh0aGlzKS5wYXJlbnQoKS5yZW1vdmUoKTtcclxuXHRcdH0pO1xyXG59KTsiXX0=
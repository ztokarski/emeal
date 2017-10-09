"use strict";
$(function () {
    var ingredientResults = $(".ingredient-search-result-container");
    $("#ingredient-search-input").select2({
        placeholder: "Enter your ingredients here...",
        tags: false
    });
    $("#my-allergies-input").select2({
        placeholder: "These products will be excluded from the search...",
        tags: false
    });
    $("#ingredient-search-form").submit(function (event) {
        event.preventDefault();
        $.ajax({
            url: this.action,
            type: "POST",
            data: $(this).serialize(),
            success: function (responseData) {
                ingredientResults.html(responseData);
            },
            error: () => {
                ingredientResults.html("<h3>An error occured. Please try again. :(</h3>");
            }
        });
    });
});
//# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiU2VhcmNoQnlJbmdyZWRpZW50LmpzIiwic291cmNlUm9vdCI6IiIsInNvdXJjZXMiOlsiLi4vc3JjL1NlYXJjaEJ5SW5ncmVkaWVudC50cyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiO0FBQUEsQ0FBQyxDQUFDO0lBQ0QsSUFBSSxpQkFBaUIsR0FBd0IsQ0FBQyxDQUFDLHFDQUFxQyxDQUFDLENBQUM7SUFFdEYsQ0FBQyxDQUFDLDBCQUEwQixDQUFDLENBQUMsT0FBTyxDQUFDO1FBQ3JDLFdBQVcsRUFBRSxnQ0FBZ0M7UUFDN0MsSUFBSSxFQUFFLEtBQUs7S0FDWCxDQUFDLENBQUM7SUFFSCxDQUFDLENBQUMscUJBQXFCLENBQUMsQ0FBQyxPQUFPLENBQUM7UUFDaEMsV0FBVyxFQUFFLG9EQUFvRDtRQUNqRSxJQUFJLEVBQUUsS0FBSztLQUNYLENBQUMsQ0FBQztJQUVILENBQUMsQ0FBQyx5QkFBeUIsQ0FBQyxDQUFDLE1BQU0sQ0FDbEMsVUFBcUMsS0FBc0M7UUFDMUUsS0FBSyxDQUFDLGNBQWMsRUFBRSxDQUFDO1FBRXZCLENBQUMsQ0FBQyxJQUFJLENBQUM7WUFDTixHQUFHLEVBQVEsSUFBSyxDQUFDLE1BQU07WUFDdkIsSUFBSSxFQUFFLE1BQU07WUFDWixJQUFJLEVBQUUsQ0FBQyxDQUFDLElBQUksQ0FBQyxDQUFDLFNBQVMsRUFBRTtZQUN6QixPQUFPLEVBQUUsVUFBVSxZQUFvQjtnQkFDdEMsaUJBQWlCLENBQUMsSUFBSSxDQUFDLFlBQVksQ0FBQyxDQUFDO1lBQ3RDLENBQUM7WUFDRCxLQUFLLEVBQUUsR0FBRyxFQUFFO2dCQUNYLGlCQUFpQixDQUFDLElBQUksQ0FBQyxpREFBaUQsQ0FBQyxDQUFDO1lBQzNFLENBQUM7U0FDRCxDQUFDLENBQUM7SUFDSixDQUFDLENBQUMsQ0FBQztBQUNMLENBQUMsQ0FBQyxDQUFDIiwic291cmNlc0NvbnRlbnQiOlsiJChmdW5jdGlvbiAoKTogdm9pZCB7XHJcblx0dmFyIGluZ3JlZGllbnRSZXN1bHRzOiBKUXVlcnk8SFRNTEVsZW1lbnQ+ID0gJChcIi5pbmdyZWRpZW50LXNlYXJjaC1yZXN1bHQtY29udGFpbmVyXCIpO1xyXG5cclxuXHQkKFwiI2luZ3JlZGllbnQtc2VhcmNoLWlucHV0XCIpLnNlbGVjdDIoe1xyXG5cdFx0cGxhY2Vob2xkZXI6IFwiRW50ZXIgeW91ciBpbmdyZWRpZW50cyBoZXJlLi4uXCIsXHJcblx0XHR0YWdzOiBmYWxzZVxyXG5cdH0pO1xyXG5cclxuXHQkKFwiI215LWFsbGVyZ2llcy1pbnB1dFwiKS5zZWxlY3QyKHtcclxuXHRcdHBsYWNlaG9sZGVyOiBcIlRoZXNlIHByb2R1Y3RzIHdpbGwgYmUgZXhjbHVkZWQgZnJvbSB0aGUgc2VhcmNoLi4uXCIsXHJcblx0XHR0YWdzOiBmYWxzZVxyXG5cdH0pO1xyXG5cclxuXHQkKFwiI2luZ3JlZGllbnQtc2VhcmNoLWZvcm1cIikuc3VibWl0KFxyXG5cdFx0ZnVuY3Rpb24gKHRoaXM6IEpRdWVyeTxIVE1MRWxlbWVudD4sIGV2ZW50OiBKUXVlcnkuRXZlbnQ8RXZlbnRUYXJnZXQsIG51bGw+KTogdm9pZCB7XHJcblx0XHRcdGV2ZW50LnByZXZlbnREZWZhdWx0KCk7XHJcblxyXG5cdFx0XHQkLmFqYXgoe1xyXG5cdFx0XHRcdHVybDogKDxhbnk+dGhpcykuYWN0aW9uLFxyXG5cdFx0XHRcdHR5cGU6IFwiUE9TVFwiLFxyXG5cdFx0XHRcdGRhdGE6ICQodGhpcykuc2VyaWFsaXplKCksXHJcblx0XHRcdFx0c3VjY2VzczogZnVuY3Rpb24gKHJlc3BvbnNlRGF0YTogc3RyaW5nKTogdm9pZCB7XHJcblx0XHRcdFx0XHRpbmdyZWRpZW50UmVzdWx0cy5odG1sKHJlc3BvbnNlRGF0YSk7XHJcblx0XHRcdFx0fSxcclxuXHRcdFx0XHRlcnJvcjogKCkgPT4ge1xyXG5cdFx0XHRcdFx0aW5ncmVkaWVudFJlc3VsdHMuaHRtbChcIjxoMz5BbiBlcnJvciBvY2N1cmVkLiBQbGVhc2UgdHJ5IGFnYWluLiA6KDwvaDM+XCIpO1xyXG5cdFx0XHRcdH1cclxuXHRcdFx0fSk7XHJcblx0XHR9KTtcclxufSk7Il19
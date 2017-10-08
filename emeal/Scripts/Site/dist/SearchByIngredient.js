"use strict";
$(function () {
    var ingredientResults = $("#ingredient-search-results");
    $("#ingredient-search-input").select2({
        placeholder: "Enter your ingredients here...",
        tags: false
    });
    $("#my-allergies-input").select2({
        placeholder: "This products will be excluded from the search...",
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
//# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiU2VhcmNoQnlJbmdyZWRpZW50LmpzIiwic291cmNlUm9vdCI6IiIsInNvdXJjZXMiOlsiLi4vc3JjL1NlYXJjaEJ5SW5ncmVkaWVudC50cyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiO0FBQUEsQ0FBQyxDQUFDO0lBQ0QsSUFBSSxpQkFBaUIsR0FBd0IsQ0FBQyxDQUFDLDRCQUE0QixDQUFDLENBQUM7SUFFN0UsQ0FBQyxDQUFDLDBCQUEwQixDQUFDLENBQUMsT0FBTyxDQUFDO1FBQ3JDLFdBQVcsRUFBRSxnQ0FBZ0M7UUFDN0MsSUFBSSxFQUFFLEtBQUs7S0FDWCxDQUFDLENBQUM7SUFFSCxDQUFDLENBQUMscUJBQXFCLENBQUMsQ0FBQyxPQUFPLENBQUM7UUFDaEMsV0FBVyxFQUFFLG1EQUFtRDtRQUNoRSxJQUFJLEVBQUUsS0FBSztLQUNYLENBQUMsQ0FBQztJQUVILENBQUMsQ0FBQyx5QkFBeUIsQ0FBQyxDQUFDLE1BQU0sQ0FDbEMsVUFBcUMsS0FBc0M7UUFDMUUsS0FBSyxDQUFDLGNBQWMsRUFBRSxDQUFDO1FBRXZCLENBQUMsQ0FBQyxJQUFJLENBQUM7WUFDTixHQUFHLEVBQVEsSUFBSyxDQUFDLE1BQU07WUFDdkIsSUFBSSxFQUFFLE1BQU07WUFDWixJQUFJLEVBQUUsQ0FBQyxDQUFDLElBQUksQ0FBQyxDQUFDLFNBQVMsRUFBRTtZQUN6QixPQUFPLEVBQUUsVUFBVSxZQUFvQjtnQkFDdEMsaUJBQWlCLENBQUMsSUFBSSxDQUFDLFlBQVksQ0FBQyxDQUFDO1lBQ3RDLENBQUM7WUFDRCxLQUFLLEVBQUUsR0FBRyxFQUFFO2dCQUNYLGlCQUFpQixDQUFDLElBQUksQ0FBQyxpREFBaUQsQ0FBQyxDQUFDO1lBQzNFLENBQUM7U0FDRCxDQUFDLENBQUM7SUFDSixDQUFDLENBQUMsQ0FBQztBQUNMLENBQUMsQ0FBQyxDQUFDIiwic291cmNlc0NvbnRlbnQiOlsiJChmdW5jdGlvbiAoKTogdm9pZCB7XHJcblx0dmFyIGluZ3JlZGllbnRSZXN1bHRzOiBKUXVlcnk8SFRNTEVsZW1lbnQ+ID0gJChcIiNpbmdyZWRpZW50LXNlYXJjaC1yZXN1bHRzXCIpO1xyXG5cclxuXHQkKFwiI2luZ3JlZGllbnQtc2VhcmNoLWlucHV0XCIpLnNlbGVjdDIoe1xyXG5cdFx0cGxhY2Vob2xkZXI6IFwiRW50ZXIgeW91ciBpbmdyZWRpZW50cyBoZXJlLi4uXCIsXHJcblx0XHR0YWdzOiBmYWxzZVxyXG5cdH0pO1xyXG5cclxuXHQkKFwiI215LWFsbGVyZ2llcy1pbnB1dFwiKS5zZWxlY3QyKHtcclxuXHRcdHBsYWNlaG9sZGVyOiBcIlRoaXMgcHJvZHVjdHMgd2lsbCBiZSBleGNsdWRlZCBmcm9tIHRoZSBzZWFyY2guLi5cIixcclxuXHRcdHRhZ3M6IGZhbHNlXHJcblx0fSk7XHJcblxyXG5cdCQoXCIjaW5ncmVkaWVudC1zZWFyY2gtZm9ybVwiKS5zdWJtaXQoXHJcblx0XHRmdW5jdGlvbiAodGhpczogSlF1ZXJ5PEhUTUxFbGVtZW50PiwgZXZlbnQ6IEpRdWVyeS5FdmVudDxFdmVudFRhcmdldCwgbnVsbD4pOiB2b2lkIHtcclxuXHRcdFx0ZXZlbnQucHJldmVudERlZmF1bHQoKTtcclxuXHJcblx0XHRcdCQuYWpheCh7XHJcblx0XHRcdFx0dXJsOiAoPGFueT50aGlzKS5hY3Rpb24sXHJcblx0XHRcdFx0dHlwZTogXCJQT1NUXCIsXHJcblx0XHRcdFx0ZGF0YTogJCh0aGlzKS5zZXJpYWxpemUoKSxcclxuXHRcdFx0XHRzdWNjZXNzOiBmdW5jdGlvbiAocmVzcG9uc2VEYXRhOiBzdHJpbmcpOiB2b2lkIHtcclxuXHRcdFx0XHRcdGluZ3JlZGllbnRSZXN1bHRzLmh0bWwocmVzcG9uc2VEYXRhKTtcclxuXHRcdFx0XHR9LFxyXG5cdFx0XHRcdGVycm9yOiAoKSA9PiB7XHJcblx0XHRcdFx0XHRpbmdyZWRpZW50UmVzdWx0cy5odG1sKFwiPGgzPkFuIGVycm9yIG9jY3VyZWQuIFBsZWFzZSB0cnkgYWdhaW4uIDooPC9oMz5cIik7XHJcblx0XHRcdFx0fVxyXG5cdFx0XHR9KTtcclxuXHRcdH0pO1xyXG59KTsiXX0=
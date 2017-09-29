"use strict";
$(() => {
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
});
//# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiU2VhcmNoQnlJbmdyZWRpZW50LmpzIiwic291cmNlUm9vdCI6IiIsInNvdXJjZXMiOlsiLi4vc3JjL1NlYXJjaEJ5SW5ncmVkaWVudC50cyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiO0FBQUEsQ0FBQyxDQUFDLEdBQUcsRUFBRTtJQUNILElBQUksaUJBQWlCLEdBQXdCLENBQUMsQ0FBQyw0QkFBNEIsQ0FBQyxDQUFDO0lBRTdFLENBQUMsQ0FBQywwQkFBMEIsQ0FBQyxDQUFDLE9BQU8sQ0FBQztRQUNsQyxXQUFXLEVBQUUsZ0NBQWdDO1FBQzdDLElBQUksRUFBRSxLQUFLO0tBQ2QsQ0FBQyxDQUFDO0lBRUgsQ0FBQyxDQUFDLHFCQUFxQixDQUFDLENBQUMsT0FBTyxDQUFDO1FBQzdCLFdBQVcsRUFBRSxtREFBbUQ7UUFDaEUsSUFBSSxFQUFFLEtBQUs7S0FDZCxDQUFDLENBQUM7SUFFSCxDQUFDLENBQUMseUJBQXlCLENBQUMsQ0FBQyxNQUFNLENBQUMsVUFBb0MsS0FBc0M7UUFDMUcsS0FBSyxDQUFDLGNBQWMsRUFBRSxDQUFDO1FBQ3ZCLENBQUMsQ0FBQyx5QkFBeUIsQ0FBQyxDQUFDLE1BQU0sQ0FDL0IsVUFBb0MsS0FBc0M7WUFDdEUsS0FBSyxDQUFDLGNBQWMsRUFBRSxDQUFDO1lBRXZCLENBQUMsQ0FBQyxJQUFJLENBQUM7Z0JBQ0gsR0FBRyxFQUFRLElBQUssQ0FBQyxNQUFNO2dCQUN2QixJQUFJLEVBQUUsTUFBTTtnQkFDWixJQUFJLEVBQUUsQ0FBQyxDQUFDLElBQUksQ0FBQyxDQUFDLFNBQVMsRUFBRTtnQkFDekIsT0FBTyxFQUFFLFVBQVMsWUFBb0I7b0JBQ2xDLGlCQUFpQixDQUFDLElBQUksQ0FBQyxZQUFZLENBQUMsQ0FBQztnQkFDekMsQ0FBQztnQkFDRCxLQUFLLEVBQUUsR0FBRyxFQUFFO29CQUNSLGlCQUFpQixDQUFDLElBQUksQ0FBQyxpREFBaUQsQ0FBQyxDQUFDO2dCQUM5RSxDQUFDO2FBQ0osQ0FBQyxDQUFDO1FBQ1AsQ0FBQyxDQUFDLENBQUM7SUFDWCxDQUFDLENBQUMsQ0FBQztBQUNQLENBQUMsQ0FBQyxDQUFDIiwic291cmNlc0NvbnRlbnQiOlsiJCgoKSA9PiB7XHJcbiAgICB2YXIgaW5ncmVkaWVudFJlc3VsdHM6IEpRdWVyeTxIVE1MRWxlbWVudD4gPSAkKFwiI2luZ3JlZGllbnQtc2VhcmNoLXJlc3VsdHNcIik7XHJcblxyXG4gICAgJChcIiNpbmdyZWRpZW50LXNlYXJjaC1pbnB1dFwiKS5zZWxlY3QyKHtcclxuICAgICAgICBwbGFjZWhvbGRlcjogXCJFbnRlciB5b3VyIGluZ3JlZGllbnRzIGhlcmUuLi5cIixcclxuICAgICAgICB0YWdzOiBmYWxzZVxyXG4gICAgfSk7XHJcblxyXG4gICAgJChcIiNteS1hbGxlcmdpZXMtaW5wdXRcIikuc2VsZWN0Mih7XHJcbiAgICAgICAgcGxhY2Vob2xkZXI6IFwiVGhpcyBwcm9kdWN0cyB3aWxsIGJlIGV4Y2x1ZGVkIGZyb20gdGhlIHNlYXJjaC4uLlwiLFxyXG4gICAgICAgIHRhZ3M6IGZhbHNlXHJcbiAgICB9KTtcclxuXHJcbiAgICAkKFwiI2luZ3JlZGllbnQtc2VhcmNoLWZvcm1cIikuc3VibWl0KGZ1bmN0aW9uKHRoaXM6IEpRdWVyeTxIVE1MRWxlbWVudD4sIGV2ZW50OiBKUXVlcnkuRXZlbnQ8RXZlbnRUYXJnZXQsIG51bGw+KSB7XHJcbiAgICAgICAgZXZlbnQucHJldmVudERlZmF1bHQoKTtcclxuICAgICAgICAkKFwiI2luZ3JlZGllbnQtc2VhcmNoLWZvcm1cIikuc3VibWl0KFxyXG4gICAgICAgICAgICBmdW5jdGlvbih0aGlzOiBKUXVlcnk8SFRNTEVsZW1lbnQ+LCBldmVudDogSlF1ZXJ5LkV2ZW50PEV2ZW50VGFyZ2V0LCBudWxsPikge1xyXG4gICAgICAgICAgICAgICAgZXZlbnQucHJldmVudERlZmF1bHQoKTtcclxuXHJcbiAgICAgICAgICAgICAgICAkLmFqYXgoe1xyXG4gICAgICAgICAgICAgICAgICAgIHVybDogKDxhbnk+dGhpcykuYWN0aW9uLFxyXG4gICAgICAgICAgICAgICAgICAgIHR5cGU6IFwiUE9TVFwiLFxyXG4gICAgICAgICAgICAgICAgICAgIGRhdGE6ICQodGhpcykuc2VyaWFsaXplKCksXHJcbiAgICAgICAgICAgICAgICAgICAgc3VjY2VzczogZnVuY3Rpb24ocmVzcG9uc2VEYXRhOiBzdHJpbmcpIHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgaW5ncmVkaWVudFJlc3VsdHMuaHRtbChyZXNwb25zZURhdGEpO1xyXG4gICAgICAgICAgICAgICAgICAgIH0sXHJcbiAgICAgICAgICAgICAgICAgICAgZXJyb3I6ICgpID0+IHtcclxuICAgICAgICAgICAgICAgICAgICAgICAgaW5ncmVkaWVudFJlc3VsdHMuaHRtbChcIjxoMz5BbiBlcnJvciBvY2N1cmVkLiBQbGVhc2UgdHJ5IGFnYWluLiA6KDwvaDM+XCIpO1xyXG4gICAgICAgICAgICAgICAgICAgIH1cclxuICAgICAgICAgICAgICAgIH0pO1xyXG4gICAgICAgICAgICB9KTtcclxuICAgIH0pO1xyXG59KTsiXX0=
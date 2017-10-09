$(function (): void {
    let triggerButton: JQuery<HTMLElement> = $(".dropdown-trigger button");

    triggerButton.click(function (): void {
        if (this.parentElement !== null &&
            this.parentElement.parentElement !== null) {
            this.parentElement.parentElement.classList.toggle("is-active");
        }
    });
});

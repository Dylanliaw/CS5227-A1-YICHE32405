// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Function to show the notification message
function showCartNotification() {
    var notification = document.getElementById("cart-notification");

    // Show the notification
    notification.style.display = "block";

    // Hide the notification after a delay
    setTimeout(function () {
        notification.style.display = "none";
    }, 3000); // 3000 milliseconds = 3 seconds
}

// Attach event listeners to all "Add to Cart" buttons
var addToCartButtons = document.querySelectorAll(".btn-success");
addToCartButtons.forEach(function (button) {
    button.addEventListener("click", showCartNotification);
});

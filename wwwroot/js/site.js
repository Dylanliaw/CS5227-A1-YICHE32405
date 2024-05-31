// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//google map
function initMap() {
    var storeLocation = { lat: YOUR_LATITUDE, lng: YOUR_LONGITUDE };
    var map = new google.maps.Map(document.getElementById('map'), {
        zoom: 14,
        center: storeLocation
    });
    var marker = new google.maps.Marker({
        position: storeLocation,
        map: map
    });

    // Check if the temp message div is present
    document.addEventListener('DOMContentLoaded', (event) => {
        const tempMessageDiv = document.getElementById('tempMessage');
        if (tempMessageDiv) {
            // Keep the message visible for 20 seconds (20000 milliseconds)
            setTimeout(() => {
                tempMessageDiv.style.display = 'none';
            }, 20000);
        }
    });
}



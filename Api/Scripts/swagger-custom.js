
window.onload = function () {
    var logoSpan = document.querySelector('.swagger-ui-wrap .logo__title');
    if (logoSpan) {
        logoSpan.textContent = "Owe Way!";
    } else {
        console.warn("Logo span not found.");
    }

    var logoLink = document.querySelector('.swagger-ui-wrap a');
    if (logoLink) {
        logoLink.href = window.location.origin; // Dynamically set the base URL
        logoLink.target = "_blank";
    } else {
        console.warn("Logo link not found.");
    }
};
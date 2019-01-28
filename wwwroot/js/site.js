// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// background fade in for gradients
$(document).scroll(function() {
    let alpha = ($(this).scrollTop() / 100);
    $('#transparent-header .rotated-background').css({background: `linear-gradient(160deg, rgba(40,163,95, ${alpha}) 0%, rgba(92,176,57, ${alpha}) 25%, rgba(146,187,32, ${alpha}) 50%,rgba(200,186,0, ${alpha}) 75%, rgba(255,200,0, ${alpha}) 100%)`})
});

// Markdown Converter
var converter = new showdown.Converter();

$(document).ready(function() {
    $('#md-content').html(converter.makeHtml($('#md-content').text()));
})
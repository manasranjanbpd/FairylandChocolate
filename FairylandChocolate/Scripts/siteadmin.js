﻿$(document).ready(function () {
    $('.preloader-background').fadeOut();
    $(".button-collapse").sideNav();
    $('ul.tabs').tabs();
    $('.modal').modal();
    $('select').material_select();    
    $('.dropdown-button').dropdown({
        inDuration: 300,
        outDuration: 225,
        constrainWidth: false, // Does not change width of dropdown to that of the activator
        hover: false, // Activate on hover
        gutter: 0, // Spacing from edge
        belowOrigin: true, // Displays dropdown below the button
        alignment: 'left', // Displays dropdown with edge aligned to the left of button
        stopPropagation: false // Stops event propagation
    });

    angular.element(function () {
        angular.bootstrap(document, ['AdminApp']);
    });
});


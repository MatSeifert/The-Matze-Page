/**
 * This will be validated serverside again
 */

const validationType = {
    NAME: 'name',
    MAIL: 'mail',
    TEXT: 'text'
}

function validate(type, content) {
    if (!type) {
        return;
    }

    switch(type) {
        case validationType.NAME:
            let result = content.length >= 2 ? true : false;
            return result;
        break;

        case validationType.TEXT:
            return null;
        break;

        case validationType.MAIL: return null;
        break;
    }
}

function handleStyles(field, validationType) {
    if (!$(`#${field}`).val().length) {
        // Reset to default for emtpy inputs
        removeClasses(field);
        return;
    }

    if (validate(validationType, $(`#${field}`).val())) {
        $(`#${field}`).addClass('valid');
        $(`#${field}-validation-info`).addClass('valid');
    } else {
        $(`#${field}`).addClass('invalid');
        $(`#${field}-validation-info`).addClass('invalid');
    }
}

function removeClasses(field) {
    $(`#${field}`).removeClass('invalid');
    $(`#${field}-validation-info`).removeClass('invalid');
    $(`#${field}`).removeClass('valid');
    $(`#${field}-validation-info`).removeClass('valid');
}

// Listen to changes
$('#firstName').blur(function() {handleStyles('firstName', validationType.NAME);})
$('#lastName').blur(function() {handleStyles('lastName', validationType.NAME);})
$('#email').blur(function() {handleStyles('email', validationType.NAME);})
$('#subject').blur(function() {handleStyles('subject', validationType.NAME);})
$('#message').blur(function() {handleStyles('message', validationType.NAME);})

// Reset Styles onFocus
$('#firstName').focus(function() {removeClasses('firstName');})
$('#lastName').focus(function() {removeClasses('lastName');})
$('#email').focus(function() {removeClasses('email');})
$('#subject').focus(function() {removeClasses('subject');})
$('#message').focus(function() {removeClasses('message');})
/**
 * This will be validated serverside again
 */

const validationType = {
    NAME: 'name',
    MAIL: 'mail',
    TEXT: 'text'
}

var state = {
    firstname: false,
    lastName: false,
    email: false,
    subject: false,
    message: false,
    privacy: false
}

function invokeButtonUpdate() {
    // remove previous class
    $('#submit').removeClass();

    switch(submitButtonLevel) {
        case 1:
            $('#submit').addClass('btn submit-button_17p');
            break;
        case 2: 
            $('#submit').addClass('btn submit-button_33p');
            break;
        case 3: 
            $('#submit').addClass('btn submit-button_50p');
            break;
        case 4: 
            $('#submit').addClass('btn submit-button_67p');
            break;
        case 5: 
            $('#submit').addClass('btn submit-button_83p');
            break;
        case 6: 
            $('#submit').addClass('btn enabled');
            break;
        default: 
            $('#submit').addClass('btn disabled');
            break;
    }
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

        case validationType.MAIL: 
            return null;
            break;
    }
}

function handleStyles(field, validationType) {
    if (!$(`#${field}`).val().length) {
        // Reset to default for emtpy inputs
        removeClasses(field);
        // Change Button Style
        if (submitButtonLevel > 0) {
            submitButtonLevel--;
        }
        invokeButtonUpdate();

        return;
    }

    if (validate(validationType, $(`#${field}`).val())) {
        $(`#${field}`).addClass('valid');
        $(`#${field}-validation-info`).addClass('valid');
        // Change Button Style
        if (submitButtonLevel < 5) {
            submitButtonLevel++;
        }
        invokeButtonUpdate();        
    } else {
        $(`#${field}`).addClass('invalid');
        $(`#${field}-validation-info`).addClass('invalid');
        // Change Button Style
        if (submitButtonLevel > 0) {
            submitButtonLevel--;
        }
        invokeButtonUpdate();
    }

    invokeButtonUpdate();
}

function removeClasses(field) {
    // TODO: Optimize with parameterless call
    $(`#${field}`).removeClass('invalid');
    $(`#${field}-validation-info`).removeClass('invalid');
    $(`#${field}`).removeClass('valid');
    $(`#${field}-validation-info`).removeClass('valid');
    invokeButtonUpdate();
}

// TODO: Invoke submit button default state
invokeButtonUpdate();

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
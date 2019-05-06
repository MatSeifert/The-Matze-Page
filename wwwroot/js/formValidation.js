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

// Listen to changes on FirstName Field
$('#firstName').blur(function() {
    if (validate(validationType.NAME, $('#firstName').val())) {
        $('#firstName').addClass('valid');
        $('#firstName-wrapper').addClass('valid');
    } else {
        $('#firstName').addClass('invalid');
        $('#firstName-wrapper').addClass('invalid');
    }
})
// Reset FirstName Styles
$('#firstName').focus(function() {
    $('#firstName').removeClass('invalid');
    $('#firstName-wrapper').removeClass('invalid');
    $('#firstName').removeClass('valid');
    $('#firstName-wrapper').removeClass('valid');
})
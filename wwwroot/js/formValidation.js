const colors = ['#28A35F', '#70B42F', '#C8C400', '#efefef']
const valTypes = {NAME: 'name', MAIL: 'mail', TEXT: 'text'}

// Default state
var state = {
    firstName: false,
    lastName: false,
    email: false,
    subject: false,
    message: false,
    privacy: false
}

function setState(key, value) {
    state[key] = value
    setButtonLevel()
}

function setButtonLevel() {
    let validationLevel = 0

    for (let field in state) {
        state[field] ? validationLevel++ : null
    }

    setGradient((validationLevel / Object.keys(state).length) * 100)
}

function setGradient(maxLevel) {
    if (maxLevel == 0) {
        $('#submit').removeAttr("style").addClass('disabled')
        return
    }

    $('#submit').removeClass('disabled').css({
        background: `linear-gradient(90deg, ${colors[0]} 0%, ${colors[1]} ${maxLevel/2}%, ${colors[2]} ${maxLevel}%, ${colors[3]} ${maxLevel}%)`
    })
}

function setFieldStyles(fieldName, isValid) {
    if (isValid) {
        $(`#${fieldName}`).removeClass().addClass('valid')
        $(`#${fieldName}-validation-info`).removeClass().addClass('validation-info valid')
    } else {
        $(`#${fieldName}`).removeClass().addClass('invalid')
        $(`#${fieldName}-validation-info`).removeClass().addClass('validation-info invalid')
    }
}

function resetFieldStyles(fieldName) {
    $(`#${fieldName}`).removeClass()
    $(`#${fieldName}-validation-info`).removeClass()
}

function validate(validationType, fieldName) {
    let validationResult = true

    switch(validationType) {
        case valTypes.NAME:
            validationResult = $(`#${fieldName}`).val().length != 0 ? true : false
            break
        case valTypes.MAIL:
            let re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
            validationResult = re.test($(`#${fieldName}`).val().toLowerCase())
            break
        case valTypes.TEXT:
            validationResult = $(`#${fieldName}`).val().length > 3 ? true : false
            break
    }

    if ($(`#${fieldName}`).val().length == 0) {
        resetFieldStyles(fieldName)
    } else {
        setFieldStyles(fieldName, validationResult)
    }

    setState(fieldName, validationResult)
}

// Listen to changes
$('#firstName').blur(function() {validate(valTypes.NAME, 'firstName')})
$('#lastName').blur(function() {validate(valTypes.NAME, 'lastName')})
$('#email').blur(function() {validate(valTypes.MAIL, 'email')})
$('#subject').blur(function() {validate(valTypes.TEXT, 'subject')})
$('#message').blur(function() {validate(valTypes.TEXT, 'message')})
$('#privacy').change(function() {
    setState('privacy', $(this).is(':checked'))
})

// Handle reset button
$('#reset').click(function() {
    state = {
        firstName: false,
        lastName: false,
        email: false,
        subject: false,
        message: false,
        privacy: false
    }

    for (let field in state) {
        resetFieldStyles(field)
    }

    setButtonLevel()
})

setButtonLevel()
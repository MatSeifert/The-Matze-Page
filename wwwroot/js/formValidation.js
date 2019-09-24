const colors = ['#28A35F', '#70B42F', '#C8C400', '#efefef']
const valTypes = {NAME: 'name', MAIL: 'mail', TEXT: 'text'}

// Default state
var state = {
    FirstName: false,
    LastName: false,
    Email: false,
    Subject: false,
    Message: false,
    Privacy: false
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
    let submit = document.querySelector('#submit')

    submit.type = maxLevel == 100 ? 'submit' : 'button'

    if (maxLevel == 0) {
        submit.removeAttribute("style")
        submit.classList.add('disabled')
        return
    }

    submit.classList.remove('disabled')
    submit.setAttribute('style', `background: linear-gradient(90deg, ${colors[0]} 0%, ${colors[1]} ${maxLevel/2}%, ${colors[2]} ${maxLevel}%, ${colors[3]} ${maxLevel}%)`)
}

function setFieldStyles(fieldName, isValid) {
    if (isValid) {
        document.querySelector(`#${fieldName}`).classList.remove('invalid')
        document.querySelector(`#${fieldName}`).classList.add('valid')
        document.querySelector(`#${fieldName}-validation-info`).classList.remove('invalid')
        document.querySelector(`#${fieldName}-validation-info`).classList.add('valid')
    } else {
        document.querySelector(`#${fieldName}`).classList.remove('valid')
        document.querySelector(`#${fieldName}`).classList.add('invalid')
        document.querySelector(`#${fieldName}-validation-info`).classList.remove('valid')
        document.querySelector(`#${fieldName}-validation-info`).classList.add('invalid')
    }
}

function resetFieldStyles(fieldName) {
    document.querySelector(`#${fieldName}`).classList.remove('valid', 'invalid')
    document.querySelector(`#${fieldName}-validation-info`).classList.remove('valid', 'invalid')
}

function validate(validationType, fieldName) {
    let validationResult = true

    switch(validationType) {
        case valTypes.NAME:
            validationResult = document.querySelector(`#${fieldName}`).value.length != 0 ? true : false
            break
        case valTypes.MAIL:
            let re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
            validationResult = re.test(document.querySelector(`#${fieldName}`).value.toLowerCase())
            break
        case valTypes.TEXT:
            validationResult = document.querySelector(`#${fieldName}`).value.length > 3 ? true : false
            break
    }

    if (document.querySelector(`#${fieldName}`).value.length == 0) {
        resetFieldStyles(fieldName)
    } else {
        setFieldStyles(fieldName, validationResult)
    }

    setState(fieldName, validationResult)
}

// Listen to changes
document.querySelector('#FirstName').addEventListener('blur', () => {validate(valTypes.NAME, 'FirstName')})
document.querySelector('#LastName').addEventListener('blur', () => {validate(valTypes.NAME, 'LastName')})
document.querySelector('#Email').addEventListener('blur', () => {validate(valTypes.MAIL, 'Email')})
document.querySelector('#Subject').addEventListener('blur', () => {validate(valTypes.TEXT, 'Subject')})
document.querySelector('#Message').addEventListener('blur', () => {validate(valTypes.TEXT, 'Message')})
document.querySelector('#Privacy').addEventListener('change', (event) => {
    setState('Privacy', event.target.checked)
})

// Handle reset button
document.querySelector('#reset').addEventListener('click', () => {
    state = {
        FirstName: false,
        LastName: false,
        Email: false,
        Subject: false,
        Message: false,
        Privacy: false
    }

    for (let field in state) {
        resetFieldStyles(field)
    }

    setButtonLevel()
})

setButtonLevel()
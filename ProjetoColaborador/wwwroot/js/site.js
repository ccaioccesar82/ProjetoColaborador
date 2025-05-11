const formCreate = document.getElementById("myform-create");

const spanValidation = document.getElementById("span-validation-create");
const emailRegex = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$/;

const campos = document.querySelectorAll(".formCreate");

const formEdit = document.getElementById("myform-edit")

const camposEdit = document.querySelectorAll(".inputEdit")

const spanEdit = document.getElementById("span-validation-edit");

const emailInput = document.getElementById("email-input");

const emailSpan = document.getElementById("emailSpan");



formCreate.addEventListener("submit", function (e) {

    e.preventDefault();


    while (fieldIsEmpty(campos, spanValidation) == false || validateEmail(emailInput, emailSpan) == false)
    {
        return;
    }

    e.target.submit();

});




function validateEmail(email, spanBox) {

    if (!emailRegex.test(email.value)) {

        spanBox.style.display = "block";

        return false

    }
    else {


        spanBox.style.display = "none";
        return true;
    }

}


function fieldIsEmpty(camposParameter, spanBox) {

    if (camposParameter[0].value.length == 0 || camposParameter[1].value.length == 0 || camposParameter[2].value.length == 0) {

        spanBox.style.display = "block"
        return false;

    } else {

        spanBox.style.display = "none"
        return true;
    }

}






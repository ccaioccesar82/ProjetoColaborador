const formCreate = document.getElementById("myform-create");

const spanValidation = document.getElementById("span-validation-create");
const emailRegex = /^[\w\-\.]+@([\w-]+\.)+[\w-]{2,}$/gm;

const campos = document.querySelectorAll(".formCreate");

const formEdit = document.querySelectorAll(".myform-edit")

const camposEdit = document.querySelectorAll(".inputEdit")

const spanEdit = document.getElementById("span-validation-edit");

const emailInput = document.getElementById("email-input");

const emailSpan = document.getElementById("emailSpan");


formCreate.addEventListener("submit", function (e) {

    e.preventDefault();

    if (campos[0].value.length == 0 || campos[1].value.length == 0 || campos[2].value.length == 0) {

        spanValidation.style.display = "block";

        return;

    }

    if (!emailRegex.test(emailInput.value)) {

        emailSpan.style.display = "block";
        return;
    }

    else {

        spanValidation.style.display = "none"

    }

    e.target.submit();


});
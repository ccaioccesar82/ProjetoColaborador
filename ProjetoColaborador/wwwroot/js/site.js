
const modal = document.getElementById("caixa-modal");

function openModal()
{
    modal.showModal()    
}


const modalEdit = document.getElementById("caixa-modal-edit")

function openModalEdit(){

    modalEdit.showModal()
}

const form = document.getElementById("form-create");
const campos = document.querySelectorAll(".required");
const span = document.getElementById("span-create");
const emailRegex = /^[\w\-\.]+@([\w-]+\.)+[\w-]{2,}$/gm;
const submit = document.getElementById("form-create");
const submitEdit = document.getElementById("form-edit")
const camposEdit = document.querySelectorAll(".edits")

const spanEdit = document.getElementById("span-edit")




submit.addEventListener("submit", fieldsIsEmpty);

function fieldsIsEmpty(e) {

    e.preventDefault();

    if (campos[0].value.length == 0 || campos[1].value.length == 0 || campos[2].value.length == 0) {

        span.style.display = "block";

        return;

    } else {

        span.style.display = "none"

    }

    e.target.submit();
}


submitEdit.addEventListener('submit', fieldsIsEmptyEdit)


function fieldsIsEmptyEdit(e) {

    e.preventDefault();

    if (camposEdit[0].value.length == 0 || camposEdit[1].value.length == 0 || camposEdit[2].value.length == 0 || camposEdit[3].value.length == 0) {

        spanEdit.style.display = "block";

        return;

    } else {

        span.style.display = "none"
        span.style.display = "none"

    }

    e.target.submit();
}


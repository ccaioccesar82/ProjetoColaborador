

const searchInput = document.getElementById("search-input");
const colaboradores = document.querySelectorAll(".colabs")



searchInput.addEventListener('input', filterColabs);


function filterColabs() {

    if (searchInput.value != '') {

        for (let colaborador of colaboradores) {

            let result = colaborador.textContent.toLowerCase();

            let filterText = searchInput.value.toLowerCase()

            if (!result.includes(filterText)) {

                colaborador.style.display = "none";

            } else {

                colaborador.style.display = "";

            }

        }

    } else {

        for (let colaborador of colaboradores) {

            colaborador.style.display= ""

        }

    }

 }
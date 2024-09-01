let botonPresionado = false;
const unlistedList = document.getElementById("lista");
function agregar() {
    let numElemento = unlistedList.childElementCount; 
    const nuevo = document.createElement('li');
    nuevo.textContent = "Elemento" + (numElemento + 1);
    unlistedList.appendChild(nuevo);
}

function cambiarFondo() {
    if (!botonPresionado) {
        document.body.style.backgroundColor = "grey";
        botonPresionado = true;
    } else {
        document.body.style.backgroundColor = "white";
        botonPresionado = false;
    }
}

function borrar() {
    if (unlistedList.hasChildNodes()) {
        unlistedList.removeChild(unlistedList.lastElementChild);
    }
}
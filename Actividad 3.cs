Código búsqueda binario

let vector = [8, 10, 15, 25, 30];

let buscado = parseInt(prompt("Ingrese el número que desea buscar:"));

let inicio = 0;
let fin = 4;
let encontrado = false;

while (inicio <= fin) {

    let medio = Math.floor((inicio + fin) / 2);

    if (vector[medio] == buscado) {
        console.log("Número encontrado en la posición: " + medio);
        encontrado = true;
        break;
    }

    if (buscado > vector[medio]) {
        inicio = medio + 1;
    } else {
        fin = medio - 1;
    }
}

if (encontrado == false) {
    console.log("Número no encontrado");
}

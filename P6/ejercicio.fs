//funcion para sumar a y b
function sumar(a, b) {
    return a + b;
}
//funcion para restar a y b
function restar(a, b) {
    return a - b;
}
//funcion para multiplicar a y b
function multiplicar(a, b) {
    return a * b;
}
//funcion para dividir a y b
function dividir(a, b) {
    return a / b;
}
// metodo main
function main() {
    var a = parseInt(readline());
    var b = parseInt(readline());
    var operacion = readline();
    if (operacion == "sumar") {
        print(sumar(a, b));
    }
    else if (operacion == "restar") {
        print(restar(a, b));
    }
    else if (operacion == "multiplicar") {
        print(multiplicar(a, b));
    }
    else if (operacion == "dividir") {
        print(dividir(a, b));
    }
}
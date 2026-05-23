using System;

Console.WriteLine("--- EL DEMONIO DE LA MEMORIA: VALOR VS REFERENCIA ---");

// 1. Tipo por Valor (Value Type - vive en el Stack)
int numeroInicial = 10;
Console.WriteLine($"\n[Stack] Número ANTES de la función: {numeroInicial}");
CambiarValor(numeroInicial);
Console.WriteLine($"[Stack] Número DESPUÉS de la función: {numeroInicial}"); 
// ¡Verás que NO cambió, sigue siendo 10!

// 2. Tipo por Referencia (Reference Type - vive en el Heap)
int[] miArreglo = { 1, 2, 3 };
Console.WriteLine($"\n[Heap] Primer elemento del arreglo ANTES: {miArreglo[0]}");
CambiarReferencia(miArreglo);
Console.WriteLine($"[Heap] Primer elemento del arreglo DESPUÉS: {miArreglo[0]}"); 
// ¡Verás que SÍ cambió a 100!


// ==========================================
// FUNCIONES (Métodos)
// ==========================================

// Intenta cambiar un tipo por valor (int)
void CambiarValor(int x)
{
    x = 100;
    Console.WriteLine($"   -> (Dentro de CambiarValor, x es: {x})");
}

// Intenta cambiar un tipo por referencia (arreglo)
void CambiarReferencia(int[] arr)
{
    arr[0] = 100;
    Console.WriteLine($"   -> (Dentro de CambiarReferencia, el arreglo[0] es: {arr[0]})");

}
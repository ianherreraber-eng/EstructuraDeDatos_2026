using System;

// ==========================================
// FLUJO PRINCIPAL DEL PROGRAMA
// ==========================================

// 1. Instanciamos el objeto usando nuestra Clase
Poligono miFigura = new Poligono();

// 2. Ejecutamos la primera función y guardamos el resultado
miFigura.NumeroLados = SeleccionarPoligono();

if (miFigura.NumeroLados > 0)
{
    // 3. Pasamos nuestro objeto a la función para que se llene con datos validados
    PedirDatos(miFigura);

    // 4. Calculamos y mostramos el resultado final
    Console.WriteLine($"\nEl área de tu figura es: {miFigura.CalcularArea()}");
}
else
{
    Console.WriteLine("\nOpción no válida. Por favor, reinicia el programa.");
}


// ==========================================
// FUNCIONES INDEPENDIENTES
// ==========================================

int SeleccionarPoligono()
{
    Console.WriteLine("--- CALCULADORA DE POLÍGONOS ---");
    Console.WriteLine("1. Pentágono (5 lados)");
    Console.WriteLine("2. Hexágono (6 lados)");
    Console.Write("Elige una opción: ");
    
    string opcion = Console.ReadLine();
    
    if (opcion == "1") return 5;
    if (opcion == "2") return 6;
    
    return 0; // Retorna 0 si el usuario teclea algo incorrecto
}

void PedirDatos(Poligono figura)
{
    double lado;
    // Ciclo que se repite si no es un número decimal válido o si es negativo/cero
    do {
        Console.Write("\nIngresa la medida del lado (número positivo): ");
    } while (!double.TryParse(Console.ReadLine(), out lado) || lado <= 0);
    
    figura.MedidaLado = lado;

    double apotema;
    do {
        Console.Write("Ingresa la medida de la apotema (número positivo): ");
    } while (!double.TryParse(Console.ReadLine(), out apotema) || apotema <= 0);
    
    figura.Apotema = apotema;
}


// ==========================================
// DEFINICIÓN DE CLASES
// ==========================================

class Poligono 
{
    // Atributos de nuestro molde (encapsulamiento)
    public int NumeroLados { get; set; }
    public double MedidaLado { get; set; }
    public double Apotema { get; set; }

    // Función integrada en el objeto
    public double CalcularArea() 
    {
        double perimetro = NumeroLados * MedidaLado;
        return (perimetro * Apotema) / 2;
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        // Variables de entrada
        double montoPedido;
        string ciudadDestino;
        string tipoCliente;
        int cantidadItems;

        // Variables de salida
        string categoriaDespacho;
        double costoEnvio = 0;

        // Entrada de datos
        Console.WriteLine("Ingrese el monto del pedido:");
        montoPedido = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la ciudad destino:");
        ciudadDestino = Console.ReadLine().ToLower();

        Console.WriteLine("Ingrese el tipo de cliente (nuevo/recurrente):");
        tipoCliente = Console.ReadLine().ToLower();

        Console.WriteLine("Ingrese la cantidad de ítems:");
        cantidadItems = Convert.ToInt32(Console.ReadLine());

        // Lógica de clasificación
        if (montoPedido >= 150000 && tipoCliente == "recurrente")
        {
            categoriaDespacho = "Envío Gratis";
            costoEnvio = 0;
        }
        else if (cantidadItems >= 5 || montoPedido >= 300000)
        {
            categoriaDespacho = "Envío Express";
            costoEnvio = 20000;
        }
        else
        {
            categoriaDespacho = "Envío Estándar";
            costoEnvio = 10000;
        }

        // Costo adicional si es exterior
        if (ciudadDestino == "exterior")
        {
            costoEnvio += 15000;
        }

        // Salida con contexto
        Console.WriteLine("\n--- Resultado del Pedido ---");
        Console.WriteLine("Categoría de despacho: " + categoriaDespacho);
        Console.WriteLine("Costo total de envío: $" + costoEnvio);
        Console.WriteLine("Gracias por su compra. Su pedido será procesado pronto.");
    }
}
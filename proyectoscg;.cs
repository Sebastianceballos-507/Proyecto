using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<double> costosEnvio = new List<double>();
        string opcion;

        do
        {
            Console.WriteLine("\n--- REGISTRO DE PEDIDO ---");

            double montoPedido;
            int cantidadItems;
            string ciudadDestino;
            string tipoCliente;

            // VALIDACIÓN MONTO
            while (true)
            {
                Console.Write("Ingrese el monto del pedido: ");
                if (double.TryParse(Console.ReadLine(), out montoPedido) && montoPedido > 0)
                    break;
                Console.WriteLine("❌ Valor inválido. Debe ser un número positivo.");
            }

            // VALIDACIÓN CIUDAD
            while (true)
            {
                Console.Write("Ingrese la ciudad destino (local/exterior): ");
                ciudadDestino = Console.ReadLine().ToLower();

                if (ciudadDestino == "local" || ciudadDestino == "exterior")
                    break;

                Console.WriteLine("❌ Solo se permite 'local' o 'exterior'.");
            }

            // VALIDACIÓN CLIENTE
            while (true)
            {
                Console.Write("Ingrese el tipo de cliente (nuevo/recurrente): ");
                tipoCliente = Console.ReadLine().ToLower();

                if (tipoCliente == "nuevo" || tipoCliente == "recurrente")
                    break;

                Console.WriteLine("❌ Solo se permite 'nuevo' o 'recurrente'.");
            }

            // VALIDACIÓN ITEMS
            while (true)
            {
                Console.Write("Ingrese la cantidad de ítems: ");
                if (int.TryParse(Console.ReadLine(), out cantidadItems) && cantidadItems > 0)
                    break;
                Console.WriteLine("❌ Debe ser un número entero positivo.");
            }

            string categoriaDespacho = "";
            double costoEnvio = 0;

            // SWITCH PARA CLASIFICACIÓN
            switch (tipoCliente)
            {
                case "recurrente":
                    if (montoPedido >= 150000)
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
                    break;

                case "nuevo":
                    if (cantidadItems >= 5 || montoPedido >= 300000)
                    {
                        categoriaDespacho = "Envío Express";
                        costoEnvio = 20000;
                    }
                    else
                    {
                        categoriaDespacho = "Envío Estándar";
                        costoEnvio = 10000;
                    }
                    break;
            }

            // COSTO EXTRA
            if (ciudadDestino == "exterior")
            {
                costoEnvio += 15000;
            }

            // GUARDAR EN LISTA
            costosEnvio.Add(costoEnvio);

            // SALIDA
            Console.WriteLine("\n--- RESULTADO ---");
            Console.WriteLine("Categoría: " + categoriaDespacho);
            Console.WriteLine("Costo envío: $" + costoEnvio);

            // CONTINUAR
            Console.Write("\n¿Desea registrar otro pedido? (si/no): ");
            opcion = Console.ReadLine().ToLower();

        } while (opcion == "si");

        // --- REPORTE ---
        Console.WriteLine("\n--- REPORTE ---");

        if (costosEnvio.Count == 0)
        {
            Console.WriteLine("No hay datos para mostrar.");
        }
        else
        {
            double suma = 0;
            double mayor = costosEnvio[0];
            double menor = costosEnvio[0];

            foreach (double costo in costosEnvio)
            {
                suma += costo;

                if (costo > mayor)
                    mayor = costo;

                if (costo < menor)
                    menor = costo;
            }

            double promedio = suma / costosEnvio.Count;

            Console.WriteLine("Total pedidos: " + costosEnvio.Count);
            Console.WriteLine("Costo promedio: $" + promedio);
            Console.WriteLine("Costo mayor: $" + mayor);
            Console.WriteLine("Costo menor: $" + menor);
        }

        Console.WriteLine("\nPrograma finalizado.");
    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        EjecutarSistema();
    }

    /// <summary>
    /// Controla la ejecución general del sistema.
    /// </summary>
    static void EjecutarSistema()
    {
        List<double> costosEnvio = new List<double>();
        string opcion;

        do
        {
            MostrarTitulo("REGISTRO DE PEDIDO");

            double montoPedido = LeerMontoPedido();
            string ciudadDestino = LeerCiudadDestino();
            string tipoCliente = LeerTipoCliente();
            int cantidadItems = LeerCantidadItems();

            string categoriaDespacho = CalcularCategoriaDespacho(
                tipoCliente,
                montoPedido,
                cantidadItems
            );

            double costoEnvio = CalcularCostoEnvio(
                categoriaDespacho,
                ciudadDestino
            );

            costosEnvio.Add(costoEnvio);

            MostrarResultado(categoriaDespacho, costoEnvio);

            opcion = LeerOpcionContinuar();

        } while (opcion == "si");

        MostrarReporte(costosEnvio);

        Console.WriteLine("\nPrograma finalizado.");
    }

    // =========================
    // FUNCIONES UI
    // =========================

    /// <summary>
    /// Muestra un título en consola.
    /// </summary>
    /// <param name="titulo">Texto del título.</param>
    static void MostrarTitulo(string titulo)
    {
        Console.WriteLine($"\n--- {titulo} ---");
    }

    /// <summary>
    /// Solicita y valida el monto del pedido.
    /// </summary>
    /// <returns>Monto válido mayor a cero.</returns>
    static double LeerMontoPedido()
    {
        double montoPedido;

        while (true)
        {
            Console.Write("Ingrese el monto del pedido: ");

            if (double.TryParse(Console.ReadLine(), out montoPedido) && montoPedido > 0)
                return montoPedido;

            Console.WriteLine("❌ Valor inválido. Debe ser un número positivo.");
        }
    }

    /// <summary>
    /// Solicita y valida la ciudad destino.
    /// </summary>
    /// <returns>local o exterior.</returns>
    static string LeerCiudadDestino()
    {
        string ciudadDestino;

        while (true)
        {
            Console.Write("Ingrese la ciudad destino (local/exterior): ");
            ciudadDestino = Console.ReadLine().ToLower();

            if (ciudadDestino == "local" || ciudadDestino == "exterior")
                return ciudadDestino;

            Console.WriteLine("❌ Solo se permite 'local' o 'exterior'.");
        }
    }

    /// <summary>
    /// Solicita y valida el tipo de cliente.
    /// </summary>
    /// <returns>nuevo o recurrente.</returns>
    static string LeerTipoCliente()
    {
        string tipoCliente;

        while (true)
        {
            Console.Write("Ingrese el tipo de cliente (nuevo/recurrente): ");
            tipoCliente = Console.ReadLine().ToLower();

            if (tipoCliente == "nuevo" || tipoCliente == "recurrente")
                return tipoCliente;

            Console.WriteLine("❌ Solo se permite 'nuevo' o 'recurrente'.");
        }
    }

    /// <summary>
    /// Solicita y valida la cantidad de ítems.
    /// </summary>
    /// <returns>Cantidad válida mayor a cero.</returns>
    static int LeerCantidadItems()
    {
        int cantidadItems;

        while (true)
        {
            Console.Write("Ingrese la cantidad de ítems: ");

            if (int.TryParse(Console.ReadLine(), out cantidadItems) && cantidadItems > 0)
                return cantidadItems;

            Console.WriteLine("❌ Debe ser un número entero positivo.");
        }
    }

    /// <summary>
    /// Muestra el resultado del pedido.
    /// </summary>
    /// <param name="categoriaDespacho">Categoría calculada.</param>
    /// <param name="costoEnvio">Costo total del envío.</param>
    static void MostrarResultado(string categoriaDespacho, double costoEnvio)
    {
        Console.WriteLine("\n--- RESULTADO ---");
        Console.WriteLine("Categoría: " + categoriaDespacho);
        Console.WriteLine("Costo envío: $" + costoEnvio);
    }

    /// <summary>
    /// Pregunta si se desea registrar otro pedido.
    /// </summary>
    /// <returns>Respuesta del usuario.</returns>
    static string LeerOpcionContinuar()
    {
        Console.Write("\n¿Desea registrar otro pedido? (si/no): ");
        return Console.ReadLine().ToLower();
    }

    // =========================
    // FUNCIONES DE LÓGICA
    // =========================

    /// <summary>
    /// Calcula la categoría de despacho según las reglas del sistema.
    /// </summary>
    /// <param name="tipoCliente">Tipo de cliente.</param>
    /// <param name="montoPedido">Monto del pedido.</param>
    /// <param name="cantidadItems">Cantidad de ítems.</param>
    /// <returns>Categoría de envío.</returns>
    static string CalcularCategoriaDespacho(
        string tipoCliente,
        double montoPedido,
        int cantidadItems
    )
    {
        switch (tipoCliente)
        {
            case "recurrente":

                if (montoPedido >= 150000)
                    return "Envío Gratis";

                if (cantidadItems >= 5 || montoPedido >= 300000)
                    return "Envío Express";

                return "Envío Estándar";

            case "nuevo":

                if (cantidadItems >= 5 || montoPedido >= 300000)
                    return "Envío Express";

                return "Envío Estándar";

            default:
                return "Envío Estándar";
        }
    }

    /// <summary>
    /// Calcula el costo del envío según la categoría y destino.
    /// </summary>
    /// <param name="categoriaDespacho">Categoría del envío.</param>
    /// <param name="ciudadDestino">Destino del pedido.</param>
    /// <returns>Costo total del envío.</returns>
    static double CalcularCostoEnvio(
        string categoriaDespacho,
        string ciudadDestino
    )
    {
        double costoEnvio;

        switch (categoriaDespacho)
        {
            case "Envío Gratis":
                costoEnvio = 0;
                break;

            case "Envío Express":
                costoEnvio = 20000;
                break;

            default:
                costoEnvio = 10000;
                break;
        }

        if (ciudadDestino == "exterior")
        {
            costoEnvio += 15000;
        }

        return costoEnvio;
    }

    // =========================
    // FUNCIONES REPORTE
    // =========================

    /// <summary>
    /// Muestra el reporte general de pedidos registrados.
    /// </summary>
    /// <param name="costosEnvio">Lista de costos registrados.</param>
    static void MostrarReporte(List<double> costosEnvio)
    {
        Console.WriteLine("\n--- REPORTE ---");

        if (costosEnvio.Count == 0)
        {
            Console.WriteLine("No hay datos para mostrar.");
            return;
        }

        double suma = CalcularSuma(costosEnvio);
        double promedio = CalcularPromedio(costosEnvio, suma);
        double mayor = ObtenerMayorCosto(costosEnvio);
        double menor = ObtenerMenorCosto(costosEnvio);

        Console.WriteLine("Total pedidos: " + costosEnvio.Count);
        Console.WriteLine("Costo promedio: $" + promedio);
        Console.WriteLine("Costo mayor: $" + mayor);
        Console.WriteLine("Costo menor: $" + menor);
    }

    /// <summary>
    /// Calcula la suma total de los costos.
    /// </summary>
    /// <param name="costosEnvio">Lista de costos.</param>
    /// <returns>Suma total.</returns>
    static double CalcularSuma(List<double> costosEnvio)
    {
        double suma = 0;

        foreach (double costo in costosEnvio)
        {
            suma += costo;
        }

        return suma;
    }

    /// <summary>
    /// Calcula el promedio de costos.
    /// </summary>
    /// <param name="costosEnvio">Lista de costos.</param>
    /// <param name="suma">Suma total.</param>
    /// <returns>Promedio calculado.</returns>
    static double CalcularPromedio(List<double> costosEnvio, double suma)
    {
        return suma / costosEnvio.Count;
    }

    /// <summary>
    /// Obtiene el costo mayor registrado.
    /// </summary>
    /// <param name="costosEnvio">Lista de costos.</param>
    /// <returns>Mayor costo.</returns>
    static double ObtenerMayorCosto(List<double> costosEnvio)
    {
        double mayor = costosEnvio[0];

        foreach (double costo in costosEnvio)
        {
            if (costo > mayor)
            {
                mayor = costo;
            }
        }

        return mayor;
    }

    /// <summary>
    /// Obtiene el costo menor registrado.
    /// </summary>
    /// <param name="costosEnvio">Lista de costos.</param>
    /// <returns>Menor costo.</returns>
    static double ObtenerMenorCosto(List<double> costosEnvio)
    {
        double menor = costosEnvio[0];

        foreach (double costo in costosEnvio)
        {
            if (costo < menor)
            {
                menor = costo;
            }
        }

        return menor;
    }
}

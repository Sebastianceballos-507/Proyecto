# Sistema de Gestión de Envíos

## Descripción

Este proyecto es una aplicación de consola desarrollada en C# que permite registrar pedidos y calcular automáticamente el costo de envío según diferentes condiciones como el monto del pedido, tipo de cliente, cantidad de ítems y destino.

El sistema también genera un reporte final con métricas básicas de los envíos registrados.

---

## Objetivos del proyecto

* Aplicar estructuras de control (`if`, `switch`, ciclos).
* Validar entradas de usuario con `TryParse`.
* Implementar almacenamiento dinámico con `List<T>`.
* Generar reportes a partir de los datos ingresados.

---

## Funcionalidades

* Registro de múltiples pedidos

* Validación de datos (formato y dominio)

* Clasificación del tipo de envío:

  * Envío Gratis
  * Envío Express
  * Envío Estándar

* Cálculo automático del costo de envío

* Recargo por envíos al exterior

* Generación de reporte final con:

  * Total de pedidos
  * Costo promedio
  * Costo mayor
  * Costo menor

* Manejo de casos sin datos (lista vacía)

---

## Lógica del sistema

El sistema clasifica los pedidos de la siguiente manera:

* Envío Gratis:
  Cliente recurrente con compras ≥ $150.000

* Envío Express:
  Más de 5 ítems o compras ≥ $300.000

* Envío Estándar:
  Cualquier otro caso

* Costo adicional:

  * $15.000 si el destino es exterior

---

## Tecnologías utilizadas

* Lenguaje: C#
* Plataforma: .NET (Aplicación de consola)

---

## Cómo ejecutar el proyecto

1. Clona el repositorio:

```bash
git clone https://github.com/tu-usuario/tu-repo.git
```

2. Abre el proyecto en Visual Studio o VS Code

3. Ejecuta el programa:

```bash
dotnet run
```

---

## Ejemplo de uso

```
Ingrese el monto del pedido: 200000
Ingrese la ciudad destino: local
Ingrese el tipo de cliente: recurrente
Ingrese la cantidad de ítems: 3

--- RESULTADO ---
Categoría: Envío Gratis
Costo envío: $0
```

---

## Ejemplo de reporte

```
--- REPORTE ---
Total pedidos: 3
Costo promedio: $15000
Costo mayor: $35000
Costo menor: $0
```

---

## Conceptos aplicados

* do-while
* switch
* List<T>
* TryParse
* Validación de entradas
* Ciclos (foreach)

---

## Autor

Sebastián Ceballos Juan Pablo Barrientos

---

## Estado del proyecto

Completo – Cumple con los requisitos de la Entrega 2

   


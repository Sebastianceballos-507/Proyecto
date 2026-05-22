# Sistema de Gestión de Envíos

## Descripción

Este proyecto es una aplicación de consola desarrollada en C# que permite registrar pedidos y calcular automáticamente el costo de envío según diferentes condiciones como:

- Monto del pedido
- Tipo de cliente
- Cantidad de ítems
- Destino del envío

El sistema también genera un reporte final con estadísticas básicas de los pedidos registrados.

---

# Objetivos del proyecto

- Aplicar programación modular mediante funciones.
- Implementar validaciones de datos usando `TryParse`.
- Separar responsabilidades entre:
  - Entrada y salida de datos
  - Lógica de negocio
  - Orquestación del sistema
- Utilizar listas dinámicas (`List<T>`).
- Generar reportes automáticos.

---

# Arquitectura del proyecto

El proyecto fue refactorizado para cumplir con una estructura modular.

## Jerarquía del sistema

```text
Main
 └── EjecutarSistema()
      ├── Funciones UI
      ├── Funciones de lógica
      └── Funciones de reporte
```

---

# Tabla de funciones

| Función | Responsabilidad |
|---|---|
| `Main()` | Punto de entrada del programa |
| `EjecutarSistema()` | Coordina toda la ejecución |
| `LeerMontoPedido()` | Valida el monto ingresado |
| `LeerCiudadDestino()` | Valida el destino |
| `LeerTipoCliente()` | Valida el tipo de cliente |
| `LeerCantidadItems()` | Valida cantidad de ítems |
| `CalcularCategoriaDespacho()` | Determina el tipo de envío |
| `CalcularCostoEnvio()` | Calcula el costo final |
| `MostrarResultado()` | Imprime resultados |
| `MostrarReporte()` | Genera estadísticas |
| `CalcularSuma()` | Suma costos |
| `CalcularPromedio()` | Calcula promedio |
| `ObtenerMayorCosto()` | Obtiene costo máximo |
| `ObtenerMenorCosto()` | Obtiene costo mínimo |

---

# Funcionalidades

## Registro de pedidos

- Registro múltiple de pedidos
- Validación de entradas
- Clasificación automática

## Tipos de envío

### Envío Gratis
Cliente recurrente con compras ≥ $150.000

### Envío Express
- 5 o más ítems
- o compras ≥ $300.000

### Envío Estándar
Cualquier otro caso

## Costos adicionales

- + $15.000 si el destino es exterior

---

# Tecnologías utilizadas

- Lenguaje: C#
- Plataforma: .NET Console Application

---

# Cómo ejecutar el proyecto

## 1. Clonar repositorio

```bash
git clone https://github.com/tu-usuario/tu-repositorio.git
```

## 2. Abrir proyecto

Puede abrirse en:

- Visual Studio
- Visual Studio Code

---

## 3. Ejecutar programa

```bash
dotnet run
```

---

# Ejemplo de uso

```text
--- REGISTRO DE PEDIDO ---

Ingrese el monto del pedido: 200000
Ingrese la ciudad destino (local/exterior): local
Ingrese el tipo de cliente (nuevo/recurrente): recurrente
Ingrese la cantidad de ítems: 3

--- RESULTADO ---
Categoría: Envío Gratis
Costo envío: $0
```

---

# Ejemplo de reporte

```text
--- REPORTE ---
Total pedidos: 3
Costo promedio: $15000
Costo mayor: $35000
Costo menor: $0
```

---

# Casos de prueba

| Tipo Cliente | Monto | Ítems | Destino | Resultado |
|---|---|---|---|---|
| recurrente | 200000 | 3 | local | Envío Gratis |
| nuevo | 350000 | 2 | local | Envío Express |
| nuevo | 50000 | 1 | exterior | Estándar + recargo |
| recurrente | 100000 | 6 | exterior | Express + recargo |

---

# Conceptos aplicados

- Programación modular
- Responsabilidad única
- Funciones con retorno
- Funciones void
- Validación de entradas
- `switch`
- `do-while`
- `foreach`
- `List<T>`
- `TryParse`
- Documentación XML (`///`)

---

# Autores

- Sebastián Ceballos
- Juan Pablo Barrientos
- Juan Camilo Mejía

---

# Estado del proyecto

Entrega Final completada.

Cumple con:

- Refactorización modular
- Separación de responsabilidades
- Funciones con firmas correctas
- Documentación XML
- README actualizado


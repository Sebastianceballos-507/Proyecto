# Proyecto
# 📦 Sistema de Clasificación de Pedidos

## 📌 Descripción del Proyecto

Este proyecto consiste en una aplicación de consola desarrollada en C# (.NET SDK) que permite clasificar un pedido según su categoría de despacho y calcular el costo total de envío.

El sistema analiza diferentes variables ingresadas por el usuario y aplica reglas de negocio utilizando estructuras condicionales.

---

## 🎯 Propuesta de Solución

Se desarrolló un programa que:

- Solicita al usuario los datos del pedido.
- Evalúa las condiciones mediante estructuras `if / else if / else`.
- Aplica operadores lógicos `&&` y `||`.
- Determina automáticamente la categoría de despacho.
- Calcula el costo de envío según las reglas establecidas.
- Muestra un mensaje claro y contextual al usuario.

La solución cumple con los requisitos técnicos solicitados:
- Uso de C# consola (.NET SDK)
- Mínimo 3 estructuras condicionales
- Uso de múltiples tipos de variables (double, int, string)
- Conversión explícita con `Convert.ToDouble()` y `Convert.ToInt32()`
- Mensajes de salida comprensibles

---

## 📥 Entradas del Sistema

El programa solicita:

- Monto del pedido (double)
- Ciudad destino (string)
- Tipo de cliente ("nuevo" o "recurrente") (string)
- Cantidad de ítems (int)

---

## ⚙️ Reglas de Negocio Implementadas

1. 🚚 Envío Gratis  
   - Si el monto es mayor o igual a 150000  
   - Y el cliente es recurrente  

2. ⚡ Envío Express  
   - Si la cantidad de ítems es mayor o igual a 5  
   - O el monto es mayor o igual a 300000  

3. 📦 Envío Estándar  
   - En cualquier otro caso  

4. 🌎 Recargo adicional  
   - Si la ciudad destino es "exterior", se suma un valor adicional al costo de envío.

---

## 🧪 Casos de Prueba

### 🔹 Caso 1 – Envío Gratis

Entrada:
Monto: 200000  
Ciudad: medellin  
Tipo cliente: recurrente  
Ítems: 2  

Resultado esperado:
Categoría: Envío Gratis  
Costo total de envío: $0  

---

### 🔹 Caso 2 – Envío Express por cantidad de ítems

Entrada:
Monto: 100000  
Ciudad: bogota  
Tipo cliente: nuevo  
Ítems: 6  

Resultado esperado:
Categoría: Envío Express  
Costo total de envío: $20000  

---

### 🔹 Caso 3 – Envío Express por monto alto

Entrada:
Monto: 350000  
Ciudad: cali  
Tipo cliente: nuevo  
Ítems: 1  

Resultado esperado:
Categoría: Envío Express  
Costo total de envío: $20000  

---

### 🔹 Caso 4 – Envío Estándar + recargo exterior

Entrada:
Monto: 80000  
Ciudad: exterior  
Tipo cliente: nuevo  
Ítems: 2  

Resultado esperado:
Categoría: Envío Estándar  
Costo total de envío: $25000  

---

## Cómo Ejecutar el Proyecto

1. Abrir la terminal en la carpeta del proyecto.
2. Ejecutar el siguiente comando:

dotnet run
Estructura del Proyecto: 
/SistemaClasificacionPedidos
│
├── Program.cs
├── README.md
└── .gitignore
 Autores

Sebastián Ceballos 
Juan Pablo Barrientos
Proyecto académico - Entrega 1
   


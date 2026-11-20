# Numeros_Perfectos

Programa de consola en **C#** que busca los **números perfectos** dentro de un rango definido por el usuario. Surgió como una prueba técnica.

Un número perfecto es un entero positivo igual a la suma de sus divisores propios (los que son menores que él). Por ejemplo, 6 = 1 + 2 + 3 y 28 = 1 + 2 + 4 + 7 + 14.

## Cómo funciona

El archivo `Program.cs` define el espacio de nombres `prueba` con dos clases:

- **`NumerosPerfectosbuscar`**: el método `encontrado_numero_perfecto(int numero)` recorre los enteros `i` desde 1 hasta `numero - 1`, suma los que dividen exactamente a `numero` (`numero % i == 0`) y devuelve `true` si esa suma es igual a `numero`.
- **`Program`**: en `Main` pide por consola el valor mínimo y el máximo, recorre todos los enteros del rango (ambos extremos incluidos), imprime cada número perfecto encontrado y, si no hay ninguno, muestra el mensaje "no se encontraaron números perfectos".

Es un algoritmo de fuerza bruta: cada número se valida con un recorrido lineal, así que los rangos muy grandes tardan en procesarse.

## Cómo ejecutarlo

El repositorio contiene únicamente `Program.cs`; **no incluye archivo de proyecto (`.csproj`) ni solución (`.sln`)**, por lo que `dotnet run` no funciona directamente sobre la carpeta clonada. Hay dos opciones:

**Opción 1: crear un proyecto de consola con el .NET SDK**

```bash
git clone https://github.com/tigonoby/Numeros_Perfectos.git
dotnet new console -n NumerosPerfectos -o NumerosPerfectos
cp Numeros_Perfectos/Program.cs NumerosPerfectos/Program.cs   # reemplaza el archivo generado
cd NumerosPerfectos
dotnet run
```

**Opción 2: Visual Studio**

Crea un proyecto "Aplicación de consola" de C# y reemplaza el contenido de `Program.cs` por el de este repositorio.

Al ejecutarlo, ingresa el mínimo y el máximo cuando se soliciten. Entre 1 y 10000 los números perfectos conocidos son 6, 28, 496 y 8128.

## Observaciones

Detalles del código actual que se pueden mejorar:

- El segundo mensaje de entrada también dice "ingrese el valor minimo"; debería pedir el valor máximo.
- La entrada se lee con `Convert.ToInt32`, sin validación: un texto no numérico lanza una excepción.
- Si el rango incluye el 0, el método lo marca como perfecto (la suma de divisores queda en 0), lo cual no es correcto; conviene validar que el número sea mayor que 0.
- El recorrido puede reducirse hasta la raíz cuadrada de `numero` sumando cada pareja de divisores.

## Tecnologías

C# (.NET), aplicación de consola.

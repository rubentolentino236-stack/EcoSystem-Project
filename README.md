# EcoSystem Connect

Proyecto correspondiente a la Firma 1 de Programación III.

## Descripción

EcoSystem Connect es una aplicación cliente desarrollada con Blazor WebAssembly y C#.  
El proyecto utiliza una estructura basada en el patrón MVVM para separar la interfaz, la lógica de presentación, los modelos de datos y los servicios.

## Tecnologías utilizadas

- .NET 10
- Blazor WebAssembly
- C#
- CommunityToolkit.Mvvm
- Microsoft.Extensions.Http
- Git y GitHub

## Arquitectura del proyecto

El proyecto está organizado en las siguientes carpetas:

- `Views`: contiene las vistas y componentes de interfaz.
- `ViewModels`: contiene la lógica de presentación.
- `Models`: contiene las entidades de datos.
- `Services`: contiene los servicios para comunicación con una API.

## Archivos principales

- `Models/Ecosystem.cs`
- `Models/Species.cs`
- `Services/ApiService.cs`
- `ViewModels/MainViewModel.cs`
- `Views/MainPage.razor`

## Funcionalidad implementada

- Estructura MVVM.
- Registro de servicios mediante inyección de dependencias.
- Vista de listado de ecosistemas.
- Datos de prueba mostrados desde el ViewModel.
- Navegación hacia la página de ecosistemas.
- Compilación y ejecución local comprobadas.

## Cómo ejecutar el proyecto

Restaurar dependencias:

```bash
dotnet restore
# Farmacity Backend API

Este proyecto es una API web desarrollada en **.NET 8** utilizando **Entity Framework Core** y **SQL Server** para gestionar información de productos y códigos de barra, permitiendo realizar operaciones CRUD, validaciones y documentación.

## Requisitos

- **Visual Studio 2022**
- **.NET 8 SDK**
- **SQL Server** (local o remoto)
- **Configuración de Base de Datos** (modificar en el archivo `appsettings.Development.json`)

## Configuración del Proyecto

1. **Clonar el repositorio**:  
   Clona el repositorio en tu máquina local desde GitHub.

2. **Configuración de Base de Datos**:
   - Abre el archivo `appsettings.Development.json`.
   - En la sección `ConnectionStrings`, modifica la cadena de conexión para que coincida con la configuración de tu instancia de SQL Server:
     ```json
     "ConnectionStrings": {
       "DefaultConnection": "Server=TU_SERVIDOR;Database=FarmacityDb;User Id=TU_USUARIO;Password=TU_PASSWORD;"
     }
     ```

3. **Migraciones de Base de Datos**:
   - Ejecuta el siguiente comando para aplicar las migraciones y crear la base de datos:
     ```
     Update-Database
     ```

## Ejecutar el Proyecto

1. En **Visual Studio 2022**, abre el proyecto.
2. Presiona **F5** o haz clic en **Iniciar** para ejecutar la API.

## Endpoints Principales

A continuación, se muestra un resumen de los endpoints principales disponibles en esta API. Cada uno de ellos está documentado y accesible a través de Swagger.

- **GET /api/productos**: Obtiene una lista de todos los productos.
- **GET /api/productos/{id}**: Obtiene un producto específico por su ID.
- **POST /api/productos**: Crea un nuevo producto.
- **PUT /api/productos/{id}**: Actualiza un producto existente.
- **DELETE /api/productos/{id}**: Elimina un producto existente.

## Documentación de la API

La documentación de la API se encuentra disponible con **Swagger**. Una vez que la aplicación esté en ejecución, puedes acceder a la documentación en:

https://localhost:{PUERTO}/swagger/index.html

## Tecnologías Utilizadas

- **.NET 8** - Framework para desarrollar la API.
- **Entity Framework Core** - ORM para manejar la base de datos SQL Server.
- **SQL Server** - Base de datos relacional para almacenar los datos.
- **Swagger** - Herramienta para documentar y probar la API.

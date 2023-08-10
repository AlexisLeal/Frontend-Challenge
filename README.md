# Frontend-Challenge
## Repositorio de reto de programacion

Este proyecto se estructura en tres componentes principales: frontend, backend y base de datos.

### Frontend
- Desarrollado con Angular 16.
- Se ha implementado siguiendo una arquitectura limpia de capas para garantizar la modularidad y facilidad de mantenimiento del código.

### Backend
- Desarrollado utilizando .NET Core 6.
- Implementado con una arquitectura hexagonal, lo que facilita el aislamiento de las preocupaciones y mejora la testabilidad.
- Utiliza varios patrones de diseño para mejorar la estructuración y la lógica del código:
  - **Repository**: Proporciona un mecanismo de abstracción para acceder a los datos, permitiendo una separación entre la lógica de negocio y las operaciones de la base de datos.
  - **Mediator**: Ayuda a reducir las dependencias entre objetos al hacer que se comuniquen entre sí a través de un objeto mediador centralizado.
  - **UnitOfWork**: Gestiona el conjunto de cambios que se realizarán en la base de datos como una única unidad de trabajo.
  - **CQRS (Command Query Responsibility Segregation)**: Separa las operaciones de lectura (queries) y escritura (commands) para garantizar un alto rendimiento y separación de responsabilidades.
- Se utiliza Entity Framework como ORM para facilitar la interacción con la base de datos.

### Base de datos
- Es una base de datos simplificada, diseñada para demostrar la funcionalidad básica del sistema sin la complejidad de una base de datos de producción.

## Configuración y despliegue

Para asegurar el correcto funcionamiento de los componentes, es esencial configurar una red Docker llamada `frontend`. Cada componente del proyecto (frontend, backend, base de datos) viene con su propio `Dockerfile` y `docker-compose.yml`, lo que facilita su contenedorización y despliegue.

Para comenzar, asegúrese de crear la red Docker requerida:
```
docker network create frontend
```

Luego, diríjase a cada subdirectorio del componente y utilice `docker-compose` para construir y desplegar los contenedores:
```
docker-compose up -d
```
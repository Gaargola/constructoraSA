# Sistema de Gestión de Empresa Constructora

Este es un sistema de gestión para una empresa constructora que tiene varias obras en ejecución y grupos de obreros que trabajan en estas obras. La aplicación proporciona diversas funcionalidades para la gestión eficiente de la empresa y sus recursos.

## Funcionalidades

El sistema proporciona las siguientes funcionalidades:

### a) Contratar un obrero nuevo

Permite agregar un nuevo obrero a la empresa y asignarlo a un grupo de obreros.

### b) Eliminar un obrero

Permite eliminar un obrero de la empresa y de su respectivo grupo de trabajo.

### c) Contratar a un jefe de obra

Asigna a un obrero como jefe de obra a una obra existente y le asigna un grupo de obreros libres. Si no hay ningún grupo libre, se levanta una excepción.

### d) Submenú de impresión

- **Listado de obreros:** Muestra la lista de todos los obreros de la empresa.
- **Listado de obras en ejecución:** Muestra las obras en curso.
- **Listado de obras finalizadas:** Muestra las obras que han sido completadas.
- **Listado de jefes:** Muestra la lista de todos los jefes de obra.
- **Porcentaje de obras de remodelación sin finalizar:** Calcula y muestra el porcentaje de obras de remodelación que aún no han sido completadas.

### e) Modificar el estado de avance de una obra

Permite modificar el estado de avance de una obra. Si el avance llega al 100%, la obra se considera finalizada y se traslada al listado de obras finalizadas.

### f) Dar de baja a un jefe

Elimina a un jefe de obra de la empresa, lo desvincula de la obra que estaba dirigiendo y libera el grupo de obreros asignado.

## Desarrollo de la Aplicación

El sistema está desarrollado utilizando clases para representar obreros, obras, jefes de obra y grupos de obreros. Se emplea la herencia cuando es necesario para modelar las relaciones entre los diferentes tipos de entidades.

El menú principal permite acceder a todas las funcionalidades mencionadas anteriormente, brindando una interfaz intuitiva para la gestión eficiente de la empresa constructora.

---

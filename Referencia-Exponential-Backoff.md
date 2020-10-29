## Referencia: Backoff exponencial
Visitar: https://aws.amazon.com/blogs/architecture/exponential-backoff-and-jitter/

El Backoff exponencial es una tecnica que se utiliza como parte de una estrategia de reintentos en sistemas escalables.
Este consiste en que si tenemos un Cliente que manda peticiones a un servicio hospedado en la nube, cuando se encuentra un codigo de error en la respuesta del servicio, este suma un "delay" antes de volver a intentar enviar dicha peticion.

Algunos ejemplos en los que se puede hacer uso de esta tecnica son:
- Se tiene un servicio que procesa cientos de compras en linea por segundo, eventualmente un error de red ocasiona errores 500 de servidor, dada la perdida de conexion con la base de datos. Al recibir el cliente un error 500 por medio del protocolo HTTP, reintenta la peticion con backoff exponencial y la peticion tiene exito. En horas pico, puede llegar a intentar hasta 2 o 3 veces hasta que logra con exito procesar el request.
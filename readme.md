# RabbitMQ com .NET e Docker

Exemplo simples de um envio e recebimento de mensagem por fila.

Docker usado: docker run -d --name rabbitmq -e RABBITMQ_DEFAULT_USER=guest -e RABBITMQ_DEFAULT_PASS=guest -p 5672:5672 -p 15672:15672 rabbitmq:3.9-management 
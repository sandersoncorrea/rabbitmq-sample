using System;
using RabbitMQ.Client;
using System.Text;

class Send
{
    public static void Main()
    {
        try
        {
            var factory = new ConnectionFactory() { HostName = "localhost", UserName = "guest", Password = "guest" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "principal",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                string message = "Hello World! Novo";
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "",
                                     routingKey: "principal",
                                     basicProperties: null,
                                     body: body);
                Console.WriteLine(" [x] Enviado para fila ::: {0}", message);
            }

            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }
        catch (Exception ex)
        {

            throw;
        }
    }
}
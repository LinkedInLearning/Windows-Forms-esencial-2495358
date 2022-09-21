using Grpc.Net.Client;
using GrpcGreeterClient;

namespace ServiciosGrpc;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        var channel = GrpcChannel.ForAddress("https://localhost:7223");
        var client = new Greeter.GreeterClient(channel);
        var result = await client.SayHelloAsync(new HelloRequest()
        {
            Name = "Windows Forms"
        });
        button1.Text = result.Message;
    }
}
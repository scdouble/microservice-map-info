using Grpc.Net.Client;


var channel = GrpcChannel.ForAddress(new Uri("https://localhost:7033"));
var client = new microservice_map_info.Protos.DistanceInfo.DistanceInfoClient(channel);
var response = await client.GetDistanceAsync(
    new microservice_map_info.Protos.Cities
    {
        OriginCity = "Topeka,KS",DestinationCity = "Los Angeles,CA"
    });
Console.WriteLine(response.Miles);
Console.ReadKey();

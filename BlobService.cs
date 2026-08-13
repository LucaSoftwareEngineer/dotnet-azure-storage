using Azure.Storage.Blobs;

namespace AzuriteStorage
{
    public class BlobService : IStorageService
    {
        public async Task Execute()
        {
            var connectionString = "DefaultEndpointsProtocol=http;AccountName=devstoreaccount1;AccountKey=Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==;BlobEndpoint=http://127.0.0.1:10000/devstoreaccount1;";

            var client = new BlobContainerClient(connectionString, "images");

            var stream = await new HttpClient().GetStreamAsync("https://www.vaisulweb.com/wp-content/uploads/2019/02/azure_logo_794_new.png");

            var blob = client.GetBlobClient("miaImmagine.png");
            await blob.UploadAsync(stream);

            Console.WriteLine("immagine caricata su blob service");
        }
    }
}

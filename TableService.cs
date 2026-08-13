using Azure.Data.Tables;

namespace AzuriteStorage
{
    public class TableService : IStorageService
    {
        public async Task Execute()
        {
            var connectionString = "DefaultEndpointsProtocol=http;AccountName=devstoreaccount1;AccountKey=Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==;TableEndpoint=http://127.0.0.1:10002/devstoreaccount1;";

            var client = new TableClient(connectionString, "product");

            List<TableEntity> entities = new List<TableEntity>
            {
                new("clothes", "1")
                {
                    { "Name", "Thirt" }
                },
                new("clothes", "2")
                {
                    { "Name", "Stivales" }
                }
            };

            foreach (var item in entities)
            {
                await client.AddEntityAsync(item);
            }
        }
    }
}

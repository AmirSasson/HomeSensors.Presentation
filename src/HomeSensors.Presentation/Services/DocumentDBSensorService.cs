using Microsoft.Azure.Documents.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeSensors.Presentation.Contracts;

namespace HomeSensors.Presentation.Services
{
    public class DocumentDBSensorService : Contracts.ISensorsService
    {
        public DocumentDBSensorService() 
        {
//            Microsoft.Azure.Documents.Database db = new Microsoft.Azure.Documents.Database();
           // DocumentClient client =new DocumentClient(new Uri(EndpointUri), PrimaryKey);

            //UriFactory.
            //client.ReadDocumentAsync()
        }

        public IEnumerable<SensorData<double>> GetSnapshot()
        {
            throw new NotImplementedException();
        }
    }
}

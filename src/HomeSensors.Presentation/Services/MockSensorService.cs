using Microsoft.Azure.Documents.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeSensors.Presentation.Contracts;

namespace HomeSensors.Presentation.Services
{
    public class MockSensorService : Contracts.ISensorsService
    {
        Dictionary<Guid, Sensor> _sensors;
        public MockSensorService()
        {
            var s1 = new Sensor() { Desciption = "test1", Id = Guid.NewGuid(), Status = SensorStatus.Active };
            var s2 = new Sensor() { Desciption = "test1", Id = Guid.NewGuid(), Status = SensorStatus.Active };
            _sensors = new Dictionary<Guid, Sensor>
            {
                {s1.Id,  s1},
                {s2.Id, s2 }
            };          
        }

        public IEnumerable<SensorData<double>> GetSnapshot()
        {
            var l = new List<SensorData<double>>();
            l.Add(new SensorData<double>() { Data = 1.0, SensorID = _sensors.First().Key, Timestamp = DateTime.Now });
            l.Add(new SensorData<double>() { Data = 2.0, SensorID = _sensors.Last().Key, Timestamp = DateTime.Now });

            return l;
        }
    }
}

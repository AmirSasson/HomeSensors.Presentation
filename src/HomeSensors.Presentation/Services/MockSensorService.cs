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
        Random _rand = new Random((int)DateTime.Now.Ticks);
        public MockSensorService()
        {
            _sensors = new Dictionary<Guid, Sensor>();
            for (int i = 0; i < 5; i++)
            {
                var s = new Sensor() { Description = $"Sensor {i}", Id = Guid.NewGuid(), Status = SensorStatus.Active,  SensorType = SensorTypes.Humidity };
                _sensors[s.Id] = s;

            }
        }
        //    _sensors = new Dictionary<Guid, Sensor>
        //    {
        //        {s1.Id,  s1},
        //        {s2.Id, s2 }
        //    };
        //}


        public IEnumerable<SensorData<double>> GetSnapshot()
        {
            var l = new List<SensorData<double>>();
            foreach (var sns in _sensors.Values)
            {
                l.Add(new SensorData<double>() { Data = RandomNum(), Sensor = sns, Timestamp = DateTime.Now });
            }

            return l;
        }

        private double RandomNum()
        {
            return _rand.Next(1, 99);
        }
    }
}

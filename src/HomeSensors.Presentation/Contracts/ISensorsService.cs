using System;
using System.Collections.Generic;

namespace HomeSensors.Presentation.Contracts
{
    public interface ISensorsService
    {
        IEnumerable<SensorData<double>> GetSnapshot();
    }

    public class Sensor
    {
        public Guid Id { get; set; }
        public string Desciption { get; set; }
        public SensorStatus Status { get; set; }
    }

    public class SensorData<T>
    {
        public Guid SensorID { get; set; }
        public DateTime Timestamp { get; set; }
        public T Data { get; set; }
    }



    public enum SensorStatus
    {
        Active,
        Offline
    }
}
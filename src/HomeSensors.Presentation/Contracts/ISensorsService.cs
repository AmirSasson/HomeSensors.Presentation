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
        public SensorTypes SensorType { get; set; }
        public string Description { get; set; }
        public SensorStatus Status { get; set; }
    }

    public class SensorData<T>
    {
        public Sensor Sensor { get; set; }
        public DateTime Timestamp { get; set; }
        public T Data { get; set; }
    }



    public enum SensorStatus
    {
        Active = 0,
        Offline = 1
    }
    public enum SensorTypes
    {
        Humidity,
        Temperatur

    }
}
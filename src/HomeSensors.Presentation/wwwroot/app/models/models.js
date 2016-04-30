System.register([], function(exports_1) {
    var SensorData, Sensor;
    return {
        setters:[],
        execute: function() {
            SensorData = (function () {
                function SensorData() {
                }
                Object.defineProperty(SensorData.prototype, "timestampDate", {
                    get: function () {
                        return 11;
                    },
                    enumerable: true,
                    configurable: true
                });
                return SensorData;
            })();
            exports_1("SensorData", SensorData);
            Sensor = (function () {
                function Sensor() {
                }
                return Sensor;
            })();
            exports_1("Sensor", Sensor);
        }
    }
});
//# sourceMappingURL=models.js.map
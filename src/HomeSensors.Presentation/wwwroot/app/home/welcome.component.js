System.register(['angular2/core', "angular2-logger/core", '../services/sensors.service'], function(exports_1, context_1) {
    "use strict";
    var __moduleName = context_1 && context_1.id;
    var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
        var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
        if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
        else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
        return c > 3 && r && Object.defineProperty(target, key, r), r;
    };
    var __metadata = (this && this.__metadata) || function (k, v) {
        if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
    };
    var core_1, core_2, sensors_service_1;
    var WelcomeComponent;
    return {
        setters:[
            function (core_1_1) {
                core_1 = core_1_1;
            },
            function (core_2_1) {
                core_2 = core_2_1;
            },
            function (sensors_service_1_1) {
                sensors_service_1 = sensors_service_1_1;
            }],
        execute: function() {
            WelcomeComponent = (function () {
                function WelcomeComponent(_sensorsService, _logger) {
                    this._sensorsService = _sensorsService;
                    this._logger = _logger;
                    this.pageTitle = 'Dashboard';
                }
                WelcomeComponent.prototype.ngOnInit = function () {
                    var _this = this;
                    this._sensorsService.getSnapshot()
                        .subscribe(function (data) { return _this.sensorsData = data; }, function (error) { return _this._logger.error(error); });
                };
                WelcomeComponent.prototype.getDate = function (ts) {
                    return Date.parse(ts);
                };
                WelcomeComponent.prototype.iconByType = function (type) {
                    switch (type) {
                        case 1:
                            return 'sun-o';
                        case 0:
                            return 'tint';
                    }
                    return 'adjust';
                };
                WelcomeComponent = __decorate([
                    core_1.Component({
                        templateUrl: 'app/home/welcome.component.html',
                        styleUrls: ['app/home/welcome.component.css']
                    }), 
                    __metadata('design:paramtypes', [sensors_service_1.SensorsService, core_2.Logger])
                ], WelcomeComponent);
                return WelcomeComponent;
            }());
            exports_1("WelcomeComponent", WelcomeComponent);
        }
    }
});
//# sourceMappingURL=welcome.component.js.map
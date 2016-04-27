import { Component, OnInit }  from 'angular2/core';
import {Logger} from "angular2-logger/core";
import {SensorsService} from '../services/sensors.service';

@Component({
    templateUrl: 'app/home/welcome.component.html',
    styleUrls: ['app/home/welcome.component.css']
})
export class WelcomeComponent implements OnInit {
    public pageTitle: string = 'Welcome';
    public sensorsData;
    constructor(private _sensorsService: SensorsService, private _logger: Logger) {

    }


    ngOnInit(): void {
        this._sensorsService.getSnapshot()
            .subscribe(
            data => this.sensorsData = data,
            error => this._logger.error(error));
    }

}

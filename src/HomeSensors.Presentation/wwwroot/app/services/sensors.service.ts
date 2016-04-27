import { Injectable } from 'angular2/core';
import { Http, Response } from 'angular2/http';
import { Observable } from 'rxjs/Observable';

import { SensorData, Sensor } from '../models/models';

@Injectable()
export class SensorsService {
    private _sensorsUrl = 'api/sensors/';
    private _sensors;

    constructor(private _http: Http) { }    


    getSnapshot(): Observable<SensorData[]> {
        return this._http.get(this._sensorsUrl)
            .map((response: Response) => <SensorData[]>response.json())
            .do(data => console.log('All: ' + JSON.stringify(data)))
            .catch(this.handleError);
    }

    getSensors(): Observable<Sensor[]> {
        return this._http.get(`${this._sensorsUrl}GetSensors`)
            .map((response: Response) => <Sensor[]>response.json())
            .do(data => console.log('All: ' + JSON.stringify(data)))
            .catch(this.handleError);
    }

    //getProduct(id: number): Observable<IProduct> {
    //    return this.getProducts()
    //        .map((products: IProduct[]) => products.find(p => p.productId === id));
    //}

    private handleError(error: Response) {
        // in a real world app, we may send the server to some remote logging infrastructure
        // instead of just logging it to the console
        console.error(error);
        return Observable.throw(error.json().error || 'Server error');
    }
}

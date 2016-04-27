import { bootstrap }    from 'angular2/platform/browser';
import {Logger} from "angular2-logger/core";

// Our main component
import { AppComponent } from './app.component';

bootstrap(AppComponent, [Logger]);

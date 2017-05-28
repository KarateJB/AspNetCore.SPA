import { LogService } from './../../service/log.service';
import { Component } from '@angular/core';

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent {
    constructor(logService: LogService){
        logService.debug("jsnlog works!");
    }
}

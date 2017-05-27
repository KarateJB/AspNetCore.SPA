import { Component } from '@angular/core';
import { JL } from 'jsnlog';

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent {
    constructor(){
        JL("Angular2").debug("jsnlog works!");
    }
}

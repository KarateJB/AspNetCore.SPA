import { Injectable, Component } from '@angular/core';
import { JL } from 'jsnlog';

@Injectable()

export class LogService {

    constructor() {

    }

    trace(msg: string) {
        JL('Angular').trace(msg);
    }

    debug(msg: string) {
        JL('Angular').debug(msg);
    }

    info(msg: string) {
        JL('Angular').info(msg);
    }

    warn(msg: string) {
        JL('Angular').warn(msg);
    }

    error(msg: string) {
        JL('Angular').error(msg);
    }

}


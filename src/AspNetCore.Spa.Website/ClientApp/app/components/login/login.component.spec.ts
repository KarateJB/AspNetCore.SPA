/* tslint:disable:no-unused-variable */

import { TestBed, async } from '@angular/core/testing';
import { LoginComponent } from './login.component';

describe('LoginComponent', () => {
    beforeEach(() => {
        TestBed.configureTestingModule({
            declarations: [
                LoginComponent
            ],
        });
        TestBed.compileComponents();
    });

    it(`should have as title 'Login!'`, async(() => {
        const fixture = TestBed.createComponent(LoginComponent);
        const app = fixture.debugElement.componentInstance;
        console.log('Actuaal : ' + app.title);
        expect(app.title).toEqual('Login');
    }));

});

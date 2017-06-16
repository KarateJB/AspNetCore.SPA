import { AppRoutingModule } from './routes/app-routing.module';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { CmsModule } from './modules/cms/cms.module';
import { MainModule } from './modules/main/main.module';
import { ShareModule } from './modules/share/share.module';

import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';

import { ToastModule, ToastOptions } from 'ng2-toastr/ng2-toastr';
import { ToastConfig } from './class/toastr.config';

export const sharedConfig: NgModule = {
    bootstrap: [AppComponent],
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        FetchDataComponent,
        HomeComponent
    ],
    imports: [
        ShareModule,
        MainModule,
        CmsModule,
        AppRoutingModule
    ],
    providers: [
        { provide: ToastOptions, useClass: ToastConfig },
    ],
};

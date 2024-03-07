import { ApplicationConfig } from '@angular/core'
import {provideHttpClient} from '@angular/common/http'
import { Routes } from '@angular/router';
export const routes: Routes = [];

export const appConfig: ApplicationConfig =  {
    providers: [provideHttpClient()]
};

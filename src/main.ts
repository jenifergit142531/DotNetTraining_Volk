/// <reference types="@angular/localize" />

import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/app.module';

import { Environment } from '@angular/compiler-cli/src/ngtsc/typecheck/src/environment';


platformBrowserDynamic().bootstrapModule(AppModule)
  .catch(err => console.error(err));

  export const environment={
    production:false,
    baseApiUrl : 'https://localhost:7089'
  }

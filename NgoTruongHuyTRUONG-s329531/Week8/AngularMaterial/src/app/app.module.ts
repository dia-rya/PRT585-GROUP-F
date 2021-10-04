import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { FormAndFieldComponent } from './form-and-field/form-and-field.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormandfieldV2Component } from './formandfield-v2/formandfield-v2.component';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatSelectModule } from '@angular/material/select';
import { MatRadioModule } from '@angular/material/radio';
import { MatCardModule } from '@angular/material/card';


const appRoutes: Routes = [
  { path: 'formField', component: FormAndFieldComponent },
  { path: 'formField2', component: FormandfieldV2Component },
];

@NgModule({
  declarations: [
    AppComponent,
    FormAndFieldComponent,
    FormandfieldV2Component,
    
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(
      appRoutes,
      { enableTracing: true } // <-- debugging purposes only
    ),
    BrowserAnimationsModule,
    MatInputModule,
    MatButtonModule,
    MatSelectModule,
    MatRadioModule,
    MatCardModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

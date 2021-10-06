import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { SparklineModule } from '@progress/kendo-angular-charts';
import { AppComponent } from './app.component';
import { ChartsModule } from '@progress/kendo-angular-charts';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import 'hammerjs';




@NgModule({
  declarations: [
    AppComponent
    
  ],
  imports: [
    BrowserModule,
    ChartsModule,
    BrowserAnimationsModule,
    SparklineModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

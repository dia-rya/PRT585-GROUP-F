import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SubmitApplicationComponent } from './submit-application/submit-application.component';
import { HomeComponent } from './home/home.component';
import { MaterialComponent } from './material/material.component';
import { KendoUIComponent } from './kendo-ui/kendo-ui.component';

const routes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'apply', component: SubmitApplicationComponent },
  { path: 'material', component: MaterialComponent },
  { path: 'kendo', component: KendoUIComponent },];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

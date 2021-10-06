import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SubmitApplicationComponent } from './submit-application/submit-application.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
{ path: 'apply', component: SubmitApplicationComponent },];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

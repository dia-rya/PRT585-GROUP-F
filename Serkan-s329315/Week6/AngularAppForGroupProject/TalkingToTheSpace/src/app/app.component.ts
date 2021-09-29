import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Talking To The Space';
  public userName: string;
  public totalPoints: number;

  constructor() {
    this.userName="G4NTZ";
    this.totalPoints=999;
   }
}

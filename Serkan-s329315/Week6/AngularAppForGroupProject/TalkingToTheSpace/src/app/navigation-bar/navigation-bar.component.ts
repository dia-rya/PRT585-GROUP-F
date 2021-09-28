import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'navigation-bar',
  templateUrl: './navigation-bar.component.html',
  styleUrls: ['./navigation-bar.component.css']
})
export class NavigationBarComponent implements OnInit {

  
  public userName: string;
  public totalPoints: number;

  constructor() {
    this.userName="G4NTZ";
    this.totalPoints=999;
   }

  ngOnInit(): void {
  }

}

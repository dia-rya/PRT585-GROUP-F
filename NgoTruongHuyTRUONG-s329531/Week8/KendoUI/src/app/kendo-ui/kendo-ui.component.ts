import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-kendo-ui',
  templateUrl: './kendo-ui.component.html',
  styleUrls: ['./kendo-ui.component.css']
})
export class KendoUIComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }


  public listItems: Array<string> = [
    "X-Small",
    "Small",
    "Medium",
    "Large",
    "X-Large",
    "2X-Large",
  ];

}

import { Component, OnInit } from '@angular/core';
import { categories } from "./data.categories";

@Component({
  selector: 'app-kendo-ui',
  templateUrl: './kendo-ui.component.html',
  styleUrls: ['./kendo-ui.component.css']
})
export class KendoUIComponent implements OnInit {

  title = 'kendo-angular-app';
  public dropDownItems = categories;
  public defaultItem = { text: "Filter by Category", value: null };
  constructor() { }

  ngOnInit(): void {
  }

}

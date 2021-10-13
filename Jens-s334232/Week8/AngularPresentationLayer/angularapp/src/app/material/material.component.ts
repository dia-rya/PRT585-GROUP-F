import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-material',
  templateUrl: './material.component.html',
  styleUrls: ['./material.component.css']
})
export class MaterialComponent implements OnInit {
  feeling : string;
  pizzaIng : any;
  users = [
    'Sajee',
    'Sanath',
    'Sachin',
    'Dravid',
  ]
  constructor() {
    this.feeling="Tired"
    this.pizzaIng=[
      {name : "Pepperoni", checked : false},
      {name : "Sasuage", checked : true},
      {name : "Mushrooms", checked : false}
    ];

   }

  ngOnInit(): void {
  }

}

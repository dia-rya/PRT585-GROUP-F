import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-formandfield-v2',
  templateUrl: './formandfield-v2.component.html',
  styleUrls: ['./formandfield-v2.component.css']
})
export class FormandfieldV2Component {
  addressForm = this.fb.group({
    company: null,
    firstName: [null, Validators.required],
    lastName: [null, Validators.required],
    address: [null, Validators.required],
    address2: null,
    city: [null, Validators.required],
    state: [null, Validators.required],
    postalCode: [null, Validators.compose([
      Validators.required, Validators.minLength(5), Validators.maxLength(5)])
    ],
    shipping: ['free', Validators.required]
  });

  hasUnitNumber = false;

  states = [
    {name: 'Queensland', abbreviation: 'QLD'},
    {name: 'New South Wales', abbreviation: 'NSW'},
    {name: 'Western Australia', abbreviation: 'WA'},
    {name: 'South Australia', abbreviation: 'SA'},
    {name: 'Tasmania', abbreviation: 'TAS'},
    {name: 'Australian Capital Territory', abbreviation: 'ACT'},
    {name: 'Northern Territory', abbreviation: 'NT'},
    {name: 'Victoria', abbreviation: 'VIC'},
    

  ];

  constructor(private fb: FormBuilder) {}

  onSubmit(): void {
    alert('Thanks!');
  }
}

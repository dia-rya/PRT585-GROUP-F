import { Component, OnInit } from '@angular/core';

import { Router, ActivatedRoute, NavigationExtras } from '@angular/router';
import { UserAPIService } from '../services/user-api.service';



@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  link: string = "";

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private getAllUserData: UserAPIService
  ) { }

  ngOnInit(): void {
  }

  public checkLoginType() {
    var inputUserName = <HTMLInputElement>document.getElementById("username");
    var inputPassword = <HTMLInputElement>document.getElementById("password");
    var invalidFeedback = <HTMLInputElement>document.getElementById("invalid-feedback");

    
    this.getAllUserData.GetAllUsers().subscribe((data) => {
      for(var _i = 0; _i < Object(data)["result_set"].length; _i++) {
        if(Object(data)["result_set"][_i].account == inputUserName.value && Object(data)["result_set"][_i].password == inputPassword.value) {
          
          if (Object(data)["result_set"][_i].role == "manager") {

            let navigationExtras: NavigationExtras = {
              queryParams: {
                  "user": Object(data)["result_set"][_i].name
              }
            };

            this.router.navigate(['/dashboard']);
          } 
        } else {
          invalidFeedback.style.display = "block";
        }
      }
    });

      
    

   
  }
}

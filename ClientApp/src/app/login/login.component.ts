import { Component, OnInit } from '@angular/core';
import { LoginService } from './login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  emailAdd: String;
  tinNo: String;

  constructor(
    private loginservice: LoginService
  ) {
    this.loginservice.details.subscribe(data => {
    })
  }


  ngOnInit() {
    this.loginservice.getUri();
  }

  submitPost(): void {
    console.log("test");
    this.loginservice.postDetails("any");
  }

  saveEmail(e){
    this.emailAdd = e.target.value;
    console.log("Email Address: "+ this.emailAdd);
  }

  saveTIN(e) { 
    this.tinNo = e.target.value;
    console.log("TIN number: " + this.tinNo);
  }

  verifyUser(){
    //verify in the db
    //window.location.href = "/authorize";
    var message = "Successfully Verified";
    var title = "Verified"; 
      
  }






}

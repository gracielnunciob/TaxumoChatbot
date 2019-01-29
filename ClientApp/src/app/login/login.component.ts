import { Component, OnInit } from '@angular/core';
import { LoginService } from '../login.service';
// import { e } from '@angular/core/src/render3';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  emailAdd: String;
  tinNo: String;        

   saveEmail(e){
    this.emailAdd = e.target.value;
    this.loginService.setEmailAdd(this.emailAdd);
    console.log("Email Address: "+ this.loginService.emailAdd);
    return this.emailAdd;
  }

  saveTIN(e) { 
    this.tinNo = e.target.value;
    this.loginService.setEmailAdd(this.tinNo);
    console.log("TIN number: " + this.tinNo);
    return this.tinNo;
  }

  verifyUser(){
      Response.redirect("/helloworld/welcome");
  }


  constructor (private loginService : LoginService){
  }

  ngOnInit() {
    this.loginService.setEmailAdd(this.emailAdd);
    this.loginService.setEmailAdd(this.tinNo);
    // this.tinNo = this.loginService.saveTIN(e);
  }

}

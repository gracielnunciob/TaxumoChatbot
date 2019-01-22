import { Component, OnInit } from '@angular/core';

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
    console.log("Email Address: "+ this.emailAdd);
  }

  saveTIN(e) { 
    this.tinNo = e.target.value;
    console.log("TIN number: " + this.tinNo)
  }

  verifyUser(){
      /* If(not tru)
            Pop up based on emailAdd and tinNo
        if (true)
            redirect to the lagay stuff
      */
  }

  ngOnInit() {
  }

}

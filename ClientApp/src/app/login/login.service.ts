import { Injectable } from '@angular/core';

@Injectable()
export class LoginService {

  emailAdd: String;
  tinNo: String;     

  constructor() { }
  
  setEmailAdd(emailAdd) {
    this.emailAdd = emailAdd;
  }

  setTinNo(tinNo){
      this.tinNo = tinNo;
  }

  setCheckbox() {

  }
}

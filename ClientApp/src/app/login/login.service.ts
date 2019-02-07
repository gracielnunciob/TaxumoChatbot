import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Subject } from 'rxjs/Subject';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/finally';
import 'rxjs/add/operator/toPromise';

@Injectable()
export class LoginService {

  emailAdd: String;
  tinNo: String;
  private store: any = { details: undefined };
  public details = new Subject<any>();

  constructor(
    private http: HttpClient
  ) { }
  
  setEmailAdd(emailAdd) {
    this.emailAdd = emailAdd;
  }

  setTinNo(tinNo){
      this.tinNo = tinNo;
  }

  getUri(): void {
    const url: string = `/login`;
    this.http.get(url)
      .finally(() => { })
      .subscribe(
      data => {
        console.log(data);
        this.details.next(data);
        },
        err => {
          console.log("something went wrong");
        }
      );

  }

  postDetails(input: any): void {
    const url: string = `api/details`;
    this.http.post(url, input)
      .finally(() => { })
      .subscribe(
        data => {
          console.log("sending post request");
        },
        err => {
          console.log("something went wrong");
        }
      );
    
  }

  setCheckbox() {

  }
}

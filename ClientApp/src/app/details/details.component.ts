import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent implements OnInit {

  grossAmount:String;
  date: String;
  orsi: String;
  category: String;
  bName: String;
  notes: String;
  imageSrc: string | ArrayBuffer = "";

  saveGross(e){
    this.grossAmount = e.target.value;
    console.log("Gross Amount: " + this.grossAmount);
  }

  saveDate(e){
    this.date = e.target.value;
    console.log("Date: " + this.date);
  }

  saveORSINo(e){
    this.orsi = e.target.value;
    console.log("OR/SI: " + this.orsi);
  }

  saveCategory(e){
    this.category = e.target.value;
    console.log("Category: " + this.category);
  }

  saveBName(e){
    this.bName = e.target.value;
    console.log("Business Name: " + this.bName);
  }

  saveNotes(e){ 
    this.notes = e.target.value;
    console.log("Notes: " + this.notes);
  }

  readURL(event): void {
    if (event.target.files && event.target.files[0]) {
        const file = event.target.files[0];

        const reader = new FileReader();
        reader.onload = e => this.imageSrc = reader.result;

        reader.readAsDataURL(file);
    }
  }

  saveData(){
    // Do your backend poop
  }

  constructor() { }

  ngOnInit() {
  }

}

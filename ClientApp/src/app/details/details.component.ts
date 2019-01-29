import { Component, OnInit } from '@angular/core';
import { DetailsService } from '../details.service';

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
    this.detailsService.setGrossAmount(this.grossAmount);
    console.log("Gross Amount: " + this.grossAmount);
  }

  saveDate(e){
    this.date = e.target.value;
    this.detailsService.setDate(this.date);
    console.log("Date: " + this.date);
  }

  saveORSINo(e){
    this.orsi = e.target.value;
    this.detailsService.setOrsi(this.orsi);
    console.log("OR/SI: " + this.orsi);
  }

  saveCategory(e){
    this.category = e.target.value;
    this.detailsService.setCategory(this.category);
    console.log("Category: " + this.category);
  }

  saveBName(e){
    this.bName = e.target.value;
    this.detailsService.setBName(this.bName);
    console.log("Business Name: " + this.bName);
    this.bName;
  }

  saveNotes(e){ 
    this.notes = e.target.value;
    this.detailsService.setNotes(this.notes);
    console.log("Notes: " + this.notes);
  }

  readURL(event): void {
    if (event.target.files && event.target.files[0]) {
        const file = event.target.files[0];

        const reader = new FileReader();
        reader.onload = e => this.imageSrc = reader.result;

        reader.readAsDataURL(file);
    }

    this.detailsService.setImage(this.imageSrc);
    //needs to upload pa via google drive API
  }

  saveData(){
    // Do your backend poop
  }

  constructor(private detailsService: DetailsService) { }

  ngOnInit() {
  }

}

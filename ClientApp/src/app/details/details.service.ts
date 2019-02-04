import { Injectable } from '@angular/core';

@Injectable()
export class DetailsService {

  grossAmount:String;
  date: String;
  orsi: String;
  category: String;
  bName: String;
  notes: String;
  imageSrc: string | ArrayBuffer = "";

  constructor() { }
   
  setGrossAmount(grossAmount){
    this.grossAmount = grossAmount;
  }

  setDate(date){
    this.date = date;
  }

  setOrsi(orsi){
    this.orsi = orsi;
  }

  setCategory(category){
    this.category = category;
  }

  setBName(bName){
    this.bName = bName;
  }

  setNotes(notes){
    this.notes = notes;
  }
 
  setImage(imageSrc){
    this.imageSrc = imageSrc;
  }


}

import { Component, OnInit, NgModule, Input } from '@angular/core';
import { ChildrenOutletContexts } from '@angular/router';
import { MatDialog, MatDialogConfig } from '@angular/material';
import { InstructionsComponent } from '../instructions/instructions.component';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import UserModel from '../models/UserModel';
import ChildModel from '../models/ChildModel';


@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})

export class FormComponent implements OnInit {

  children: string = '';
  fNamef: string = '';
  lNamef: string = '';
  fullName: string = '';
  c1: ChildModel[] = new Array();
  letters: string = '';
  idntity: string = '';
  hmo: string = '';
  kind: string = '';
  flag: boolean = true;
  num:number=0;
  date:Date=new Date();
  user:UserModel={}as UserModel;

  //child:any[]=new Array();
  

  constructor(private http: HttpClient, private dialog: MatDialog) {

   }

  ngOnInit(): void {
  }

  isValid() {
    // this.isLetters(name)
    // this.isNumbers(name)
    if (this.flag == false)
      alert("Fix the wrong fields")
      else{
       this.user={
          firstName: this.fNamef,
          lastName: this.lNamef,
          identity: this.idntity,
         HMO: this.hmo,
         kind: this.kind,
         numOfChildern: this.num,
         childern:this.c1,
         dateborn:this.date
        }
        this.send().subscribe();  
      }
  }

   send():Observable<any> {
       return this.http.post("http://localhost:61740/User", this.user);
   }

   outputc(child:ChildModel,index:any){
       this.c1[index]=child;
   }
  isLetters(name: string) {
    var s = /^[A-Za-zא-ת]+$/;
    if (!name.match(s)) {
      console.log('not valid!');
      this.flag = false;
    }
  }

  isNumbers(name: string) {
    var s = /^[0-9]+$/;
    if (!name.match(s)) {
      console.log('not valid2!');
      this.flag = false;
    }
   this.length(name);
  }

  length(name: string) {
    if (name.length < 9 || name.length > 9)
        this.flag = false;
  }

  numChildren(children: string) {
    this.num=parseInt(children);
    this.c1 = new Array(parseInt(children)).fill('');
  }

  fNamefun(fName: string) {
    this.fNamef = fName;
    this.fullNamef()
  }

  lNamefun(lName: string) {
    this.lNamef = lName;
    this.fullNamef()
  }

  fullNamef() {
    this.fullName = this.fNamef + " " + this.lNamef
    console.log(this.fullName)
  }
  idfun(idntity:string){
    this.idntity=idntity;
  }
  
  kindfun(kind:string){
    this.kind=kind;
  }

  hmofun(hmo:string){
    this.hmo=hmo;
  }

  datefun(date:Date){
    this.date=date;
  }

  openDialog() {
    var dialogConfig = new MatDialogConfig();

    dialogConfig = {
      panelClass: 'mat-dialog-panel',
      data: {},
      direction: "ltr",
      height: "400px",
      width: "400px"
    };
    var dialogRef = this.dialog.open(InstructionsComponent, dialogConfig);
    return dialogRef;
  }

  open() {
    const dialogReff = this.openDialog();
    dialogReff.componentInstance.name = this.fullName;

  }


}

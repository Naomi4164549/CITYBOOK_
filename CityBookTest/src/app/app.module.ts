import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';
import {HttpClientInMemoryWebApiModule} from  'angular-in-memory-web-api';
import { InMemoryDataService } from './in-memory-data.service';
import {FormsModule} from '@angular/forms'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormComponent } from './form/form.component';
import { InstructionsComponent } from './instructions/instructions.component';
import { ChildComponent } from './child/child.component';
import {MatDialogModule, MatDialog} from '@angular/material/dialog';
import { NoopAnimationsModule } from '@angular/platform-browser/animations'

@NgModule({
  declarations: [
    AppComponent,
    FormComponent,
    InstructionsComponent,
    ChildComponent
  ],
  imports: [
    BrowserModule,
    MatDialogModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    HttpClientInMemoryWebApiModule.forRoot(InMemoryDataService,{dataEncapsulation: false}),
    NoopAnimationsModule,

  ],
  providers: [MatDialog],
  bootstrap: [AppComponent],
  entryComponents: [InstructionsComponent]



})
export class AppModule { }

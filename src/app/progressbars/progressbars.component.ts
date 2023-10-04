import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { NgbProgressbarModule } from '@ng-bootstrap/ng-bootstrap';
import { AppModule } from '../app.module';
import { map } from 'rxjs/operators';
import { IUser } from '../model/users';

@Component({
  selector: 'app-progressbars',
  templateUrl: './progressbars.component.html',
  styleUrls: ['./progressbars.component.css']
})
export class ProgressbarsComponent implements OnInit{


  constructor(private http: HttpClient){

  }

  ngOnInit(){

  }


}


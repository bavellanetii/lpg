import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { NgbProgressbarModule } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-progressbars',
  templateUrl: './progressbars.component.html',
  styleUrls: ['./progressbars.component.css']
})
export class ProgressbarsComponent {
  
  constructor(private http: HttpClient){

  }

  private fetchUser(){
    this.http.get('http://localhost:5100/api/User/1')
    .subscribe((response) => {
      console.log(response)
    })
  }

}


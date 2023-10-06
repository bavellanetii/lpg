import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-progressbars',
  templateUrl: './progressbars.component.html',
  styleUrls: ['./progressbars.component.css']
})
export class ProgressbarsComponent implements OnInit {

  users: any[] = [];
  constructor(private http: HttpClient) {

  }

  ngOnInit(): void {
    this.http.get('http://localhost:5100/api/users').subscribe({
      next: (response: any) => this.users = response,
      complete: () => {
        console.log('request completed');
      }
    })
  }



}



import { Component, OnInit } from '@angular/core';
import { Router } from "@angular/router";

@Component({
  selector: 'main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit() {
  }



   private goToCreate(){
     this.router.navigate(['Main/Create']);
   }

  private goToBook() {
    this.router.navigate(['Main/Book']);
  }

  private goToToy() {
    this.router.navigate(['Main/Toy']);
  }

    private goToClothing() {
    this.router.navigate(['Main/Clothing']);
  }

  private goToShopcart() {
    this.router.navigate(['Main/Shopcart']);
  }


}

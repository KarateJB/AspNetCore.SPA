import { ProdService } from './../../../share/service/prod.service';
import { Router } from '@angular/router';
import { Prod } from './../../../share/class/prod';
import { ToastOptions } from 'ng2-toastr/ng2-toastr';
import { Component, OnInit, ViewContainerRef } from '@angular/core';
import { ToastsManager } from "ng2-toastr/src/toast-manager";

@Component({
  selector: 'book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.css'],
  providers: [ProdService]
})
export class BookComponent implements OnInit {
    private title: string;
    private toastrOptions: ToastOptions;
    private products: Prod[];

    private itemNumbers: any;

    constructor(
        private router: Router,
        private productService: ProdService,
        private toastr: ToastsManager,
        private vRef: ViewContainerRef) {

        this.title = "Books";
        this.itemNumbers = {};
        this.toastr.setRootViewContainerRef(vRef);

        this.productService = productService;
    }

    ngOnInit() {
        this.initBooks();
    }

    //Initialize books
    private initBooks() {
        this.productService.getBooks().subscribe(data => {
            this.products = data;
            console.log(this.products);
        })
    }
}

import { Router } from '@angular/router';
import { ToastOptions } from 'ng2-toastr/ng2-toastr';
import { Component, OnInit, ViewContainerRef } from '@angular/core';
import { ToastsManager } from "ng2-toastr/src/toast-manager";
import { ProdService } from "../../../../share/service/prod.service";
import { Prod } from "../../../../share/class/prod";

@Component({
  selector: 'clothing',
  templateUrl: './prod.component.html',
  styleUrls: ['./prod.component.css'],
  providers: [ProdService]
})
export class ClothingComponent implements OnInit {
    private title: string;
    private toastrOptions: ToastOptions;
    private products: Prod[];

    private itemNumbers: any;

    constructor(
        private router: Router,
        private productService: ProdService,
        private toastr: ToastsManager,
        private vRef: ViewContainerRef) {

        this.title = "Clothing";
        this.itemNumbers = {};
        this.toastr.setRootViewContainerRef(vRef);

        this.productService = productService;
    }

    ngOnInit() {
        this.initProds();
    }

    //Initialize books
    private initProds() {
        this.productService.getClothes().subscribe(data => {
            this.products = data;
            console.log(this.products);
        })
    }
}

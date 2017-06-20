
import { ProdType } from './../../../../share/class/ProdType';
import { Prod } from './../../../../share/class/prod';
import {Component, OnInit} from '@angular/core';
import {Router} from '@angular/router';
import { ProdTypeEnum } from "../../../../share/enum/ProdTypeEnum";
import { ProdService } from './../../../../../modules/share/service/prod.service';
;


declare var swal: any; //SweetAlert2 typings definition

@Component({
    selector: 'prod-create',
    providers: [ProdService],
    templateUrl: './prod-create.component.html'
})

export class ProdCreateComponent implements OnInit {
    title: string;
    private prod: Prod;
    private prodHint: string;
    private selectedProdType: ProdType;
    private prodTypes: ProdType[];

    constructor(
        private router: Router,
        private prodService: ProdService
    ) {
        this.title = "Create book";
        this.prodHint = "";
        this.prod = new Prod();
        this.prodTypes = this.prodService.getProdTypes();
    }

    ngOnInit() {

    }
    //Change Selected Product type callback
    private changeSelectedType(event: any) {


        switch (event.id)
        {
            case ProdTypeEnum.Book.toString():
                this.prodHint="Enter a book's title.."
                break;
            case ProdTypeEnum.Toy.toString():
                this.prodHint = "Enter a toy's name.."
                break;
            default:
                this.prodHint = "";
                break;
        }
    }

    //Save!
    private save() {

        this.prod.TypeId = this.selectedProdType.id;
        this.prod.Type = this.selectedProdType.name;

        // this.prodService.create(this.prod).then(
        //     () => {

        //         var rt = this.router;
        //         swal(
        //             'Success!',
        //             'The data has been saved.',
        //             'success'
        //         ).then(function () {
        //             //Return to Index
        //             rt.navigate(['Basic/Product/Index']);
        //         });

        //     });
    }


    //Back to list (Show list)
    private backToList() {
        this.router.navigate(['Product/Index']);
    }
}



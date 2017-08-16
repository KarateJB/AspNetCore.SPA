import 'rxjs/Rx';
import { Prod } from './../class/prod';
import { ProdType } from './../class/ProdType';
import { Observable } from 'rxjs/Observable';
import { Injectable, Inject } from '@angular/core';
import { Http, Headers, RequestOptions, Response } from '@angular/http';
import { ProdTypeEnum } from '../enum/ProdTypeEnum';
import { Subject } from 'rxjs/Subject';
import { EnumEx } from '../enum/EnumEx';
import { RestapiConfig } from './../../../config/restapi.config.dev';

declare var swal: any; //SweetAlert2 typings definition

@Injectable()
export class ProdService {

    private httpOptions: RequestOptions;
    constructor(
        private http: Http,
        private restapiConfig: RestapiConfig) {

        let headers = new Headers({ 'Content-Type': 'application/json' });
        this.httpOptions = new RequestOptions({ headers: headers });
    }

    //Get Prod types list
    public getProdTypes() {
        let prodTypes: ProdType[] = [];

        //Get name-value pairs from ProdTypeEnum
        let prodTypeEnumList = EnumEx.getNamesAndValues(ProdTypeEnum);

        //Convert name-value pairs to odType[]
        prodTypeEnumList.forEach(pair => {
            let prodType = { 'id': pair.value.toString(), 'name': pair.name };
            prodTypes.push(prodType);
        });

        return prodTypes;

        //return Prod_TYPES;
    }

    public getByKey(key: string) {

    }

    public get(id: string) {

    }

    //Get books
    public getBooks() {
        let uri = this.restapiConfig.getBooksUri;
        return this.http.get(uri, this.httpOptions).map(res=> res.json());
    }
    //Get toys
    public getToys() {
        let uri = this.restapiConfig.getToysUri;
        return this.http.get(uri, this.httpOptions).map(res=> res.json());
    }
    //Get toys
    public getClothes() {
        let uri = this.restapiConfig.getClothesUri;
        return this.http.get(uri, this.httpOptions).map(res=> res.json());
    }

    //Create new Prod
    public create(prod: Prod) {

    }

    //Update a Prod
    public update(prod: Prod) {

    }

    //Remove all Prods
    public removeAll() {

    }

    //Remove a Prod
    public remove(prod: Prod) {

    }


}


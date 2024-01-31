import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { environment } from "../envrionments/environment";


const baseUrl = `${environment.apiBaseUrl}`;

@Injectable({
    providedIn: 'root',
})
export class ProductService {

    constructor(
        private httpClient: HttpClient) {
    }

    loadProducts(): Observable<any> {
        let url = baseUrl + 'Product'
        return this.httpClient.get(url);
    }

    loadUpdatedPrice(currencyCode?:string, conversionValue?:number): Observable<any> {
        let url = baseUrl + `Product/getUpdatedPrice?currencyCode=${currencyCode}&conversionValue=${conversionValue}`
        return this.httpClient.get(url);
    }
}
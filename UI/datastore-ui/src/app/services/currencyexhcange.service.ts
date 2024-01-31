import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { environment } from "../envrionments/environment";


const baseUrl = `${environment.apiBaseUrl}`;

@Injectable({
    providedIn: 'root',
})
export class CurrencyExchangeRatesService {

    constructor(
        private httpClient: HttpClient) {
    }

    loadExchangeRates(): Observable<any> {
        let url = baseUrl + 'CurrencyExchange'
        return this.httpClient.get(url);
    }
}
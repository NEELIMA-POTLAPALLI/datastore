import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { environment } from "../envrionments/environment";


const baseUrl = `${environment.apiBaseUrl}`;

@Injectable({
    providedIn: 'root',
})
export class CountryService {

    constructor(
        private httpClient: HttpClient) {
    }

    loadCounteries(): Observable<any> {
        let url = baseUrl + 'Country'
        return this.httpClient.get(url);
    }
}
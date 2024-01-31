import { Component, OnInit } from '@angular/core';
import { ProductService } from './services/product.service';
import { ProductModel } from './models/product.model';
import { CountryService } from './services/country.service';
import { CurrencyExchangeRatesService } from './services/currencyexhcange.service';
import { CountryModel } from './models/country.model';
import { CurrencyExchangeRates } from './models/currencyexchange.model';
import { JsonpInterceptor } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  title = 'datastore-ui';
  productViewModel: ProductModel[] = [];
  countryViewModel: CountryModel[] = [];
  exchangeViewModel: CurrencyExchangeRates[] = [];
  selectedItem?: string;


  constructor(
    private productService: ProductService,
    private countryService: CountryService,
    private exchangeService: CurrencyExchangeRatesService) {
  }

  ngOnInit(): void {
    this.loadProducts();
    this.loadCounteries();
    this.loadExchangeRates();
  }

  loadProducts() {
    this.productService.loadProducts().subscribe((data) => {
      this.productViewModel.splice(0, this.productViewModel.length);
      this.productViewModel = data;
    })
  }

  loadCounteries() {
    this.countryService.loadCounteries().subscribe((data) => {
      this.countryViewModel.splice(0, this.countryViewModel.length);
      this.countryViewModel = data;
      this.selectedItem = this.countryViewModel[0].countryCode;
    })
  }

  loadExchangeRates() {

    localStorage.removeItem("ExchangeRates");

    this.exchangeService.loadExchangeRates().subscribe((data) => {
      this.exchangeViewModel.splice(0, this.exchangeViewModel.length);

      this.exchangeViewModel = data;
      localStorage.setItem("ExchangeRates", JSON.stringify(data));
    })
  }


  onCountryChangeDropdown() {
    var items = JSON.parse(localStorage.getItem("ExchangeRates") as "") as CurrencyExchangeRates[];
    let filteredRecord = items.filter(x => x.currencyCode == this.selectedItem)[0];

    this.productService.loadUpdatedPrice(filteredRecord.currencyCode, filteredRecord.exchangeRate).subscribe((data) => {
      this.productViewModel.splice(0, this.productViewModel.length);
      this.productViewModel = data;
    })
  }
}
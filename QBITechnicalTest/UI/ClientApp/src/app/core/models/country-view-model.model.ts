import { CurrencyViewModel } from './currency-view-model.model';
import { StateViewModel } from './state-view-model.model';

export interface CountryViewModel {
    countryId: number;
    countryName: string;
    countryCodeIso2: string;
    countryCodeIso3: string;
    countryCallingCode: string;
    currencyId: number;
    currency: CurrencyViewModel;
    state: StateViewModel[];
}
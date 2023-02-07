import { CountryViewModel } from './country-view-model.model';
import { StateViewModel } from './state-view-model.model';
import { TechViewModel } from './tech-view-model.model';

export interface ProjectViewModel {
    projectId: number;
    projectCode: string;
    projectName: string;
    countryId: number;
    stateId: number;
    techId: number;
    disabled: boolean;
    updateDate: Date;
    updateUserId: number;
    updateUserName: string;
    country: CountryViewModel;
    state: StateViewModel;
    tech: TechViewModel;
}
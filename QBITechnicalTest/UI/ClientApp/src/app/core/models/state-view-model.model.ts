export interface StateViewModel {
    stateId: number;
    countryId: number;
    stateName: string;
    stateCodeIso2: string;
    stateCodeIso3: string;
    translations: string;
    disabled: boolean;
    updateDate: Date;
    updateUserId: number;
    updateUserName: string;
}
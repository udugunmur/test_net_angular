import { catchError } from 'rxjs';

export function useMock(mock: string) {
    return function (target: any, propertyKey: string, descriptor: PropertyDescriptor) {
        const originalValue = descriptor.value;

        descriptor.value = function () {
            return (<any>this).httpClient.get(`mocks/${mock}.json`).pipe(catchError((error) => {
                return originalValue.apply(this);
            }));
        }
    };
}
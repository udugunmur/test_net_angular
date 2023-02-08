import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
    name: 'transformName'
})
export class TransformNamePipe implements PipeTransform {
    transform( value: string, upper: boolean = true ): string {
      value = value.replace(/\d/g,'').replace(/\s/g,'_');
      return ( upper )
          ? value.toUpperCase()
          : value.toLocaleLowerCase();
    }
}

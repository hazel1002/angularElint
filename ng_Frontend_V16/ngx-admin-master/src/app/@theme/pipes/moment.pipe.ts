import { Pipe, PipeTransform } from '@angular/core';
import * as moment from 'moment';

@Pipe({
  name: 'localDate',
  standalone: true,
})
export class MomentPipe implements PipeTransform {
  transform(value: Date | undefined | moment.Moment, dateFormat: string): any {
    if (value == null || value === undefined) return null;
    const date = moment(value).format(dateFormat);
    const stillUtc = moment.utc(date).toDate();
    return moment(stillUtc).local().format(dateFormat);
  }
}

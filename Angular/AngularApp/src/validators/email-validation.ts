import { Directive } from '@angular/core';
import {
  AbstractControl,
  NG_VALIDATORS,
  ValidationErrors,
  Validator,
} from '@angular/forms';

@Directive({
  selector: '[emailValidator]',
  providers: [
    {
      provide: NG_VALIDATORS,
      useExisting: EmailValidation,
      multi: true,
    },
  ],
})
export class EmailValidation implements Validator {
  validate(control: AbstractControl<any, any>): { [key: string]: any } | null {
    const exp: RegExp = RegExp(/^[A-Za-z0-9._%+-]+@gmail\.com$/g);
    if (!exp.test(control.value)) {
      return { 'invalid-email': true };
    } else {
      return null;
    }
  }
}

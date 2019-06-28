import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroupDirective, NgForm, Validators } from '@angular/forms';
import { ErrorStateMatcher } from '@angular/material/core';

export class GenericErrorStateMatcher implements ErrorStateMatcher {
  isErrorState(control: FormControl | null, form: FormGroupDirective | NgForm | null): boolean {
    const isSubmitted = form && form.submitted;
    return !!(control && control.invalid && (control.dirty || control.touched || isSubmitted));
  }
}

const formRowHeight_Normal = '65px';
const formRowHeight_Tall = '115px';
export class FromComponentBase {
  loading: boolean;
  progress: string
  rowHeight: string;
  textAreaHeight: string;
  matcher = new GenericErrorStateMatcher();
  constructor() {
    this.rowHeight = formRowHeight_Normal;
    this.textAreaHeight = formRowHeight_Tall;
  }
  ngOnInit() {
  }
  startLoading() {
    this.loading = true;
    this.progress = "query";
  }
  startSaving() {
    this.loading = true;
    this.progress = "indeterminate";
  }
  stop() {
    this.loading = false;
  }
  showSuccess(message: string) {

  }
}
``

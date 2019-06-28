import { Component, OnInit } from '@angular/core';
import { FromComponentBase } from '../../app.component_base';
import { WelfareAssociation } from 'src/models/WelfareAssociation.Model';
import { FormGroup, FormBuilder,Validators } from '@angular/forms';
import { CommunityService } from 'src/services/community.service';
import { MatSnackBar } from '@angular/material';
@Component({
  selector: 'app-association-info',
  templateUrl: './association-info.component.html',
  styleUrls: ['./association-info.component.css']
})
export class AssociationInfoComponent extends FromComponentBase {
  association: WelfareAssociation
  associationInfoForm: FormGroup;
  constructor(private formBuilder: FormBuilder, private communityService: CommunityService, private _snackBar: MatSnackBar) {
    super();

    this.associationInfoForm = this.formBuilder.group({
      name: ['', Validators.required],
      number: [''],
      bankName: [''],
      bankAccountNumber: [''],
      bankBranchAddress: [''],
      ifsc: ['']
    });
  }
  ngOnInit() {
  }
  setData(association: WelfareAssociation) {
    this.association = association;
    this.associationInfoForm.patchValue(association);
  }
  value(key: string, value: string = null) {
    if (value != null) {
      this.associationInfoForm.get(key).setValue(value);
    }
    return this.associationInfoForm.get(key).value;
  }
  onSaveClick() {
    //super.startSaving();
    
    var data = this.association;
    console.log(data);
    data.name = this.value("name");
    data.number = this.value("number");
    data.bankName = this.value("bankName");
    data.bankBranchAddress = this.value("bankBranchAddress");
    data.accountNumber = this.value("bankAccountNumber");
    data.ifsc = this.value("ifsc");
    console.log(data.bankBranchAddress);
    this.communityService.saveAssociationInfo(data).subscribe(response => {
      super.stop();
      this._snackBar.open("Successfully saved community association information", "OK", {
        duration: 3000
      });
    });
  }
}

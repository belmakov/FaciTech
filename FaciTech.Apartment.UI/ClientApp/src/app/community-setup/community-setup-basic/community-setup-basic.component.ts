import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { FormControl, FormGroupDirective, NgForm, Validators, FormBuilder, FormGroup } from '@angular/forms';
import { FromComponentBase } from '../../app.component_base';
import { Community, BasicInfo, SelectedLocation } from '../../../models/Community.Model';
import { CommunityService } from 'src/services/community.service';
import { LocationService } from 'src/services/location.service';
import { Location } from '../../../models/Location.Model';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-community-setup-basic',
  templateUrl: './community-setup-basic.component.html',
  styleUrls: ['../community-setup.component.css']
})
export class CommunitySetupBasicComponent extends FromComponentBase {
  @Input() basicInfo: BasicInfo;
  @Output() saved = new EventEmitter<number>();
  basicInfoForm: FormGroup;
  countries: Location[] = null;
  cities: Location[] = null;
  areas: Location[] = null;
  subareas: Location[] = null;
  constructor(private formBuilder: FormBuilder, private communityService: CommunityService,
    private locationService: LocationService, private _snackBar: MatSnackBar) {
    super();
    this.basicInfoForm = this.formBuilder.group({
      name: ['', Validators.required],
      builderName: ['', Validators.maxLength(100)],
      country: ['', Validators.required],
      city: ['', Validators.required],
      area: ['', Validators.required],
      subarea: ['', Validators.required],
      landmark: ['', Validators.maxLength(100)],
      locationLink: [''],
      address: ['']
    });
  }
  value(key: string, value: string = null) {
    if (value != null) {
      this.basicInfoForm.get(key).setValue(value);
    }
    return this.basicInfoForm.get(key).value;
  }
  getCountryId(): number {
    return this.value("country");
  }
  getCityId(): number {
    return this.value("city");
  }
  getAreaId(): number {
    return this.value("area");
  }
  getSubAreaId(): number {
    return this.value("subarea");
  }
  setData(basicInfo: BasicInfo, selectedLocation: SelectedLocation) {
    this.basicInfo = basicInfo;
    this.countries = selectedLocation.countries;
    this.cities = selectedLocation.cities;
    this.areas = selectedLocation.areas;
    this.subareas = selectedLocation.subAeras;
    this.basicInfoForm.patchValue(this.basicInfo);
    this.value("country", selectedLocation.countryId);
    this.value("city", selectedLocation.cityId);
    this.value("area", selectedLocation.areaId);
    this.value("subarea", selectedLocation.subAreaId);
  }
  loadCountries() {
    super.startLoading();
    this.locationService.getCountries().subscribe(countries => {
      this.countries = countries;
      super.stop();
    });
  }
  onCountryChange() {
    super.startLoading();
    this.cities = [];
    this.areas = [];
    this.subareas = [];
    this.locationService.getCities(this.getCountryId()).subscribe(cities => {
      this.cities = cities;
      super.stop();
    });

  }
  onCityChange() {
    super.startLoading();
    this.areas = [];
    this.subareas = [];
    this.locationService.getAreas(this.getCityId()).subscribe(areas => {
      this.areas = areas;
      super.stop();
    });
  }
  onAreaChange() {
    super.startLoading();
    this.subareas = [];
    this.locationService.getSubAreas(this.getAreaId()).subscribe(subAreas => {
      this.subareas = subAreas;
      super.stop();
    })
  }
  onSaveClick() {
    super.startSaving();
    var data = this.basicInfo;
    data.name = this.value("name");
    data.builderName = this.value("builderName");
    data.subAreaId = this.getSubAreaId();
    data.landmark = this.value("landmark");
    data.locationLink = this.value("locationLink");
    data.address = this.value("address");
    this.communityService.saveBasicInfo(data).subscribe(response => {
      super.stop();
      //this.saved.emit(response.id);
      this._snackBar.open("Successfully saved community basic information", "OK", {
        duration: 3000
      });
    });
  }
}

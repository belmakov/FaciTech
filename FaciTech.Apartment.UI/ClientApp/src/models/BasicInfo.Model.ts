import { Location } from '../models/Location.Model';

export class BasicInfo {
  id: number;
  name: string;
  subAreaId: number;
  builderName: string;
  address: string;
  landmark: string;
  locationLink: string;
  constructor() {
    this.id = 0;
  }
}

export class SelectedLocation {
  countries: Location[];
  cities: Location[];
  areas: Location[];
  subAeras: Location[];
  countryId: string;
  cityId: string;
  areaId: string;
  subAreaId: string;
}

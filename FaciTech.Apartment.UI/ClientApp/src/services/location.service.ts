import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { Community } from '../models/Community.Model'
import { Location } from '../models/Location.Model'
import { FaciTechService } from './facitech.service';


@Injectable({
  providedIn: 'root'
})
export class LocationService {
  constructor(private facitechService: FaciTechService) {
  }
  getCountries(): Observable<Location[]> {
    return this.facitechService.get<Location[]>('countries');
  }
  getCities(countryId:number): Observable<Location[]> {
    return this.facitechService.get<Location[]>(`countries/${countryId}/cities`);
  }
  getAreas(citiId: number): Observable<Location[]> {
    return this.facitechService.get<Location[]>(`cities/${citiId}/areas`);
  }
  getSubAreas(areaId: number): Observable<Location[]> {
    return this.facitechService.get<Location[]>(`areas/${areaId}/subareas`);
  }
}


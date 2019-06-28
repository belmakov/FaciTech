import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Community, BasicInfo, WelfareAssociation } from '../models/Community.Model'
import { Location } from '../models/Location.Model'
import { FaciTechService } from './facitech.service';
import { ApiResponse } from 'src/models/ApiResponse.Model';


@Injectable({
  providedIn: 'root'
})
export class CommunityService {
  url: string;
  constructor(private facitechService: FaciTechService) {
    this.url = 'community';
  }
  getCommunityById(id: number): Observable<Community> {
    return this.facitechService.get<Community>(this.url + '/' + id.toString());
  }
  saveBasicInfo(basicInfo: BasicInfo): Observable<ApiResponse> {
    if (basicInfo.id == 0) {
      return this.facitechService.post<ApiResponse>(this.url, basicInfo);
    }
    else {
      return this.facitechService.put<ApiResponse>(this.url + '/' + basicInfo.id.toString(), basicInfo);
    }
  }
  saveAssociationInfo(associationInfo: WelfareAssociation): Observable<ApiResponse> {
    return this.facitechService.put<ApiResponse>(this.url + '/' + associationInfo.id.toString() + "/association", associationInfo);
  }
}


import { Component, OnInit, ViewChild } from '@angular/core';
import { FromComponentBase } from '../app.component_base';
import { ActivatedRoute } from '@angular/router';
import { Community } from '../../models/Community.Model';
import { BasicInfo } from '../../models/BasicInfo.Model';
import { WelfareAssociation } from '../../models/WelfareAssociation.Model';
import { CommunitySetupBasicComponent } from './community-setup-basic/community-setup-basic.component';
import { Location } from '../../models/Location.Model';
import { CommunityService } from '../../services/community.service';
import { AssociationInfoComponent } from './association-info/association-info.component';
import { LocationService } from 'src/services/location.service';

@Component({
  selector: 'app-community-setup',
  templateUrl: './community-setup.component.html',
  styleUrls: ['./community-setup.component.css']
})
export class CommunitySetupComponent extends FromComponentBase {

  communityId: number;
  @ViewChild(CommunitySetupBasicComponent) basicInfoComponent: CommunitySetupBasicComponent;
  @ViewChild(AssociationInfoComponent) associationInfoComponent: AssociationInfoComponent;

  constructor(private route: ActivatedRoute,private communityService : CommunityService,private locationService:LocationService) {
    super();
    this.communityId = 0;
  }
  ngOnInit() {
    this.initData();
    this.route.paramMap.subscribe(params => { this.onParamChange(params)});
  }
  onParamChange(params) {

    let id = params.get('id');
    if (id) {
      this.loadCommunity(id);
    }
    else {
      this.basicInfoComponent.loadCountries();
    }
  }
  initData() {
  }
  loadCommunity(id: number) {
    this.basicInfoComponent.startLoading();
    this.communityService.getCommunityById(id).subscribe(community => {
      this.communityId = community.basicInfo.id;
      this.basicInfoComponent.setData(community.basicInfo, community.selectedLocation);
      community.welfareAssociation.id = this.communityId;
      this.associationInfoComponent.setData(community.welfareAssociation);
      this.basicInfoComponent.stop();
    });
  }
  onBasicInfoSave(id: number) {
    this.communityId = id;
    this.associationInfoComponent.association.id = id;
  }
}



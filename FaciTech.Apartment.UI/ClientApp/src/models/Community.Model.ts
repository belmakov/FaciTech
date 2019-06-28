import { WelfareAssociation } from '../models/WelfareAssociation.Model';
import { BasicInfo, SelectedLocation } from '../models/BasicInfo.Model';

export { BasicInfo };
export { WelfareAssociation };
export { SelectedLocation };
export class Community {
  basicInfo: BasicInfo;
  welfareAssociation: WelfareAssociation;
  selectedLocation: SelectedLocation;
}




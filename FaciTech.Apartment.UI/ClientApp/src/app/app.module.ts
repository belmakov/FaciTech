import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { LayoutModule } from '@angular/cdk/layout';
import { MatToolbarModule, MatButtonModule, MatSidenavModule, MatIconModule, MatListModule, MatTabsModule } from '@angular/material';
import { MatProgressBarModule } from '@angular/material/progress-bar';

import { RouterModule } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { MatMenuModule } from '@angular/material/menu';
import { MatBadgeModule } from '@angular/material/badge';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatTableModule } from '@angular/material/table';
import { MatCardModule } from '@angular/material/card';
import { MatGridListModule } from '@angular/material/grid-list';
import { UserprofileComponent } from './userprofile/userprofile.component';
import { TablelistComponent } from './tablelist/tablelist.component';
import { TypoComponent } from './typo/typo.component';
import { IconsComponent } from './icons/icons.component';
import { MapsComponent } from './maps/maps.component';
import { NotificationComponent } from './notification/notification.component';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { CommunitySideNavComponent } from './community-side-nav/community-side-nav.component';
import { CommunitySetupComponent } from './community-setup/community-setup.component';
import { PeopleComponent } from './people/people.component';
import { AssociationComponent } from './association/association.component';
import { VendorsComponent } from './vendors/vendors.component';
import { CommunitySetupBasicComponent } from './community-setup/community-setup-basic/community-setup-basic.component';
import { HttpClientModule } from '@angular/common/http';
import { AssociationInfoComponent } from './community-setup/association-info/association-info.component';

@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    UserprofileComponent, TablelistComponent, TypoComponent, IconsComponent, MapsComponent, NotificationComponent, CommunitySideNavComponent, CommunitySetupComponent, PeopleComponent, AssociationComponent, VendorsComponent, CommunitySetupBasicComponent, AssociationInfoComponent,

  ],
  imports: [
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    MatTableModule,
    MatSnackBarModule,
    MatCheckboxModule,
    MatInputModule,
    MatSelectModule,
    MatProgressBarModule,
    MatFormFieldModule,
    MatBadgeModule,
    MatMenuModule,
    LayoutModule,
    BrowserModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatButtonModule,
    MatSidenavModule,
    MatGridListModule,
    MatCardModule,
    MatTabsModule,
    MatIconModule,
    MatListModule,
    RouterModule,
    RouterModule.forRoot([
      {
        path: 'community-setup/:id',
        component: CommunitySetupComponent
      },
      {
        path: 'community-setup',
        component: CommunitySetupComponent
      },
      {
        path: 'people',
        component: PeopleComponent
      },
      {
        path: 'association',
        component: AssociationComponent
      },
      {
        path: 'vendors',
        component: VendorsComponent
      },
      {
        path: 'icons',
        component: IconsComponent
      },
      {
        path: 'maps',
        component: MapsComponent
      },
      {
        path: 'notify',
        component: NotificationComponent
      }
    ]),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

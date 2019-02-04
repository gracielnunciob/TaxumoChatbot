import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { LoginComponent } from './login/login.component';
import { DetailsComponent } from './details/details.component';
import { TermsComponent } from './terms/terms.component';


const appRoutes: Routes = [
 // { path: '', component: LoginComponent, pathMatch: 'full' },
  { path: 'fetch-data', component: FetchDataComponent },
  { path: 'details', component: DetailsComponent },
  { path: 'login', component: LoginComponent },
  { path: 'terms', component: TermsComponent },

];

@NgModule({
  
  declarations: [
    AppComponent,
    HomeComponent,
    FetchDataComponent,
    LoginComponent,
    DetailsComponent,
    TermsComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(appRoutes)
  ],
  exports: [RouterModule],
  bootstrap: [AppComponent]
})
export class AppModule { }

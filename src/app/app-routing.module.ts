import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ContactComponent } from './contact/contact.component';
import { ViewbookingComponent } from './viewbooking/viewbooking.component';
import { AddbookingComponent } from './addbooking/addbooking.component';
import { EditbookingComponent } from './editbooking/editbooking.component';

const routes: Routes = [

{
  path:'home',component:HomeComponent
},
{
  path:'contact',component:ContactComponent
},
{
  path:'viewbooking',component:ViewbookingComponent
},
{
  path:'addbooking',component:AddbookingComponent
},
{
  path:'bookings/editbooking/:bookingId',component:EditbookingComponent
}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

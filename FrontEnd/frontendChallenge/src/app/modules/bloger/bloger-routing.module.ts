import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeBlogerComponent } from './components/home-bloger/home-bloger.component';
import { TableBlogerComponent } from './components/table-bloger/table-bloger.component';

const routes:Routes = [
  {
    path:"",
    component:HomeBlogerComponent,
    children:[
      {
        path:"All",
        component:TableBlogerComponent
      },
    ]


  }
]
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports:[RouterModule]
})
export class BlogerRoutingModule { }

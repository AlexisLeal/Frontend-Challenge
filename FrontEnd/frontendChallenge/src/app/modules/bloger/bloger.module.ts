import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeBlogerComponent } from './components/home-bloger/home-bloger.component';
import { BlogerRoutingModule } from './bloger-routing.module';
import { TableBlogerComponent } from './components/table-bloger/table-bloger.component';
import { MaterialModule } from '../material/material.module';



@NgModule({
  declarations: [
    HomeBlogerComponent,
    TableBlogerComponent
  ],
  imports: [
    CommonModule,
    MaterialModule,
    BlogerRoutingModule
  ]
})
export class BlogerModule { }

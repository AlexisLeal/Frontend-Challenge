import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NotFoundComponent } from './not-found/not-found.component';
import { MaterialModule } from 'src/app/modules/material/material.module';

@NgModule({
  declarations: [NotFoundComponent],
  imports: [
    CommonModule,
    MaterialModule,
  ],
  exports:[NotFoundComponent]
})
export class SharedModule { }

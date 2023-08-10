import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './modules/auth/components/login/login.component';

const routes: Routes = [
  {
    path:"",
    component:LoginComponent
  },
  {
    path:"blogger",
    loadChildren: () => import('./modules/bloger/bloger.module').then(module => module.BlogerModule)
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

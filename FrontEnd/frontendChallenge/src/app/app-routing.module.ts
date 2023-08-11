import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './modules/auth/components/login/login.component';
import { NotFoundComponent } from './shared/not-found/not-found.component';

const routes: Routes = [
    {
      path:"",
      component:LoginComponent
    },
    {
      path:"blogger",
      loadChildren: () => import('./modules/bloger/bloger.module').then(module => module.BlogerModule)
    },
    {
      path: '404',
      component:NotFoundComponent  // Asegúrate de tener un componente llamado NotFoundComponent
    },
    {
      path: "**",
      redirectTo: '/404'
    }
  ];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CreateClienteComponent } from './components/create-cliente/create-cliente.component';
import { CreateUsuarioComponent } from './components/create-usuario/create-usuario.component';
import { HomeClienteComponent } from './components/home-cliente/home-cliente.component';
import { HomeUsuarioComponent } from './components/home-usuario/home-usuario.component';
import { HomeComponent } from './components/home/home.component';
import { ContentComponent } from './components/template/content/content.component';
import { UpdateClienteComponent } from './components/update-cliente/update-cliente.component';
import { UpdateUsuarioComponent } from './components/update-usuario/update-usuario.component';
import { AuthGuard } from './shared/guards/auth/auth.guard';
import { LoginComponent } from './Views/Login/login/login.component';

const routes: Routes = [
  {
    path: 'login',
    component: LoginComponent
  },
  {
    path: '',
    component: ContentComponent, canActivate: [AuthGuard],
    children: [
      {
        path: 'inicio', canActivateChild: [AuthGuard],
        component: HomeComponent
      },
      {
        path: 'home-usuario', canActivateChild: [AuthGuard],
        component: HomeUsuarioComponent
      },
      {
        path: 'novo-usuario', canActivateChild: [AuthGuard],
        component: CreateUsuarioComponent
      },
      {
        path: 'editar-usuario/:id', canActivateChild: [AuthGuard],
        component: UpdateUsuarioComponent
      },
      {
        path: 'home-cliente', canActivateChild: [AuthGuard],
        component: HomeClienteComponent
      },
      {
        path: 'novo-cliente', canActivateChild: [AuthGuard],
        component: CreateClienteComponent
      },
      {
        path: 'editar-cliente/:id', canActivateChild: [AuthGuard],
        component: UpdateClienteComponent
      },
      {
        path: '**', canActivateChild: [AuthGuard], redirectTo: 'inicio'
      }
    ]
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

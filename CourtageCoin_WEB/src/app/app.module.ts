import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

import { MatInputModule } from '@angular/material/input';
import { MatCardModule } from '@angular/material/card';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';

import { NgxMaskModule } from 'ngx-mask';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSnackBarModule } from '@angular/material/snack-bar';

import { LoginComponent } from './Views/Login/login/login.component';
import { FormLoginComponent } from './components/form-login/form-login.component';
import { ContentComponent } from './components/template/content/content.component';
import { HeaderComponent } from './components/template/header/header.component';
import { FooterComponent } from './components/template/footer/footer.component';
import { MenuComponent } from './components/template/menu/menu.component';
import { AuthService } from './shared/services/auth.service';
import { AuthGuard } from './shared/guards/auth/auth.guard';
import { AuthInterceptor } from './shared/helpers/auth.interceptor';
import { HomeComponent } from './components/home/home.component';
import { HomeUsuarioComponent } from './components/home-usuario/home-usuario.component';
import { CreateUsuarioComponent } from './components/create-usuario/create-usuario.component';
import { UpdateUsuarioComponent } from './components/update-usuario/update-usuario.component';
import { HomeClienteComponent } from './components/home-cliente/home-cliente.component';
import { CreateClienteComponent } from './components/create-cliente/create-cliente.component';
import { UpdateClienteComponent } from './components/update-cliente/update-cliente.component';
import { ExtratoComponent } from './components/extrato/extrato.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    FormLoginComponent,
    ContentComponent,
    HeaderComponent,
    FooterComponent,
    MenuComponent,
    HomeComponent,
    HomeUsuarioComponent,
    CreateUsuarioComponent,
    UpdateUsuarioComponent,
    HomeClienteComponent,
    CreateClienteComponent,
    UpdateClienteComponent,
    ExtratoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    MatSnackBarModule,
    MatInputModule,
    MatCardModule,
    MatFormFieldModule,
    MatToolbarModule,
    MatTableModule,
    MatPaginatorModule,
    MatSortModule,
    NgxMaskModule.forRoot()
  ],
  providers: [
    AuthService,
    AuthGuard,
    {provide: HTTP_INTERCEPTORS, useClass: AuthInterceptor, multi: true}
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

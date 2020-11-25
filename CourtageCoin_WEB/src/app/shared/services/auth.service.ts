import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { Usuario } from '../models/Usuario.model';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private currentUserSubject: BehaviorSubject<Usuario>;
  public currentUser: Observable<Usuario>;

  constructor(
    private http: HttpClient,
    private router: Router
  ) {
    this.currentUserSubject = new BehaviorSubject<Usuario>(JSON.parse(localStorage.getItem('currentUser')));
    this.currentUser = this.currentUserSubject.asObservable();
  }

  public get currentUserValue() : Usuario{
    return this.currentUserSubject.value;
  }

  login(USU_STR_LOGIN: string, USU_STR_SENHA: string){
    return this.http.post<Usuario>(`${environment.baseUrl}/usuario/login`, {USU_STR_LOGIN, USU_STR_SENHA})
      .pipe(
        map(user => {
          localStorage.setItem('currentUser', JSON.stringify(user));
          localStorage.setItem('user', USU_STR_LOGIN);
          this.currentUserSubject.next(user);
          return user;
        })
      )
  }

  logout(){
    localStorage.removeItem('currentUser');
    this.currentUserSubject.next(null);
    this.router.navigate(['/login']);
  }

}

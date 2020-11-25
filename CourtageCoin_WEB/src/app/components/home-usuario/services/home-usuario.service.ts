import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Usuario } from 'src/app/shared/models/Usuario.model';
import { AlertService } from 'src/app/shared/services/alert.service';
import { environment } from 'src/environments/environment';
import { map } from 'rxjs/operators';
import { Perfil } from 'src/app/shared/models/Perfil.model';

@Injectable({
  providedIn: 'root'
})
export class HomeUsuarioService {

  constructor(
    private http: HttpClient,
    private alertService: AlertService
  ) { }

  read(): Observable<Usuario[]>{
    return this.http.get<Usuario[]>(`${environment.baseUrl}/usuario`).pipe(
      map((obj) => obj)
    )
  }

  getPerfil() : Observable<Perfil[]>{
    return this.http.get<Perfil[]>(`${environment.baseUrl}/perfil`).pipe(
      map((obj) => obj)
    )
  }
}

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Usuario } from 'src/app/shared/models/Usuario.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class UpdateUsuarioService {

  constructor(private http: HttpClient) { }

  readById(id: number): Observable<Usuario>{
    const url = `${environment.baseUrl}/usuario/${id}`;
    return this.http.get<Usuario>(url).pipe(
      map(obj => obj)
    );
  }

  update(usuario): Observable<Usuario>{
    const url = `${environment.baseUrl}/usuario/${usuario.USU_INT_ID}`;
    return this.http.put<Usuario>(url, usuario).pipe(
      map((obj) => obj)
    );
  }
}

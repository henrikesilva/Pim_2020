import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Transacao } from 'src/app/shared/models/Transacao.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ExtratoService {

  constructor(
    private http: HttpClient
  ) { }

  readByID(id): Observable<Transacao[]>{
    return this.http.get<Transacao[]>(`${environment.baseUrl}/transacao/${id}`).pipe(
      map((obj) => obj)
    )
  }

}

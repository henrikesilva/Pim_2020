import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Cliente } from 'src/app/shared/models/Cliente.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class UpdateClienteService {

  constructor(private http: HttpClient) { }

  readById(id: number): Observable<Cliente>{
    const url = `${environment.baseUrl}/cliente/${id}`;
    return this.http.get<Cliente>(url).pipe(
      map(obj => obj)
    );
  }

  update(cliente): Observable<Cliente>{
    const url = `${environment.baseUrl}/cliente/${cliente.CLI_INT_ID}`;
    return this.http.put<Cliente>(url, cliente).pipe(
      map((obj) => obj)
    );
  }
}

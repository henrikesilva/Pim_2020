import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Cliente } from 'src/app/shared/models/Cliente.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class HomeClienteService {

  constructor(
    private http: HttpClient
  ) { }

  read(): Observable<Cliente[]>{
    return this.http.get<Cliente[]>(`${environment.baseUrl}/cliente`).pipe(
      map((obj) => obj)
    )
  }
}

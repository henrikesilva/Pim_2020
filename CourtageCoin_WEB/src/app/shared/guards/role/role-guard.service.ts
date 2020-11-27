import { Injectable } from '@angular/core';
import { ActivatedRoute, ActivatedRouteSnapshot, CanActivate, Router } from '@angular/router';
import { AlertService } from '../../services/alert.service';

@Injectable({
  providedIn: 'root'
})

export class RoleGuardService implements CanActivate{

  constructor(
    private alertService: AlertService,
    private router: Router
  ) { }

  canActivate(route: ActivatedRouteSnapshot) : boolean{
    const localUser = localStorage.getItem('currentUser');
    const expectedRole = route.data.expectedRole;

    var tipoAcesso = JSON.parse(localUser);
    if(tipoAcesso.permissao === expectedRole){      
      return true;
    }
    if(tipoAcesso.permissao === 'Administrador'){
      return true;
    }
    else{
      this.alertService.showMessage('Você não tem permissão para acessar essa funcionalidade');
      this.router.navigate(['/inicio']);
      return false;
    }
  }
}

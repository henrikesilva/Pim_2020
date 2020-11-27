import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, Router, RouterStateSnapshot } from '@angular/router';

import { AuthService } from '../../services/auth.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard {

  constructor(
    private authService: AuthService,
    private router: Router
  ) { }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot){
    var localUser = localStorage.getItem('currentUser');
    var permission = this.authService.currentUserValue;

    if(localUser != null){
      if(route.data.roles && route.data.roles.indexof(permission.permissao) === -1){
        this.router.navigate(['/']);
        return false;
      }
      return true;
    }
    else{
      this.router.navigate(['/login'], {
        queryParams: { returnUrl: state.url }
      });
      return false;
    }
  }
}

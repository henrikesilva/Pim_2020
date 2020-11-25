import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { first } from 'rxjs/operators';
import { Usuario } from 'src/app/shared/models/Usuario.model';
import { AlertService } from 'src/app/shared/services/alert.service';
import { AuthService } from 'src/app/shared/services/auth.service';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-form-login',
  templateUrl: './form-login.component.html',
  styleUrls: ['./form-login.component.css']
})
export class FormLoginComponent implements OnInit {

  user: Usuario = {
    USU_STR_LOGIN: null,
    USU_STR_SENHA: null,
    USU_DATA_CADASTRO: null,
    USU_INT_TELEFONE: null,
    USU_STR_EMAIL: null,
    USU_INT_ID: null,
    FUN_INT_ID: null,
    CLI_INT_ID: null,
    PER_INT_ID: null
  }

  returnUrl: string;
  posts: any;

  constructor(
    private router: Router,
    private authService: AuthService,
    private route: ActivatedRoute,
    private http: HttpClient,
    private alert: AlertService
  ) { 
    if(authService.currentUserValue){
      router.navigate(['/']);
    }
  }

  ngOnInit(): void {
    this.returnUrl = this.route.snapshot.queryParams[' returnUrl '] || '/';
  }


  getPost() : void{
    this.http.get(`${environment.baseUrl}/usuario/login`).subscribe(res => {
      this.posts = res;
    });
  }

  submit(): void{
    if(this.user.USU_STR_LOGIN === null || this.user.USU_STR_SENHA === null){
      this.alert.showMessage('Por Gentileza Informe o usuário e/ou senha');
    }else{
      this.authService.login(this.user.USU_STR_LOGIN, this.user.USU_STR_SENHA)
        .pipe(first())
        .subscribe(form => {
          this.router.navigate(['/inicio']);
        },
        error =>{
          this.alert.showMessage('Usuario ou Senha Incorretos');
        }
      )
    }
  }
}

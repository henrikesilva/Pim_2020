import { Perfil } from './Perfil.model';

export class Usuario{
    USU_INT_ID: number;
    USU_STR_LOGIN: string;
    USU_STR_SENHA: string;
    USU_INT_TELEFONE: number;
    USU_STR_EMAIL: string;
    USU_DATA_CADASTRO: number;
    FUN_INT_ID: number;
    CLI_INT_ID: number;
    PER_INT_ID: number;

    permissao: string;
}
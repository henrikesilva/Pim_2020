import { TestBed } from '@angular/core/testing';

import { CreateUsuarioService } from './create-usuario.service';

describe('CreateUsuarioService', () => {
  let service: CreateUsuarioService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CreateUsuarioService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

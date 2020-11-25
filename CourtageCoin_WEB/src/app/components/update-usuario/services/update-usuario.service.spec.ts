import { TestBed } from '@angular/core/testing';

import { UpdateUsuarioService } from './update-usuario.service';

describe('UpdateUsuarioService', () => {
  let service: UpdateUsuarioService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(UpdateUsuarioService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

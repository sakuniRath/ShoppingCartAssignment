import { TestBed } from '@angular/core/testing';

import { PayamentConfirmationService } from './payament-confirmation.service';

describe('PayamentConfirmationService', () => {
  let service: PayamentConfirmationService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PayamentConfirmationService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

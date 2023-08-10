import { TestBed } from '@angular/core/testing';

import { BlogersService } from './blogers.service';

describe('BlogersService', () => {
  let service: BlogersService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(BlogersService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

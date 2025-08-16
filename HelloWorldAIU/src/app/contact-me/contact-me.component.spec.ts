import { TestBed } from '@angular/core/testing';
import { FormsModule } from '@angular/forms';
import { ContactMeComponent } from './contact-me.component';

describe('ContactMeComponent', () => {
  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FormsModule],
      declarations: [ContactMeComponent]
    }).compileComponents();
  });

  it('should create', () => {
    const fixture = TestBed.createComponent(ContactMeComponent);
    const component = fixture.componentInstance;
    expect(component).toBeTruthy();
  });
});
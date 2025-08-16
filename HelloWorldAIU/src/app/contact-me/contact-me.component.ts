import { Component } from '@angular/core';

@Component({
  selector: 'app-contact-me',
  templateUrl: './contact-me.component.html',
  styleUrls: ['./contact-me.component.css']
})
export class ContactMeComponent {
  messageSent = false;
  formData = {
    name: '',
    email: '',
    message: ''
  };

  onSubmit(form: any) {
    if (form.valid) {
      this.messageSent = true;
    }
  }

  sendAnother() {
    this.messageSent = false;
    this.formData = { name: '', email: '', message: '' };
  }
}
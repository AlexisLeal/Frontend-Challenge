import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { BlogersService } from 'src/app/core/blogers.service';
import { UserAuth } from 'src/app/core/models/UserAuthInputModel';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.sass']
})

export class LoginComponent {
  
 public readonly myForm: FormGroup;

  constructor(private fb: FormBuilder,private service:BlogersService,private router: Router ){
    this.myForm = this.fb.group({
      username: ['', [Validators.required]],
      password: ['', [Validators.required,]]
    });
  }

  public onSubmit():void{
    if(!this.myForm.valid) return;
    let data = new UserAuth(this.myForm.get('username')?.value,this.myForm.get('password')?.value)
    this.service.login(data).subscribe(resp =>{
      if(!resp) return;
      this.router.navigate(["/blogger"]);

    });
  }

  

}

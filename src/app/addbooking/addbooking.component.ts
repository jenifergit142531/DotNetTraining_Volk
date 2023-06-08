import { Component,OnInit } from '@angular/core';
import { BookingService } from '../services/booking.service';
import { Router } from '@angular/router';
import { Booking } from 'src/Model/booking.model';

@Component({
  selector: 'app-addbooking',
  templateUrl: './addbooking.component.html',
  styleUrls: ['./addbooking.component.css']
})
export class AddbookingComponent implements OnInit {

  addBookingRequest:Booking={
   bookingId:'',
   movieName:'',
   price:0,
   seats:0
  };
  constructor(private bookingservice:BookingService,private router:Router){}
   
  ngOnInit(): void {
    
  }

  addBooking()
  {
    this.bookingservice.addBooking(this.addBookingRequest)
    .subscribe({
      next:(booking)=>
      {
        this.router.navigate(['viewbooking']);
        console.log(booking);
      },
      error:(response)=>
      {
        console.log(response);
      }
    })
  }


}

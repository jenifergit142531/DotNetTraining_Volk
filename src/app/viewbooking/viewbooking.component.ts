import { Component,OnInit } from '@angular/core';
import { BookingService } from '../services/booking.service';
import { Booking } from 'src/Model/booking.model';

@Component({
  selector: 'app-viewbooking',
  templateUrl: './viewbooking.component.html',
  styleUrls: ['./viewbooking.component.css']
})
export class ViewbookingComponent implements OnInit {
bookings:Booking[]=[];

constructor(private bookingservice:BookingService)
{

}

ngOnInit():void{
  this.bookingservice.getAllBooking()
  .subscribe({
    next:(bookings)=>
    {
      this.bookings=bookings;
    },
    error:(response)=>
    {
      console.log(response);
    }
  })
}

}

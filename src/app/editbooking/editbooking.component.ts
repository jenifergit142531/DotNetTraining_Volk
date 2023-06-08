import { Component,OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Booking } from 'src/Model/booking.model';
import { BookingService } from '../services/booking.service';

@Component({
  selector: 'app-editbooking',
  templateUrl: './editbooking.component.html',
  styleUrls: ['./editbooking.component.css']
})
export class EditbookingComponent implements OnInit {

  bookingDetails:Booking={
      bookingId:'',
      movieName:'',
      price:0,
      seats:0
  };

  constructor(private route:ActivatedRoute,private bookingservice:BookingService,private router:Router){}

  ngOnInit(): void {
    
    this.route.paramMap.subscribe({
      next:(params)=>
      {
        const bookingId=params.get('bookingId');
        if(bookingId)
        {
          this.bookingservice.getBooking(bookingId)
          .subscribe({
            next:(response)=>
            {
              this.bookingDetails=response;
            }
          })
        }
      }
    })

  }

  updateBooking()
  {
    this.bookingservice.updateBooking(this.bookingDetails.bookingId,this.bookingDetails)
    .subscribe({
      next:(response)=>
      {
        this.router.navigate(['viewbooking']);
      },
      error:(response)=>
      {
        console.log(response);
      }

      
  });
}

  deleteBooking(bookingId:string)
  {
    this.bookingservice.deleteBooking(bookingId)
    .subscribe({
      next:(response)=>
      {
        this.router.navigate(['viewbooking']);
      }
    })


  }
      
}




  
  





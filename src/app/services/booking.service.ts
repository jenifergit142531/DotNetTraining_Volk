import { Injectable } from '@angular/core';
import { environment } from 'src/main';
import {HttpClient} from '@angular/common/http'
import { Booking } from 'src/Model/booking.model';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class BookingService {

  //baseApiUrl:string = environment.baseApiUrl;

  baseApiUrl:string ='https://localhost:7089';


  constructor(private http:HttpClient) { }

  getAllBooking():Observable<Booking[]>
  {
    return this.http.get<Booking[]>(this.baseApiUrl+'/api/booking');
  }

  addBooking(addBookingRequest:Booking):Observable<Booking>
  {
    addBookingRequest.bookingId='00000000-0000-0000-0000-000000000000';
    return this.http.post<Booking>(this.baseApiUrl+'/api/booking',addBookingRequest);
  }

  getBooking(bookingId:string):Observable<Booking>{
    return this.http.get<Booking>(this.baseApiUrl+'/api/booking/'+bookingId);
  }

  updateBooking(bookingId:string,updateBookingRequest:Booking):Observable<Booking[]>
  {
    return this.http.put<Booking[]>(this.baseApiUrl+'/api/booking/'+bookingId,updateBookingRequest);
  }

  deleteBooking(bookingId:string):Observable<Booking>{
    return this.http.delete<Booking>(this.baseApiUrl+'/api/booking/'+bookingId);
  }
}

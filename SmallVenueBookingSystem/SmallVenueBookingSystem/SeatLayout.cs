//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmallVenueBookingSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class SeatLayout
    {
        public int Id { get; set; }
        public string seat_no { get; set; }
        public string booked_by { get; set; }
        public Nullable<int> Age { get; set; }
        public string partially_enabled { get; set; }
        public string booking_date { get; set; }
        public Nullable<bool> isAvailable { get; set; }
    }
}

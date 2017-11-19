
using System;
using System.Collections.Generic;

namespace CleanCode.LongParameterList
{
    public class ReservationQuery
    {
        private DateRange dateRange;

        public DateRange DateRange
        {
            get { return dateRange; }
            set { dateRange = value; }
        }
        private User _user;

        public User User
        {
            get { return _user; }
            set { _user = value; }
        }
        private int locationId;

        public int LocationId
        {
            get { return locationId; }
            set { locationId = value; }
        }

        private LocationType locationType;

        public LocationType LocationType
        {
            get { return locationType; }
            set { locationType = value; }
        }
        private int? _customerId;

        public int? CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

    }


    public class DateRange
    {
        private DateTime _dateFrom;

        public DateTime DateFrom
        {
            get { return _dateFrom; }
            set { _dateFrom = value; }
        }
        private DateTime _dateTo;

        public DateTime DateTo
        {
            get { return _dateTo; }
            set { _dateTo = value; }
        }
    }
    public class LongParameterList
    {
        public IEnumerable<Reservation> GetReservations(ReservationQuery query)
        {
            if (query.DateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (query.DateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        public IEnumerable<Reservation> GetUpcomingReservations(ReservationQuery query)
        {
            if (query.DateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (query.DateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        private static Tuple<DateTime, DateTime> GetReservationDateRange(DateRange dateRange, ReservationDefinition sd)
        {
            if (dateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (dateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        public void CreateReservation(DateRange dateRange, int locationId)
        {
            if (dateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (dateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }
    }

    internal class ReservationDefinition
    {
    }

    public class LocationType
    {
    }

    public class User
    {
        public object Id { get; set; }
    }

    public class Reservation
    {
    }
}

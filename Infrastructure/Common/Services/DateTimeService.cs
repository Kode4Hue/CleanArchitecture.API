using NodaTime;

namespace Infrastructure.PetrolPrices.Services
{
    public class DateTimeService
    {
        public ZonedDateTime GetZonedDateTime(Instant instant, string timezone)
        {
            return instant.InZone(DateTimeZoneProviders.Tzdb[timezone]);
        }
    }
}

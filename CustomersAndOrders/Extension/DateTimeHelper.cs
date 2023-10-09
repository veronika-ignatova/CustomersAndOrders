namespace Core.Extension
{
    public static class DateTimeHelper
    {
        public static bool EquilBirthDay(this DateTime masterDate, DateTime slaveDate)
        {
            return masterDate.Month == slaveDate.Month && masterDate.Day == slaveDate.Day;
        }
    }
}

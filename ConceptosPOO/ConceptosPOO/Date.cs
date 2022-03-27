namespace ConceptosPOO
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month, int day)
        {
            _year = year;
            _month = CheckMonth(month);
            _day = CheckDay(year, month, day);
        }

        private int CheckDay(int year, int month, int day)
        {
            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }

            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (day >= 1 && day <= daysPerMonth[month])
            {
                return day;
            }

            throw new DayException($"Invalid day: {day}");
        }

        private bool IsLeapYear(int year)
        {
            // ==== Manera FEA ====
            //if (year % 4 == 0) // es multiplo de 4
            //{
            //    if (year % 100 == 0) // es multiplo de 100
            //    {
            //        if (year % 400 == 0)
            //        {
            //            // es viciesto
            //            return true; ;
            //        }
            //        else
            //        {
            //            // no es viciesto
            //            return false;
            //        }
            //    }
            //    else
            //    {
            //        // es viciesto
            //        return true;
            //    }
            //}
            //else
            //{
            //    // no es viciesto
            //    return false;
            //}

            // ==== Manera ELEGANTE ====
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }

        private int CheckMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }
            throw new MonthException($"Invalid month:{month}");
        }

        public override string ToString()
        {
            // return base.ToString();// ejecuta el metodo de la clase padre
            // ==== Forma Fea: ====
            // return _year + "/" + _month + "/" + _day; 
            // Imprime: 2022/2/11

            // ==== Forma Linda: ====
            // Iterpolacion
            // return $"{_year}/{_month}/{_day}"; 
            // Imprime: 2022/2/11

            // Formateo Iterpolacion 
            // Se rellena con ceros: el mes y el dia.
            return $"{_year}/{_month:00}/{_day:00}";
            // Imprime: 2022/02/11
        }
    }
}

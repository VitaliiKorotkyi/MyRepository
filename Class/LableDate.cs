using System;

namespace Spisok_Del_TryToDo.Class
{
    internal class LableDate
    {
        private string Day;
        private string Month;
        private int DayOfMonth;
        private int Year;

        public LableDate()
        {
            // Получаем текущую дату
            DateTime currentDate = DateTime.Now;

            // Определяем день недели на английском языке
            Day = currentDate.ToString("dddd");

            // Определяем месяц в нужном формате
            Month = currentDate.ToString("MMMM");

            // Получаем число месяца
            DayOfMonth = currentDate.Day;

            // Получаем год
            Year = currentDate.Year;
        }

        public string LableDateSet()
        {
            // Форматируем дату в строку
            string formattedDate = $"{Day}, {Month} {DayOfMonth}, {Year}";
            return formattedDate;
        }
    }
}

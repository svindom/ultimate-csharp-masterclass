var medicalAppointment = new MedicalAppointment("Alex Johansson", new DateTime(2023, 4, 3));

// overwrite month and a day
medicalAppointment.OverwriteMonthAndDay(5,1);

//add a given number of month and days
medicalAppointment.MoveByMonthAndDays(1,2);


Console.ReadKey();

class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }
    public void Reschedual (DateTime date)
    {
        _date = date;
    }

    public void OverwriteMonthAndDay(int month, int day)
    {
        _date = new DateTime(_date.Year, month, day);
    }

    public void MoveByMonthAndDays(int monthsToAdd, int daysToAdd)
    {
        _date = new DateTime(_date.Year, _date.Month + monthsToAdd, _date.Day + daysToAdd);
    }
}

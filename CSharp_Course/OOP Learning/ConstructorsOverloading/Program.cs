


using static System.Runtime.InteropServices.JavaScript.JSType;

Console.ReadKey();

class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    public MedicalAppointment(string patientName) :
        this(patientName, 7)
    {
    }

    public MedicalAppointment(string patientName, int daysFromNow)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(daysFromNow);
    }

    public void Reschedual(DateTime date)
    {
        _date = date;
    }
}


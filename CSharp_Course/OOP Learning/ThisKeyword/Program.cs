var medicalAppointment = new MedicalAppointment("Alex Johansson", new DateTime(2023, 4, 3));

medicalAppointment.Reschedual(new DateTime(2023, 4, 4));

Console.ReadKey();

class MedicalAppointmentPrinter
{
    public void Print (MedicalAppointment medicalAppointment)
    {
        Console.WriteLine($"Appointment will take place on {medicalAppointment.GetDate()}");
    }
}

class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

    public DateTime GetDate() => _date;

    public void Reschedual(DateTime date)
    {
        _date = date;
        MedicalAppointmentPrinter printer = new MedicalAppointmentPrinter();
        printer.Print(this);
    }
}
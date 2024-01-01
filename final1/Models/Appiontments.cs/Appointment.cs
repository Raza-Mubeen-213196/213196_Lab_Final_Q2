public class Appointment
{
    public int id { get; set; }
    public int patient_id { get; set; }
    public int Doctor_id { get; set; }
    public DateOnly Apointment_Date { get; set; }
    public TimeSpan Appointment_Time { get; set; }
    public patient patient { get; set; }
    public Doctors Doctors { get; set; }

}
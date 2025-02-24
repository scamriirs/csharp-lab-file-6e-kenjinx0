/* Write a program to automate the Admission letter of the university using abstract class:- 
    In the offer letter { Student name, Fees, Course may vary}
    { College name, College Address, College Branding, College Disclaimer will be same} */

using System;
abstract class AdmissionLetter {
    protected const string CollegeName = "ABC University";
    protected const string CollegeAddress = "XYZ City, India";
    protected const string CollegeBranding = "Best place to make your dream come true";
    protected const string CompanyDisclaimer = "This Admission letter is confidential and intended solely for the recipient.If it does not belong to you, please return it to the above-mentioned address.";

    public abstract void GenerateAdmissionLetter();

    protected void PrintAdmissionDetails()
    {
        Console.WriteLine($"College: {CollegeName}\nAddress: {CollegeAddress}\nBranding: {CollegeBranding}\nDisclaimer: {CompanyDisclaimer}\n");
    }
}
class StudentAdmissionDetails : AdmissionLetter {
    private string studentName;
    private string course;
    private double fees;

    public StudentAdmissionDetails(string studentName, string course, double fees) {
        this.studentName = studentName;
        this.course = course;
        this.fees = fees;
    }

    public override void GenerateAdmissionLetter() {
        PrintAdmissionDetails();
        Console.WriteLine("Dear " + studentName + ",\n\n" +
                          "We are pleased to offer you admission to the course: " + course + " at our university.\n" +
                          "The course fees will be: Rs. " + fees + " per annum.\n" +
                          "Fees should be paid a month before the beginning of each semester.\n\n" +
                          "Looking forward to having you at our university!\n\n" +
                          "Best Regards,\n" +
                          CollegeName);
    }
}
class Admission {
    static void Main()
    {
        // Creating an admission letter instance
        StudentAdmissionDetails adm = new StudentAdmissionDetails("Kunal Jha", "MCA", 75000);
        adm.GenerateAdmissionLetter();
    }
}

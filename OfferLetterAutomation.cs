/* Write a program to automate the offer letter using abstract class:- 
    In the offer letter { Person name, DOJ, Designation, Salary may vary}
    { Company name, Company Address, Company Branding, Comapny Disclaimer will be same} */

using System;
abstract class OfferLetter {
    protected const string CompanyName = "MR pvt ltd";
    protected const string CompanyAddress = "XYZ";
    protected const string CompanyBranding = "Taking everyone skyhigh with cloud";
    protected const string CompanyDisclaimer = "This offer letter is confidential and intended solely for the recipient.";

    public abstract void GenerateOfferLetter();

    protected void PrintCompanyDetails() {
        Console.WriteLine($"Company: {CompanyName}\nAddress: {CompanyAddress}\nBranding: {CompanyBranding}\nDisclaimer: {CompanyDisclaimer}\n");
    }
}
class EmployeeOfferLetter : OfferLetter {
    private string PersonName;
    private string DOJ;
    private string Designation;
    private double Salary;

    public EmployeeOfferLetter(string personName, string doj, string designation, double salary) {
        PersonName = personName;
        DOJ = doj;
        Designation = designation;
        Salary = salary;
    }
    public override void GenerateOfferLetter() {
        PrintCompanyDetails();
        Console.WriteLine("Dear " + PersonName + ",\n\n" +
                          "We are pleased to offer you the position of " + Designation + " at our company.\n" +
                          "Your joining date will be: " + DOJ + "\n" +
                          "Your salary package will be: Rs" + Salary + " per month.\n\n" +
                          "Looking forward to having you on our team!\n\n" +
                          "Best Regards,\n" +
                          CompanyName);
    }
}
class Offer {
    static void Main() {
        // Creating an offer letter instance
        EmployeeOfferLetter details = new EmployeeOfferLetter("John Doe", "1st March 2025", "Software Engineer", 75000);
        offer.GenerateOfferLetter();
    }
}

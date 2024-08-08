using SRP.Example_One;
using SRP.Example_Three;
using SRP.Example_Two;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount johnsAccount = new BankAccount(123456);
            johnsAccount.Deposit(500);
            johnsAccount.Withdraw(100);
            StatementPrinter printer = new StatementPrinter();
            printer.Print(johnsAccount);
            Console.WriteLine("---------------------------------------");
            Student alice = new Student { Name = "Alice" };
            alice.EnrollCourse("Mathematics");
            alice.AssignGrade("Mathematics", 90);

            alice.EnrollCourse("English");
            alice.AssignGrade("English", 100);

            alice.EnrollCourse("Computer");
            alice.AssignGrade("Computer", 95);

            alice.EnrollCourse("Artifical");
            alice.AssignGrade("Artifical", 85);
            GPACalculator gpaCalc = new GPACalculator();
            TranscriptGenerator transcriptGen = new TranscriptGenerator(gpaCalc);
            transcriptGen.PrintTranscript(alice);

            Console.WriteLine("-----------------------------------------");
            HotelRoom room101 = new HotelRoom { RoomNumber = 101 };
            RoomBookingManager bookingManager = new RoomBookingManager();
            bool isBooked = bookingManager.BookRoom(room101);
            if (isBooked)
            {
                InvoiceGenerator invoiceGen = new InvoiceGenerator();
                string invoice = invoiceGen.GenerateInvoice(room101);
                Console.WriteLine(invoice);
            }

            Console.ReadKey();
        }
    }
}

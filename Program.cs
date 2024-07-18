namespace RegexSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phoneNumber = "09123456789";
            Console.WriteLine(phoneNumber.ValidatePhoneNumber());
            string emailAddress = "shariati402@ut.ac.ir";
            Console.WriteLine(emailAddress.ValidateEmailAddress());
            string urlAddress = "https://bootcamp4.maktabsharif.ir/html5client/join?sessionToken=vmwasqqilz10nomx";
            Console.WriteLine(urlAddress.ValidateUrlAddress());

        }
    }
}

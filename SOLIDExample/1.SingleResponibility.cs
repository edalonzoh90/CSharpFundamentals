using System.Data.SqlClient;
using System.Net.Mail;

namespace SOLIDExample
{
    public class RegisterService
    {
        // Does not follow SRP
        public void RegisterUser(string username)
        {
            if (username == "admin")
                throw new InvalidOperationException();

            SqlConnection connection = new SqlConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO [...]");//Insert user into database. 

            SmtpClient client = new SmtpClient("smtp.myhost.com");
            client.Send(new MailMessage()); //Send a welcome email. 
        }

        public void RegisterUserSRP(string username)
        {
            if (username == "admin")
                throw new InvalidOperationException();

            _userRepository.Insert(...);

            _emailService.Send(...);

        }
    }
}

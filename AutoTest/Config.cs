

namespace AutoTest
{
    public class Config
    {
        public static string BaseUrl = "http://testing.todvachev.com/";
        public static class Credentials
        {
            public static class Valid
            {
                public static string UserName = "ValidUser";
                public static string Password = "asdf1234";
                public static string RepeatPassword = "asdf1234";
                public static string Email = "fer@gmail.com";
            }
            public static class Invalid
            {
                public static class UserName
                {
                    public static string FourCharacteers = "asdf";
                    public static string ThirteenCharacters = "1234567890123";

                }

                public static class Password
                {

                }

                public static class Email
                {

                }
            }
        }
        
        public static class AlertMessages
        {
            public static string SucceddfullLogin = "Succesful login!";
        }
    }
}

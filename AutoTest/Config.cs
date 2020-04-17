

namespace AutoTest
{
    public static class Config
    {
        public static int ElementsWaitingTimeout = 5;
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
                    public static string FourCharacters = "abcd";
                    public static string ThirteenCharacters = "abcdabcdabcda";
                    public static string OnlyLetters = "abcdabcd";
                    public static string OnlyNumbers = "123456789";
                    public static string OnlySpecialSymbols = "$#@%)(*$%#%?><";
                    public static string NoSpecialSymbol = "asd1234";
                }

                public static class Password
                {
                    public static string FourCharacters = "abcd";
                    public static string ThirteenCharacters = "abcdabcdabcda";
                    public static string OnlyLetters = "abcdabcd";
                    public static string OnlyNumbers = "123456789";
                    public static string OnlySpecialSymbols = "$#@%)(*$%#%?><";
                    public static string NoSpecialSymbol = "asd1234";
                }

                public static class Email
                {
                    public static string NoUser = "@example.com";
                    public static string NoAt = "exampleexample.com";
                    public static string NoDomain = "example@";
                    public static string NoExtension = "example@example";
                }
            }
        }
        
        public static class AlertMessages
        {
            public static string UsernameLengthOutOfRange = "User Id should not be empty / length be between 5 to 12";
            public static string PasswordLenghtOutOfRange = "Password should not be empty / length be between 5 to 12";
            public static string SuccessfulLogin = "Succesful login!";

        }
    }
}

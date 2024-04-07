namespace Blog;

    public static class Configuration
    {
        
        // Token - n formatos  JWT = Json Web Token
        public static string JwtKey  = "e821CB75478A4b568471bF5768dC15b4";
        public static string ApiKeyName = "api_key";
        public static string ApiKey = "curso_api_2NSAFI92NAk??321/==";
        public static SmtpConfiguration Smtp = new();
        public class SmtpConfiguration
        {
            public string Host { get; set; }
            public int Port { get; set; } = 25;
            public string UserName { get; set; }
            public string Password { get; set; }    
        }
    }


// backend/JCertPreBackend/Models/User.cs
     namespace JCertPreBackend.Models
     {
         public class User
         {
             public int Id { get; set; }
             public string Username { get; set; }
             public string Password { get; set; } // Demo, không mã hóa
         }
     }
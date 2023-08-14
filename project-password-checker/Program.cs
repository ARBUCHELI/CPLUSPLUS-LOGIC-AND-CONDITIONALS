using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "!@#$%^&*()";
      Console.WriteLine("Enter a password: ");
      string password = Console.ReadLine();
      int score = 0;
      if (password.Length >= minLength) 
      {
        score++;
      }
      if (Tools.Contains(password, uppercase))
      {
        score++;
      }
      if (Tools.Contains(password, lowercase))
      {
        score++;
      }
      if (Tools.Contains(password, digits)) 
      {
        score++;
      }
      if (Tools.Contains(password, specialChars))
      {
        score++;
      }
      Console.WriteLine(score);
      switch(score)
      {
        case 4:
        case 5:
          Console.WriteLine("Password extremely strong");
        break;
        case 3:
          Console.WriteLine("The password is strong");
        break;
        case 2:
          Console.WriteLine("The password is medium");
        break;
        case 1:
          Console.WriteLine("The password is weak");
        break;
        default:
          Console.WriteLine("The password doesn't meet any of the standards");
        break;
      }
    }
  }
}

using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

      Console.Write("Enter your message: ");
      string userMessage = Console.ReadLine().ToLower();
     
     //Convert the captured string to an array of characters
  
     char [] secretMessage = userMessage.ToCharArray();
     Console.WriteLine(secretMessage);
   
   //same length as sercretmessage
    char [] encryptedMessage = new char[secretMessage.Length];

  // loop each letter in secretMessag
     for(int i = 0; i<secretMessage.Length; i++)
     {
       char letter = secretMessage[i];
     
       //The IndexOf() method takes two arguments: alphabet arr, letter
       int charIndex = Array.IndexOf(alphabet,letter);
       
       //move three letters to the right
       //26 letters in alphabet array
        int shiftedIndex = (charIndex + 3) % 26;
      
        //find new letter position in the  alphabet array
        char newLetter = alphabet[shiftedIndex];
        
        //add the encrypted letter in encryptedMessage
        encryptedMessage[i] = newLetter;
     
     }
        string msgString = String.Join("",encryptedMessage);
        Console.WriteLine(msgString);
      
    }
  }
}

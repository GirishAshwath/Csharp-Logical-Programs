using System;
using System.Collection.Generic;
using System.Text;
public Class Program
{
  public static void Main(string[] args)
  {
    string message = "Programming hello";

    StringBuilder reversedWordString = new StringBuilder();
    List<char> charList = new List<char>();

    for(i =0; i < message.Length; i++)
    {
        if(message[i] == ' ' || i== message.length-1)
        {
            if(i == message.Length-1)
               charList.Add(message[i]);

               for(int j = charList.Count-1; j>=0; j--)
               {
                 reversedWordString.Append(charList[i]);
                }
                reversedWordString.Append(' ');
                charList = new List<char>();
        }
        else
        {
          charList.Add(message[i]);
        }
    }
    Console.WriteLine($"Reversed word string is {reversedWordString}");
  }
}

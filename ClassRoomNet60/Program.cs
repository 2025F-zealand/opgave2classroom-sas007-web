﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class student
{
   public  string Name { get; set; }
        
    public int BirthMonth;

    public int BirthDay;

    public student (string name, int birthMonth, int birthDay) {
        Name = name;
        BirthMonth = birthMonth;
        BirthDay = birthDay;
    }
}
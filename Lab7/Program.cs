﻿namespace Lab7;

class Book //Problem 1
 
{
    private string title;
    private string author; 
    public Book()  //  Default Constructor
    {
        title = "Unknown Title";
        author="Unknown Author";
    }
public Book(string title, string author)
{
    this.title=title;
    this.author=author;
}
    public Book (string title) 

{
    this.title=title;
    this.author="Unknown Author";
}
    public string GetTitle() //Method
    {
        return title;
    }
    public void SetTitle(string newTitle) //Method
    {
        title=newTitle;
    }
    public string GetAuthor()
    {
        return author;
    }
        public void SetAuthor(string newAuthor)
        {
            author=newAuthor;
        }
    }
    
class Program
{
    static void Main(string[] args)
    {
        Book mybook = new Book(); //Problem 1
        Console.WriteLine("Title: " + mybook.GetTitle());  
        mybook.SetTitle("C# Fundamentals");
        Console.WriteLine("Updated Title: " + mybook.GetTitle());  

        Book book2= new Book ("Learning C#"); // Problem 2
        Console.WriteLine("Book 2 Title: " + book2.GetTitle());

        Book book3= new Book ("Advanced C#", "John Doe");// Problem 3
        Console.WriteLine("Book 3 Title: " + book3.GetTitle());
         Console.WriteLine("Book 3 Author: " + book3.GetAuthor());

         Book book4= new Book(); //Problem 4
         book4.SetTitle("Mastering C#");
         book4.SetAuthor("Jane Smith");
         Console.WriteLine("Updated Title: "+book4.GetTitle());
         Console.WriteLine("Updated Author: "+book4.GetAuthor());

    }
}
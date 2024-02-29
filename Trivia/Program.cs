using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Define questions and answers
        Dictionary<string, string> questions = new Dictionary<string, string>
        {
            {"Who discovered America?", "Christopher Colombus"},
            {"What is 5*5?", "25"},
            {"Which year did kenya gain independence?", "1963"},
            {"How many letters are in the alphabet?", "26"},
            {"Which country started world war 1?", "Germany"},


        };
        int score = 0;
        Console.WriteLine("Welcome to the Quiz Game!\n");

        // Iterate through each question
        foreach (var question in questions)
        {
            Console.WriteLine(question.Key);
            string userAnswer = Console.ReadLine(); // Get user's answer

            //Check if the users answer is correct
            if (userAnswer.Trim().ToLower() == question.Value.ToLower())
            {
                Console.WriteLine("Correct!\n");
                score++; // Increment the score if the answer is correct
            }
            else
            {
                Console.WriteLine($"Incorrect! The correct answer is: {question.Value}\n");
            }
        }
        //Display final score
        Console.WriteLine($"Quiz completed your answer is: {score}/{questions.Count}");
    }
}
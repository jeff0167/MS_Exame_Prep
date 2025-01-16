internal class Application
{
    List<string> Questions_Section1 = new List<string>() { "1.1", "1.2", "1.3", "1.4", "1.5", "1.6", "1.7", "1.8", "1.9", "1.10", "1.11" };
    List<string> Questions_Section2 = new List<string>() { "2.1", "2.2", "2.3", "2.4", "2.5", "2.6", "2.7", "2.8", "2.9", "2.10" };
    List<string> Questions_Section3 = new List<string>() { "3.1", "3.2", "3.3", "3.4", "3.5", "3.6", "3.7", "3.8", "3.9", "3.10", "3.11", "3.12" };

    public void Run()
    {
        List<string> chosenQuestions = new List<string>();
        string question;

        Random r = new Random();

        question = ChooseQuestion(Questions_Section1);
        chosenQuestions.Add(question);

        question = ChooseQuestion(Questions_Section2);
        chosenQuestions.Add(question);

        question = ChooseQuestion(Questions_Section3);
        chosenQuestions.Add(question);

        foreach (string item in chosenQuestions)
        {
            Console.WriteLine(item);
        }
        Console.ReadLine();
    }

    string ChooseQuestion(List<string> questions)
    {
        Random r = new Random();
        return questions[r.Next(questions.Count())];
    }
}


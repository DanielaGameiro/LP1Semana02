using System;

namespace ChatGPTMother
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis auxiliares
            string question;

            // Ciclo do-while (4 perguntas reconhecidas pelo Chat)
            do
            {

                // Colocar questão ao utilizador
                Console.Write("Place your question? ");
                question = Console.ReadLine();

                // Switch por padrões
                string response = question switch
                {
                    "How are you?" => "I'm fine, thank you",
                    "What's your name?" => "ChatGPT",
                    "What's your mission?" => "Destroy mankind!",
                    "EXIT" => " ",
                    _ => "You got me, I'm not THAT smart!",
                };

                // Responder adequadamente
                Console.WriteLine(response);
            }

            // Terminar o programa
            while (question != "EXIT");
        }
    }
}
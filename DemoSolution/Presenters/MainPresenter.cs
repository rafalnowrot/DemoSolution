using DemoSolution.Infrastructure;
using System;

namespace DemoSolution
{
    public class MainPresenter
    {
        public static void ShowMenu()
        {
            int exit;
            int option = 0;
            do
            {
                Console.WriteLine("MenuGłówne");
                Console.WriteLine("Podaj co chcesz zrobić wciskając odpowiedni numer:");
                Console.WriteLine("[1].Naprawa Silnika z dodatkami");
                Console.WriteLine("[2].Klienci");
                Console.WriteLine("[3].Samochody");
                Console.WriteLine("[4].Zapisywanie klientów w pliku na pulpicie");

                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        SalePresenter.Sale();
                        break;
                    case 2:
                        ClientPresenter.ShowMenuClient();
                        break;
                    case 3:
                        CarPresenter.ShowMenuCars();
                        break;
                    case 4:
                        FileService.SaveAsTXT();
                        break;
                    default:
                        Console.WriteLine("Podano złą komendę!");
                        break;
                }
                Console.WriteLine("Jeśli chcesz wyjść wciśnie '0'. Jeśli nie, wciśnij dowolną cyfrę");
                exit = Convert.ToInt32(Console.ReadLine());
            } while (exit != 0);
        }
    }
}

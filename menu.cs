using System;
using System.Collections.Generic;

namespace Bus
{
     class Menu
    {
   
        private const int MAIN_MENU_EXIT_OPTION = 6;
        private const int GO_BACK_OPTION = 6;

        List<int> mainMenuOptions = new List<int>(new int[] {1, 2, 3, 4, 5, 6});
        List<int> rutas = new List<int>(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20});

        private string rutaElegida = "1 Alfredo";


        private void DisplayWelcomeMessage() 
        {
            System.Console.WriteLine("¡Bienvenido a Bus station!");
            System.Console.WriteLine();
        }

        private void DisplayMainMenuOptions() 
        {
            System.Console.WriteLine("1) Ingreso de camión");
            System.Console.WriteLine("2) Salida de camión");
            System.Console.WriteLine("3) Exportar/ Imprimir camiones");
            System.Console.WriteLine("4) Ver estadísticas");
            System.Console.WriteLine("5) Borrar información");
            System.Console.WriteLine("6) Salir");
        }

        private void DisplayByeMessage() {
            System.Console.WriteLine("¡Gracias por viajar con nosotros! ¡Hasta luego!");
        }

        private int RequestOption(List<int> validOptions)
         {
            int userInputAsInt = 0;
            bool isUserInputValid = false;

            while(!isUserInputValid) {
                System.Console.WriteLine("Selecciona una opción:");
                string userInput = System.Console.ReadLine();


                try {
                    userInputAsInt = Convert.ToInt32(userInput);
                    isUserInputValid = validOptions.Contains(userInputAsInt);
                } catch (System.Exception) {
                    isUserInputValid = false;
                }


                if (!isUserInputValid)
                {
                    System.Console.WriteLine("La opción seleccionada no es válida.");
                }
            }

            return userInputAsInt;
        }

        private void DisplaySelectRuteMessage() 
        {
            System.Console.WriteLine("Selecciona una ruta");
            System.Console.WriteLine();
        }

        private void DisplaySelectRuteOptions() 
        {
            System.Console.WriteLine("1) 1");
            System.Console.WriteLine("2) 2");
            System.Console.WriteLine("3) 3");
            System.Console.WriteLine("4) 4");
            System.Console.WriteLine("5) 5");
            System.Console.WriteLine("6) 6");
            System.Console.WriteLine("7) 7");
            System.Console.WriteLine("8) 8");
            System.Console.WriteLine("9) 9");
            System.Console.WriteLine("10) 10");
            System.Console.WriteLine("11) 11");
            System.Console.WriteLine("12) 12");
            System.Console.WriteLine("13) 13");
            System.Console.WriteLine("14) 14");
            System.Console.WriteLine("14) 14");
            System.Console.WriteLine("15) 15");
            System.Console.WriteLine("16) 16");
            System.Console.WriteLine("17) 17");
            System.Console.WriteLine("18) 18");
            System.Console.WriteLine("19) 19");
            System.Console.WriteLine("20) 20");
        }

        private void SelectRuteType() 
        {
            int selectedOption = 0;

            while (selectedOption != GO_BACK_OPTION) 
            {
                DisplaySelectRuteMessage();
                DisplaySelectRuteOptions();
                System.Console.WriteLine($"ruta seleccionada: {rutaElegida}");

                selectedOption = RequestOption(rutas);

                switch (selectedOption)
                {
                    case 1: 
                        rutaElegida = "1 Alfredo";
                        break;
                    case 2: 
                        rutaElegida = "2 Benito";
                        break;
                    case 3: 
                        rutaElegida = "3 Carlos";
                        break;
                    case 4: 
                        rutaElegida = "4 Daniel";
                        break;    
                    case 5: 
                        rutaElegida = "5 Erick";
                        break;    
                    case 6: 
                        rutaElegida = "6 Fernando";
                        break;    
                    case 7: 
                        rutaElegida = "7 Gerardo";
                        break;    
                    case 8: 
                        rutaElegida = "8 Hector";
                        break;    
                    case 9: 
                        rutaElegida = "9 Ignacio";
                        break;    
                    case 10: 
                        rutaElegida = "10 Juan";
                        break;    
                    case 11: 
                        rutaElegida = "11 Karmen";
                        break;    
                    case 12: 
                        rutaElegida = "12 Leonardo";
                        break;    
                    case 13: 
                        rutaElegida = "13 Mario";
                        break;    
                    case 14: 
                        rutaElegida = "14 Nanci";
                        break;    
                    case 15: 
                        rutaElegida = "15 Osmar";
                        break;
                    case 16: 
                        rutaElegida = "16 Pablo";
                        break;           
                    case 17: 
                        rutaElegida = "17 Anahi";
                        break;         
                    case 18: 
                        rutaElegida = "18 Ramses";
                        break;        
                    case 19: 
                        rutaElegida = "19 Sara";
                        break;        
                    case 20: 
                        rutaElegida = "20 Tania";
                        break;             
                }
            }
        }

        private void Pay() {
            System.Console.WriteLine("Tu selección es la siguiente:\n");
            System.Console.WriteLine($"rutaElegida => {rutaElegida}");

            System.Console.WriteLine("\n!Gracias por tu preferencia!");
        }

        public void Display()
         {
            int selectedOption = 0;

            DisplayWelcomeMessage();

            while (selectedOption != MAIN_MENU_EXIT_OPTION)
             {
                DisplayMainMenuOptions();

                selectedOption = RequestOption(mainMenuOptions);

                switch (selectedOption)
                {
                    case 1: 
                        SelectRuteType();
                        break;
                    case 6: 
                        Pay();
                        selectedOption = MAIN_MENU_EXIT_OPTION;
                        break;
                }
            }

            DisplayByeMessage();

        }
       
    }
}
    
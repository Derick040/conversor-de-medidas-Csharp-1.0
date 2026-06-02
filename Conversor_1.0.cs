using System;
class Program
{
    static void Main()
    {
        // Variáveis para acesso de dados
        string? readResult;
        string menuSelection = "";
        string tempCoversor = "";
        string kmConversor = "";
        string weightConversor = "";
        string heightConversor = "";

        // flags
        bool closeProgram = false;
        bool exitTempConversion = false;
        bool exitKmConversion = false;
        bool exitWeightConversion = false;
        bool exitHeightConversion = false;

        do
        {
            // Opções do display
            Console.Clear();
            Console.WriteLine("\tCONVERSOR DE MEDIDAS");
            Console.WriteLine();
            Console.WriteLine("1. Conversor de temperaturas");
            Console.WriteLine("2. Conversor de Quilômetragem");
            Console.WriteLine("3. Conversor de pesos");
            Console.WriteLine("4. Conversor de comprimento");
            Console.WriteLine("5. Sair");

            closeProgram = false;

            readResult = Console.ReadLine();
            if (readResult != null)
            {
                menuSelection = readResult.ToLower();
            }

            switch (menuSelection)
            {
                case "1":
                    // Conversão de temperaturas display
                    Console.Clear();
                    Console.WriteLine("1. Converter celsius em fahrenheit");
                    Console.WriteLine("2. Converter fahrenheit em celsius");
                    Console.WriteLine("3. Sair");

                    exitTempConversion = false;

                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        tempCoversor = readResult.ToLower();
                    }
                    do
                    {
                        switch (tempCoversor)
                        {
                            case "1":
                                // Convertendo °C em °F
                                Console.Clear();
                                Console.Write("Digite Sua Temperatura (°C): ");
                                readResult = Console.ReadLine();

                                if (double.TryParse(readResult, out double tempCelsius))
                                {
                                    double resultFahrenheit = (tempCelsius * 1.8) + 32; // Fórmula
                                    Console.WriteLine($"{resultFahrenheit}°F");

                                    Console.WriteLine("Pressione a tecla 'Enter' para sair");
                                    Console.ReadLine();
                                    exitTempConversion = true;
                                }
                                else
                                {
                                    Console.WriteLine($@"""{readResult}"" não é um caractere válido.");
                                    Console.WriteLine("Pressione a tecla 'Enter' para sair.");
                                    Console.ReadLine();
                                }
                                break;

                            case "2":
                                // Convertendo °F em °C
                                Console.Clear();
                                Console.Write("Digite sua temperatura (°F): ");
                                readResult = Console.ReadLine();

                                if (double.TryParse(readResult, out double tempFahrenheit))
                                {
                                    double resultCelsius = (tempFahrenheit - 32) / 1.8; // Fórmula
                                    Console.WriteLine($"{resultCelsius}°C");

                                    Console.WriteLine("Pressione a tecla 'Enter' para sair.");
                                    Console.ReadLine();
                                    exitTempConversion = true;
                                }
                                else
                                {
                                    Console.WriteLine($@"""{readResult}"" não é um caractere válido.");
                                    Console.WriteLine("Pressione a tecla 'Enter' para sair.");
                                    Console.ReadLine();
                                }
                                break;

                            case "3":
                                // Sair Da conversão
                                exitTempConversion = true;
                                break;
                        }
                    } while (exitTempConversion == false);
                    break;

                case "2":
                    // Conversão de Quilometragem display
                    Console.Clear();
                    Console.WriteLine("1. Converter Quilometros em Milhas");
                    Console.WriteLine("2. Converter Milhas em Quilometros");
                    Console.WriteLine("3. Sair");

                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        kmConversor = readResult.ToLower();
                    }
                    do
                    {
                        switch (kmConversor)
                        {
                            case "1":
                                // Converter Quilometros em milhas
                                Console.Clear();
                                Console.Write("Digite a Quilometragem: ");
                                readResult = Console.ReadLine();

                                if (double.TryParse(readResult, out double kmMetragem))
                                {
                                    double resultMilhas = kmMetragem * 0.621371; // Fórmula
                                    Console.WriteLine($"{resultMilhas.ToString("F2")}mi");

                                    Console.WriteLine("Digite a tecla 'Enter' para sair.");
                                    Console.ReadLine();
                                    exitKmConversion = true;
                                }
                                else
                                {
                                    Console.WriteLine($@"""{readResult}""não é um caractere válido");
                                    Console.WriteLine("Pressione a tecla 'Enter' para sair.");
                                    Console.ReadLine();
                                }
                                break;

                            case "2":
                                // Converter Quilômetros em Milhas
                                Console.Clear();
                                Console.Write("Digite o comprimento em Milhas: ");
                                readResult = Console.ReadLine();

                                if (double.TryParse(readResult, out double miMetragem))
                                {
                                    double resultKms = miMetragem * 1.60934; // Fórmula
                                    Console.WriteLine($"{resultKms.ToString("F2")}km");

                                    Console.WriteLine("Pressione a tecla 'Enter' para sair");
                                    Console.ReadLine();
                                    exitKmConversion = true;
                                }
                                else
                                {
                                    Console.WriteLine($@"""{readResult}"" não é um caractere válido");
                                    Console.WriteLine("Pressione a tecla 'Enter' para sair.");
                                    Console.ReadLine();
                                }
                                break;

                            case "3":
                                // Sair da conversão de Quilômetragem
                                exitKmConversion = true;
                                break;
                        }
                    } while (exitKmConversion == false);
                    break;

                case "3":
                    // Conversor de pesos display
                    Console.Clear();
                    Console.WriteLine("1. Converter Quilogramas em Libras");
                    Console.WriteLine("2. Converter Libras em Quilogramas");
                    Console.WriteLine("3. Sair");

                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        weightConversor = readResult.ToLower();
                    }
                    do
                    {


                        switch (weightConversor)
                        {
                            case "1":
                                // Converter Quilogramas em libras
                                Console.Clear();
                                Console.Write("Digite o peso em Kg: ");
                                readResult = Console.ReadLine();

                                if (double.TryParse(readResult, out double lbPeso))
                                {
                                    double resultLb = lbPeso * 2.20462; // Fórmula
                                    Console.WriteLine($"{resultLb.ToString("F2")}lb");

                                    Console.WriteLine("Pressione a tecla 'Enter' para sair");
                                    Console.ReadLine();
                                    exitWeightConversion = true;
                                }
                                else
                                {
                                    Console.WriteLine($@"""{readResult}"" não é um caractere válido");
                                    Console.WriteLine("Pressione a tecla 'Enter' para sair");
                                    Console.ReadLine();
                                }
                                break;

                            case "2":
                                // Converter libras em Quilogramas
                                Console.Clear();
                                Console.Write("Digite o peso em lb: ");
                                readResult = Console.ReadLine();

                                if (double.TryParse(readResult, out double kgPeso))
                                {
                                    double resultKg = kgPeso * 0.45359; // Fórmula
                                    Console.WriteLine($"{resultKg.ToString("F2")}Kg");

                                    Console.WriteLine("Pressione a tecla 'Enter' para sair");
                                    Console.ReadLine();
                                    exitWeightConversion = true;
                                }
                                else
                                {
                                    Console.WriteLine($@"""{readResult}"" não é um caractere válido");
                                    Console.WriteLine("Pressione a tecla 'Enter' para sair");
                                    Console.ReadLine();
                                }
                                break;

                            case "3":
                                exitWeightConversion = true;
                                break;
                        }
                    } while (exitWeightConversion == false);
                    break;

                case "4":
                    // Conversor de comprimentos display
                    Console.Clear();
                    Console.WriteLine("1. Converter metros em pés");
                    Console.WriteLine("2. Converter pés em metros");
                    Console.WriteLine("3. Sair");

                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        heightConversor = readResult.ToLower();
                    }

                    do
                    {
                        switch (heightConversor)
                        {
                            case "1":
                                // Converter Metros em pés
                                Console.Clear();
                                Console.Write("Digite o comprimento em metros: ");
                                readResult = Console.ReadLine();

                                if (double.TryParse(readResult, out double ftHeight))
                                {
                                    double resultFt = ftHeight * 3.28; // Fórmula
                                    Console.WriteLine($"{resultFt.ToString("F2")}ft");

                                    Console.WriteLine("Pressione a tecla 'Enter' para sair");
                                    Console.ReadLine();
                                    exitHeightConversion = true;
                                }
                                else
                                {
                                    Console.WriteLine($@"""{readResult}"" não é um caractere válido");
                                    Console.WriteLine("Pressione a tecla 'Enter' para sair");
                                    Console.ReadLine();
                                }
                                break;

                            case "2":
                                // Converter pés em metros
                                Console.Clear();
                                Console.Write("Digite o comprimento em pés: ");
                                readResult = Console.ReadLine();

                                if (double.TryParse(readResult, out double mHeight))
                                {
                                    double resultM = mHeight * 0.304; // Fórmula
                                    Console.WriteLine($"{resultM.ToString("F2")}m");

                                    Console.WriteLine("Pressione a tecla 'Enter' para sair");
                                    Console.ReadLine();
                                    exitHeightConversion = true;
                                }
                                else
                                {
                                    Console.WriteLine($@"""{readResult}"" não é um caractere válido");
                                    Console.WriteLine("Pressione a tecla 'Enter' para sair");
                                    Console.ReadLine();
                                }
                                break;

                            case "3":
                                exitHeightConversion = true;
                                break;
                        }
                    } while (exitHeightConversion == false);
                    break;

                case "5":
                    closeProgram = true;
                    break;
            }

        } while (closeProgram == false);
    }
}
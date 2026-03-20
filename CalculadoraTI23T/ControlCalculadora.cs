using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI23T
{
    class ControlCalculadora
    {
        //Variáveis Globais
        ModelCalculadora model;//Começando a conectar a control e a model

        //Construtor vazio da classe ModelCalculadora

        public ControlCalculadora()
        { 
            this.model = new ModelCalculadora();//Efetivando a ligação com a Model
        }//fim do construtor vazio

        public ControlCalculadora(double num1, double num2) 
        {
            this.model = new ModelCalculadora(num1, num2);
        }//fim do construtor com parâmetros

        //Método de Menu

        public string mostrarMenu()
        {
            return "--------- Menu ---------\n\n"                        +
                "Escolha uma das opções abaixo: \n"                      +
                "0. Sair\n"                                              +
                "1. Somar\n"                                             +
                "2. Subtrair\n"                                          +
                "3. Multiplicar\n"                                       +
                "4. Dividir\n"                                           +
                "5. Potência\n"                                          +
                "6. Raiz Primeiro Número\n"                              +
                "7. Raiz Segundo Número\n"                               +
                "8. Tabuada\n"                                           +
                "9. Ano Bissexto\n"                                      +
                "10. Número entre um intervalo de 100 e 200\n"           +
                "11. Verificação de Idade para Voto\n"                   +
                "12. Número entre um intervalo\n"                        +
                "13. 10 maiores valores já lidos\n"                      +
                "14. Triângulo Equilátero, Isóceles ou escaleno?\n"      +
                "15. Senha\n"                                            +
                "16. Horários\n"                                         +
                "17. Maior número\n"                                     +
                "18. Média de 5 números\n"                               +
                "19. Somando até 100\n"                                  +
                "20. Senha válida\n"                                     +
                "21. Maior e menor número entre 10 números\n"            +
                "22. Classificação de idade\n"                           +
                "23. Cálculo do IMC\n"                                   +
                "24. Número positivo, negativo ou zero?\n"               +
                "25. Par ou Ímpar?\n"                                    +
                "26. Maior, menor, média soma e potência de 3 números\n" +
                "27. Tarifa do ônibus baseada em idade\n";
        }//fim do método

        public void realizarOperacao()
        {
            int opcao = 0;//Declarar do lado de fora do do...while()
            do
            {
                Console.WriteLine(this.mostrarMenu());//Chamar o Menu
                opcao = Convert.ToInt32(Console.ReadLine());//Leia
               
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;//Encerra a execução
                    case 1:
                        this.coletar();//Pegar o que o usuario está digitando
                        Console.WriteLine("A soma é: " + this.model.somar());
                        break;//Encerra a execução
                    case 2:
                        this.coletar();//Pegar o que o usuario está digitando
                        Console.WriteLine("A subtração é: " + this.model.subtrair());
                        break;//Encerra a execução
                    case 3:
                        this.coletar();//Pegar o que o usuario está digitando
                        Console.WriteLine("A multiplicação é: " + this.model.multiplicar());
                        break;//Encerra a execução
                    case 4:
                        this.coletar();//Pegar o que o usuario está digitando
                        if (this.model.dividir() == -1)
                        {
                            Console.WriteLine("Impossível dividir por zero!");
                        }
                        else
                        {
                            Console.WriteLine("A divisão é: " + this.model.dividir());
                        }
                        break;//Encerra a execução
                    case 5:
                        this.coletar();//Pegar o que o usuario está digitando
                        Console.WriteLine("A potência é: " + this.model.potencia());
                        break;
                    case 6:
                        Console.WriteLine("Informe um número: ");
                        this.model.setNum1(Convert.ToInt32(Console.ReadLine()));

                        Console.WriteLine("A matriz do primeiro número é: " + this.model.raizPrimeiroNumero());
                        break;
                    case 7:
                        Console.WriteLine("Informe um número: ");
                        this.model.setNum2(Convert.ToInt32(Console.ReadLine()));

                        Console.WriteLine("A matriz do segundo número é: " + this.model.raizSegundoNumero());
                        break;
                    case 8:
                        Console.WriteLine("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());//Variável local para guardar o número
                        //Para chamar a tabuada
                        Console.WriteLine(this.model.tabuada(num));
                        break;
                    case 9:
                        Console.WriteLine("Informe um ano: ");
                        int ano = Convert.ToInt32(Console.ReadLine());
                        //Chamar o método do Bissexto
                        Console.WriteLine(this.model.bissexto(ano));
                        break;
                    case 10:
                    case 11:
                    case 12:
                    case 13:
                    case 14:
                    case 15:
                    case 16:
                    case 17:
                    case 18:
                    case 19:
                    case 20:
                    case 21:
                    case 22:
                    case 23:
                    case 24:
                    case 25:
                    case 26:
                    case 27:
                    default:
                        Console.WriteLine("Informe um valor correto!");
                        break;
                }//fim do escolha
            } while (opcao != 0);
        }//fim do método

        public void coletar()
        {
            Console.Write("\nInforme o primeiro número: ");
            this.model.setNum1(Convert.ToInt32(Console.ReadLine()));//Peguei o primeiro número

            Console.Write("Informe o segundo número: ");
            this.model.setNum2(Convert.ToDouble(Console.ReadLine()));//Peguei o segundo número
        }
    }//fim da classe
}//fim do projeto
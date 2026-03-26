using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
                        Console.WriteLine("Informe um número: ");
                        int numero = Convert.ToInt32(Console.ReadLine());

                        //Chamar a verificação do intervalo
                        Console.WriteLine(this.model.verificarIntervalo(numero));
                        break;

                    case 11:
                        Console.WriteLine("Informe a sua idade: ");
                        int idade = Convert.ToInt32(Console.ReadLine());

                        //Chamar o método de verificação de idade para voto
                        Console.WriteLine(this.model.verificarIdadeVoto(idade));
                        break;

                    case 12:
                        //Definindo o intervalo de tempo...
                        Console.WriteLine("Informe o início do intervalo de tempo: ");
                        int iIntervalo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o final do intervalo de tempo: ");
                        int fIntervalo = Convert.ToInt32(Console.ReadLine());

                        //Coletando o número...
                        Console.WriteLine("Informe um número: ");
                        int numm = Convert.ToInt32(Console.ReadLine());

                        //Chamar a verificação do intervalo
                        Console.WriteLine(this.model.numIntervalo(numm, iIntervalo, fIntervalo));
                        break;

                    case 13:
                        //Coletando os valores de cada lado do triângulo...
                        Console.WriteLine("Informe o valor do primeiro lado: ");
                        int lado1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o valor do segundo lado: ");
                        int lado2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o valor do terceiro lado: ");
                        int lado3 = Convert.ToInt32(Console.ReadLine());

                        //Chamar o método de verificação do tipo de triângulo
                        Console.WriteLine(this.model.verificarTriangulo(lado1, lado2, lado3));
                        break;

                    case 14:
                        Console.WriteLine("Informe um número: ");
                        int dia = Convert.ToInt32(Console.ReadLine());

                        //Chamar o método de definição do dia da semana
                        Console.WriteLine(this.model.verificarDia(dia));
                        break;

                    case 15:
                        this.model.verificarSenha();
                        break;

                    case 16:
                        //Coletando os horários...
                        Console.WriteLine("Informe o primeiro horário: ");
                        int hora1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o segundo horário: ");
                        int hora2 = Convert.ToInt32(Console.ReadLine());

                        //Chamando o método de verificação do horário
                        Console.WriteLine(this.model.verificarHorario(hora1, hora2));
                        break;

                    case 17:
                        Console.WriteLine("Informe o primeiro número: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o segundo número: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        //Chamar a verificação do maior número
                        Console.WriteLine(this.model.verificarMaiorMenor(num1, num2));
                        break;

                    case 18:
                        this.model.mediaNumeros();
                        break;

                    case 19:
                        this.model.somaNum();
                        break;

                    case 20:
                        this.model.lerSenha();
                        break;

                    case 21:
                        Console.WriteLine(this.model.maiorMenor());
                        break;

                    case 22:
                        Console.WriteLine("Informe a sua idade: ");
                        idade = Convert.ToInt32(Console.ReadLine());

                        //Chamar o método de classificação de idade
                        Console.WriteLine(this.model.classificarIdade(idade));
                        break;

                    case 23:
                        double peso = 0;
                        double altura = 0;

                        //Coletando e verificando os valores...
                        //Informando o peso...
                        do
                        {
                            Console.WriteLine("Informe o seu peso: ");
                            peso = Convert.ToDouble(Console.ReadLine());
                            if (peso <= 0)
                            {
                                Console.WriteLine("Erro! Informe um peso válido!");
                            }
                        } while (peso <= 0);

                        //Informando a altura...
                        do
                        {
                            Console.WriteLine("Informe a sua altura: ");
                            altura = Convert.ToDouble(Console.ReadLine());
                            if (altura <= 0)
                            {
                                Console.WriteLine("Erro! Informe uma altura válida!");
                            }
                        } while (altura <= 0);

                        //Chamar o método de cálculo do IMC
                        Console.WriteLine(this.model.calculoIMC(peso, altura));
                        break;

                    case 24:
                        Console.WriteLine("Informe um número: ");
                        int number = Convert.ToInt32(Console.ReadLine());

                        //Chamar o método de verificação
                        Console.WriteLine(this.model.verificarValor(number));
                        break;

                    case 25:
                        Console.WriteLine("Informe um número: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        //Chamar o método de verificação do número
                        Console.WriteLine(this.model.verificarParImpar(numero));
                        break;

                    case 26:
                        //Coletando os valores...
                        Console.WriteLine("Informe o primeiro número: ");
                        int numero1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o segundo número: ");
                        int numero2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o terceiro número: ");
                        int numero3 = Convert.ToInt32(Console.ReadLine());

                        //Chamar o método de resultados
                        this.model.resultadosNum(numero1, numero2, numero3);
                        break;

                    case 27:
                        Console.WriteLine("Informe a sua idade: ");
                        int idades = Convert.ToInt32(Console.ReadLine());

                        //Chamar o método de verificação da Tarifa
                        Console.WriteLine(this.model.verificarTarifa(idades));
                        break;

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
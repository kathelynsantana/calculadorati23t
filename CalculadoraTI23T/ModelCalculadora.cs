using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI23T
{
    class ModelCalculadora
    {
        //1° Variáveis = GLOBALMENTE = Código inteiro exerga elas
        private double num1;//Encapsular a variável
        private double num2;
        private double resultado;
        private double imc;

        //Método que instancia as variáveis = dá valor inicial as variáveis
        //2° Método construtor
        public ModelCalculadora()
        {
            this.num1 = 0;
            this.num2 = 0;
            this.resultado = 0;
            this.imc = 0;
        }//fim do construtor

        public ModelCalculadora(double num1, double num2)
        { 
            this.num1 = num1;
            this.num2 = num2;
        }//fim do construtor com parâmetros 


        //Método GET e SET (obter ou ver/alterar ou modificar)
        //3° Métodos GET - Ver
        public double getNum1() 
        { 
            return this.num1;
        }//fim do método get

        public double getNum2()
        {
            return this.num2;
        }//fim do método get

        public double getResultado()
        {
            return this.resultado;
        }//fim do método get

        public double getImc()
        {
            return this.imc;
        }

        //4° Métodos set - Modificadores 

        public void setNum1(double num1)
        {
            this.num1 = num1;
        }//fim do método set

        public void setNum2(double num2)
        {
            this.num2 = num2;
        }//fim do método set

        public void setResultado(double resultado)
        {
            this.resultado = resultado;
        }//fim do método set

        public void setImc(double imc)
        {
            this.imc = imc;
        }//fim do método set

        //Operações aritméticas

        //Caso 1
        //Soma
        public double somar()
        {
            this.setResultado(this.getNum1() + this.getNum2());//Alterando o resultado
            return this.getResultado();//Mostrando o resultado
        }//fim do somar

        //Caso 2
        //Subtração
        public double subtrair()
        {
            this.setResultado(this.getNum1() - this.getNum2());//Alterando o resultado
            return this.getResultado();//Mostrando o resultado
        }//fim do subtrair

        //Caso 3
        //Multiplicação
        public double multiplicar()
        {
            this.setResultado(this.getNum1() * this.getNum2());//Alterando o resultado
            return this.getResultado();//Mostrando o resultado
        }//fim do multiplicar

        //Caso 4
        //Divisão
        public double dividir()
        {
            if (this.getNum2() == 0)
            {
                return -1;//Flag = Porque ele vai indicar que não dá pra dividir por zero
            }
            else
            {
                this.setResultado(this.getNum1() / this.getNum2());//Alterando o resultado
                return this.getResultado();//Mostrando o resultado
            }
        }//fim do dividir

        //Caso 5
        //Potência:
        public double potencia()
        {
            this.setResultado(Math.Pow(this.getNum1(), this.getNum2()));
            return this.getResultado();
        }//fim do método

        //Caso 6
        //Raiz primeiro número:
        public double raizPrimeiroNumero()
        {
            this.setResultado(Math.Sqrt(this.getNum1()));
            return this.getResultado();
        }//fim da raiz do primeiro numero

        //Caso 7
        //Raiz do segundo número:
        public double raizSegundoNumero()
        {
            this.setResultado(Math.Sqrt(this.getNum2()));
            return this.getResultado();
        }//fim da raiz do segundo numero

        //Caso 8
        //Tabuada:
        public string tabuada(int num)//retornar na tela um texto (tabuada)
        {
            //i++ -> i = i + 1 (Contador + 1)
            //i-- -> i = i - 1 (Contador - 1)
            //i+=3 -> i = i + 3 (Contador + 3)

            string msg = "";
            int i = 0;
            for (i = 0; i <= 10; i++)
            {
                msg += "\n" + num + " * " + i + " = " + (num * i); //+= serve para acumular mensagens sem apagar a anterior 
            }//fim do for
            return msg;
        }//fim do método

        //Caso 9
        //Verificar se um ano é bissexto:
        public string bissexto(int ano)
        {
            if (ano % 4 == 0)
            {
                return $"{ano} é um ano bissexto!";//Interpolação: é quando eu cosnigo colocar a variável dentro das chaves {}
            }
            else
            {
                return $"{ano} NÃO é um ano bissexto!";
            }
        }//fim do bissexto

        //Caso 10
        //Verificar se um número está entre um intervalo de 100 e 200:
        public string verificarIntervalo(int numero)
        {
            if (numero >= 100 && numero <= 200)
            {
                return $"{numero} está dentro do intervalo entre 100 e 200!";
            }
            else
            {
                return $"{numero} NÃO está dentro do intervalo entre 100 e 200!";
            }
        }

        //Caso 11
        //Verificação de idade para votar:
        public string verificarIdadeVoto(int idade)
        {
            if(idade >= 0 && idade <= 15)
            {
                return "Você NÃO pode votar!";
            }
            else
            {
                return "Você pode votar!";
            }
        }
        //Caso 12
        //Verifique se um número está dentro de um intervalo:
        public string numIntervalo(int numm, int iIntervalo, int fIntervalo)
        {
            if ((numm >= iIntervalo) && (numm <= fIntervalo))
            {
                return $"{numm} está entre {iIntervalo} e {fIntervalo}";
            }
            else
            {
                return $"{numm} NÃO está entre {iIntervalo} e {fIntervalo}";
            }
        }
        
        //Caso 13
        //Verificar se um triângulo é equilátero, isósceles ou escaleno:
        public string verificarTriangulo(int lado1, int lado2, int lado3)
        {
            if((lado1 == lado2) && (lado2 == lado3))
            {
                return "Este triângulo é Equilátero!";
            }
            else
            {
                if((lado1 == lado2) || (lado2 == lado3) || (lado3 == lado1))
                {
                    return "Este triângulo é Isósceles!";
                }
                else
                {
                    return "Este triângulo é Escaleno!";
                }
            }
        }

        //Caso 14
        //Verificar o dia da semana de acordo com o dia:
        public string verificarDia(int dia)
        {
          
            if (dia == 1)
            {
                return $"{dia} é Domingo!";
            }
            else
            {
                if (dia == 2)
                {
                    return $"{dia} é Segunda-Feira!";
                }
                else
                {
                    if (dia == 3)
                    {
                        return $"{dia} é Terça-Feira!";
                    }
                    else
                    {
                        if (dia == 4)
                        {
                            return $"{dia} é Quarta-Feira!";
                        }
                        else
                        {
                            if (dia == 5)
                            {
                                return $"{dia} é Quinta-Feira!";
                            }
                            else
                            {
                                if (dia == 6)
                                {
                                    return $"{dia} é Sexta-Feira!";
                                }
                                else if(dia == 7)
                                {
                                    return $"{dia} é Sábado!";
                                }
                                else
                                {
                                    return "Erro! Código inválido!";
                                }
                            }
                        }
                    }
                }
            }
        }
        //Caso 15
        //Verificar se uma senha digitada é válida:
        public void verificarSenha()
        {
            int senha = 0;
            int senhaValida = 123456;

                Console.WriteLine("Informe uma senha de 6 dígitos: ");
                senha = Convert.ToInt32(Console.ReadLine());

                if (senha == senhaValida)
                {
                    Console.WriteLine("Senha correta!");
                }
                else
                {
                    Console.WriteLine("Senha Incorreta!");
                }
        }

        //Caso 16
        //Verificar qual horário é o mais tarde:
        public string verificarHorario(int hora1, int hora2)
        {
            if(hora1 > hora2)
            {
                return $"{hora1} é mais tarde que {hora2}!";
            }
            else
            {
                return $"{hora2} é mais tarde que {hora1}!";
            }

        }

        //Caso 17
        //Verificar o maior e menor número entre dois números:
        public string verificarMaiorMenor(int num1, int num2)
        {
            if(num1 > num2)
            {
                return $"{num1} é o maior número!";
            }
            else
            {
                return $"{num2} é o maior número!";
            }
        }

        //Caso 18
        //Calcular a média de 5 números:
        public void mediaNumeros()
        {
            int num = 0;
            int soma = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Informe o " + (i + 1) + "° número: ");
                num = Convert.ToInt32(Console.ReadLine());

                //Cálculo da média
                soma = soma + num;
            }
            Console.WriteLine("A média desses números é: " + soma/5);
;       }

        //Caso 19
        //Ler números até que a soma ultrapasse 100:
        public void somaNum()
        {
            int soma = 0;

            do
            {
                Console.WriteLine("Informe um número: ");
                int num = Convert.ToInt32(Console.ReadLine());

                soma = soma + num;

            } while (soma <= 100);
        }

        //Caso 20
        //Ler senhas até que uma válida seja informada:
        public void lerSenha()
        {
            int senha = 0;
            int senhaValida = 123456;
            do
            {
                Console.WriteLine("Informe uma senha de 6 dígitos: ");
                senha = Convert.ToInt32(Console.ReadLine());
                if (senha == senhaValida)
                {
                    Console.WriteLine("Senha correta!");
                }
                else
                {
                    Console.WriteLine("Senha Incorreta! Digite novamente!");
                }
            } while (senha != senhaValida);
        }

        //Caso 21
        //Ler 10 números e exibir o maior e o menor:
        public string maiorMenor()
        {
            int num = 0;
            int maior = 0;
            int menor = 0;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe o " + (i + 1) + "° número: ");
                num = Convert.ToInt32(Console.ReadLine());
            
                //Instanciar
                if (i == 0)
                {
                    maior = num;
                    menor = num;
                }

                //Comparação
                if (num > maior)
                {
                    maior = num;
                }
                if (num < menor)
                {
                    menor = num;
                }
            }//fim do for
            return $"O maior número é {maior} e o menor é {menor}.";
        }

        //Caso 22
        //Classificação de idade:
        public string classificarIdade(int idade)
        {
            if(idade >= 0 && idade <= 12)
            {
                return "Criança!";
            }
            else
            {
                if(idade >= 13 && idade <= 21)
                {
                    return "Jovem!";
                }
                else
                {
                    if(idade >= 22 && idade <= 59)
                    {
                        return "Adulto!";
                    }
                    else
                    {
                        return "Idoso!";
                    }
                }
            }
        }//fim do método

        //Caso 23
        //Cálculo do IMC:
        public string calculoIMC(double peso, double altura)
        {
            imc = (peso/(Math.Pow(altura, 2)));
            return $"O seu IMC é: {imc}";
        }

        //Caso 24
        //Verificacar se um número é positivo, negativo ou zero:
        public string verificarValor(int number)
        {
            if(number > 0)
            {
                return $"{number} é um número positivo!";
            }
            else
            {
                if(number < 0)
                {
                    return $"{number} é um número negativo!";
                }
                else
                {
                    return $"{number} é zero!";
                }
            }
        }

        //Caso 25
        //Verificar se um número é par ou ímpar:
        public string verificarParImpar(int numero)
        {
            if(numero%2 == 0)
            {
                return $"{numero} é um número par!";
            }
            else
            {
                return $"{numero} é um numero ímpar!";
            }
        }

        //Caso 26
        //Ler 3 números e exibir o maior, menor, média, soma e potência:
        public void resultadosNum(int numero1, int numero2, int numero3)
        {
            int maior = 0;
            int menor = 0;
            int soma = 0;
            int media = 0;
            double pot1 = 0;
            double pot2 = 0;
            double pot3 = 0;

            //Verificando o maior número...
            if ((numero1 > numero2) && (numero1 > numero3))
            {
                maior = numero1;
            }
            else
            {
                if((numero2 > numero1) && (numero2 > numero3))
                {
                    maior = numero2;
                }
                else
                {
                    maior = numero3;
                }
            }

            //Verificando o menor número...
            if ((numero1 < numero2) && (numero1 < numero3))
            {
                menor = numero1;
            }
            else
            {
                if ((numero2 < numero1) && (numero2 < numero3))
                {
                    menor = numero2;
                }
                else
                {
                    menor = numero3;
                }
            }

            //Somando e calculando a média...
            soma = numero1 + numero2 + numero3;
            media = soma / 3;

            //Potência...
            pot1 = Math.Pow(numero1, 2);
            pot2 = Math.Pow(numero2, 2);
            pot3 = Math.Pow(numero3, 2);
                        //Mostrando os resultados...
            Console.WriteLine("O maior número é: " + maior);
            Console.WriteLine("O menor número é: " + menor);
            Console.WriteLine("A soma desses números é: " + soma);
            Console.WriteLine("A média desses números é: " + media);
            Console.WriteLine("A potência do primeiro número é: " + pot1);
            Console.WriteLine("A potência do segundo número é: " + pot2);
            Console.WriteLine("A potência do terceiro número é: " + pot3);

        }

        //Caso 27
        //Verificação da Tarifa do Ônibus pela idade:
        public string verificarTarifa(int idades)
        {
            double passagem = 5.50;
            if (idades < 0)
            {
                return "Idade inválida!";
            }
            else
            {
                if (idades < 5 || idades >= 60)
                {
                    return "Passagem Gratuita!";
                }
                else
                {
                    if (idades >= 5 && idades <= 17)
                    {
                        return $"Meia Passagem: {passagem/2}";
                    }
                    else
                    {
                        return $"Passagem inteira: {passagem}";
                    }
                }
            }
        }//fim do método
    }//fim da classe Model
}//fim do projetoCalculadoraTI23T

using System;
using System.Collections.Generic;
using System.Linq;
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

        //Método que instancia as variáveis = dá valor inicial as variáveis
        //2° Método construtor
        public ModelCalculadora()
        {
            this.num1 = 0;
            this.num2 = 0;
            this.resultado = 0;
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

        
        //Operações aritméticas

        public double somar()
        {
            this.setResultado(this.getNum1() + this.getNum2());//Alterando o resultado
            return this.getResultado();//Mostrando o resultado
        }//fim do somar

        public double subtrair()
        {
            this.setResultado(this.getNum1() - this.getNum2());//Alterando o resultado
            return this.getResultado();//Mostrando o resultado
        }//fim do subtrair

        public double multiplicar()
        {
            this.setResultado(this.getNum1() * this.getNum2());//Alterando o resultado
            return this.getResultado();//Mostrando o resultado
        }//fim do multiplicar

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

        //Potência
        public double potencia()
        {
            this.setResultado(Math.Pow(this.getNum1(), this.getNum2()));
            return this.getResultado();
        }//fim do método

        public double raizPrimeiroNumero()
        {
            this.setResultado(Math.Sqrt(this.getNum1()));
            return this.getResultado();
        }//fim da raiz do primeiro numero

        public double raizSegundoNumero()
        {
            this.setResultado(Math.Sqrt(this.getNum2()));
            return this.getResultado();
        }//fim da raiz do segundo numero

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

        public string bissexto(int ano)
        {
            if(ano % 4 == 0)
            {
                return $"{ano} é um ano bissexto!";//Interpolação: é quando eu cosnigo colocar a variável dentro das chaves {}
            }
            else
            {
                return $"{ano} NÃO é um ano bissexto!";
            }
        }//fim do bissexto

        public string verificacaoNumero(int intervalo)
        {

        }
    }//fim da classe Model
}//fim do projetoCalculadoraTI23T

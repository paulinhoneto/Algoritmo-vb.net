'*
'*  Author  : Marcio Pereira de Sousa
'*  File    : Mudule1.vb
'*  Project : Algoritmo_01 
'*  
'*  O Preço de um veículo é calculado pela soma do preço dos impostos (45% do preço de custo) e com a 
'*  porcentagem dos vendores (28% do preço de custo). faça um algoritmo que imprima a marca, o modelo 
'*  do veículo e seu valor final.
'*  Exemplo : (valor_vei * 45) / 100 e (valor_vei * 28) / 100
'*  Exemplo :  valor_vei * 0.45 e valor_vei * 0.28
'*/
Module Module1

    Sub Main()
        '// inicializa e declara todas as variáveis como boas práticas de programação
        Dim vlr_custo As Double = 0 '// variaveis do tipo númericas inicializa com 0
        Dim marca As String = ""    '// variáveis do tipo alfanúmericas inicializa com aspas duplas
        Dim modelo As String = ""
        Dim vlr_final As Double = 0
        Dim vlr_comissao As Double = 0
        Dim vlr_imposto As Double = 0
    End Sub

End Module

'using System;
'using System.Collections.Generic;
'using System.Linq;
'using System.Text;
'using System.Threading.Tasks;

'Namespace Algoritmo_01
'{
'    Class Program
'    {
'        static void Main(string[] args)
'        {
'            // inicializa e declara todas as variáveis como boas práticas de programação
'            double vlr_custo     = 0; 
'            String marca         = ""; // variáveis do tipo alfanúmericas inicializa com aspas duplas
'            String modelo        = "";
'            double vlr_final     = 0;
'            double vlr_comissao  = 0;
'            double vlr_imposto   = 0;


'            Console.Write("Entre com a marca do veículo : ");  // mostra dados na tela como console 
'            marca = Console.ReadLine(); // lê a variável marca

'            Console.Write("Entre com o modelo do veículo : "); // mostra dados na tela como console
'            modelo = Console.ReadLine(); // lê a variável modelo

'            Console.Write("Entre com o valor do custo do veículo : "); // mostra dados na tela como console
'            vlr_custo = double.Parse(Console.ReadLine()); // lê variável custo usa classe double.Parse para converter double para string

'            vlr_imposto   = (vlr_custo * 0.45); // processamento para valor do imposto é 45% do valor do custo
'            vlr_comissao  = (vlr_custo * 0.28); // processamento para valor da comissão é 28% do valor do custo 

'            vlr_final = vlr_custo + vlr_imposto + vlr_comissao;

'            Console.Write("-------------------------------     \n");  // o \n é um escape new line para salto de linha
'            Console.Write("Resultado Final\n");
'            Console.Write("-------------------------------     \n");
'            Console.Write("Marca do veículo : " + marca +     "\n");
'            Console.Write("-------------------------------     \n");
'            Console.Write("Modelo do veículo : " + modelo +   "\n");
'            Console.Write("-------------------------------     \n");
'            Console.Write("Valor do veículo : " + vlr_final + "\n");
'            Console.Write("-------------------------------");

'            Console.ReadKey(); // espera entrada do teclado para fechar aplicação.

'        }
'    }
'}
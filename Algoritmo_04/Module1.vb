'/*
' * Author  : Marcio Pereira de Sousa
' * File    : Module1.vb
' * Project : Algoritmo_04
' * 
' * A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as 
' * dimensões de um terreno e depois exibir a área do terreno. 
' */

Module Module1

    Sub Main()
        '// declara e inicializa as variáveis nesse caso nao pude usar base pois e palavra reservada do vb .net
        Dim baseRectangle As Double = 0
        Dim altura As Double = 0
        Dim area As Double = 0

        '// exibe no console
        Console.Write("Entre com a base do terreno : ")
        baseRectangle = Double.Parse(Console.ReadLine())   '// lê a base do terreno retângular 

        '// exibe no console
        Console.Write("Entre com a altura do terreno : ")
        altura = Double.Parse(Console.ReadLine())          '// lê a altura do terreno retângular 

        area = baseRectangle * altura

        '// saida da area do terre
        Console.Write("A área do terreno é : " & area)

        Console.ReadKey()  '// espera a entrada do teclado para encerrar a aplicação.

    End Sub

End Module
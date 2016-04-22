'/*
' * Author  : Marcio Pereira de Sousa
' * File    : Module1.vb
' * Project : Algoritmo_03
' * 
' * Faça um algoritmo para calcular quantas ferraduras são necessárias para equipar todos os
' * cavalos de um haras.
' */
Module Module1

    Sub Main()
        '// inicia e declara todas as variáveis necessárias
        Const ferraduras As Integer = 4    '// declaração de uma constante ou seja não mudará ao decorrer do programa.
        Dim quantidade_cavalos As Integer = 0
        Dim resultado As Integer = 0      '// armazenára a quantidade de ferraduras para equipar os cavalos

        '// exibe no console 
        Console.Write("Entre com a quantidade de cavalos do seu Haras : ")
        quantidade_cavalos = Integer.Parse(Console.ReadLine()) '// lê a quantidade de cavalos do haras

        resultado = ferraduras * quantidade_cavalos '// faz o processamento da quantidade de ferraduras

        '// por fim exibe a saída ou resultado do programa.
        Console.Write("Quantidade de Ferraduras para equipar todos seus cavalos serão : " & resultado)

        Console.ReadKey()  '// espera entrada do teclado para encerrar o programa 
    End Sub

End Module
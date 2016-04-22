'*/*
'* Author  : Marcio Pereira de Sousa
'* File    : Module1.vb
'* Project : Algoritmo_02
'* 
'* Faça um algoritmo para ler : a descrição do produto (nome), a quantidade adquirida, o preço unitário 
'* e o percentual (%) de desconto. Calcular e escrever o total bruto (total_bruto = quantidade adiquirida * 
'* preço unitário), o total de desconto,  o total a pagar (total a pagar = total_bruto - desconto).
'*/*

Module Module1

    Sub Main()
        Dim nome As String = ""       '// alfanúmericas com aspas duplas
        Dim quantidade As Integer = 0 '//númericas com zero
        Dim preco As Double = 0
        Dim percentual_desc As Double = 0
        Dim total_desconto As Double = 0
        Dim total_bruto As Double = 0

        Console.Write("Entre com o nome do Produto : ")    '// exibir no console
        nome = Console.ReadLine()                          '// lê dados

        Console.Write("Entre com a quantidade : ")
        quantidade = Integer.Parse(Console.ReadLine())

        Console.Write("Entre com preço do produto : ")
        preco = Double.Parse(Console.ReadLine())

        Console.Write("Entre com o percentual de desconto : ")
        percentual_desc = Double.Parse(Console.ReadLine())

        total_bruto = quantidade * preco    '// processamento do total bruto

        '// processamento total com desconto em cima da porcentagem
        total_desconto = total_bruto - ((percentual_desc / 100) * total_bruto)

        '// exibe o resultado do problema que é o total com o desconto 
        Console.Write("Total com desconto : " & total_desconto)

        Console.ReadKey() '// pausa o console até que algum evento do teclado seja executado

    End Sub

End Module

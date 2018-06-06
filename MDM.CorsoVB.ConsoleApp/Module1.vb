Imports System.IO
'Imports System.printing
Imports System.Net

Module Module1

    Sub Main()
        ' Dichiarazione di una variabile
        Dim età As Integer
        Dim weight As Single = 34.187
        Dim weight2 As Single = 55564564564534.188
        Dim weight3 As Double = 8.5734985743895561E+37

        Dim Altezza = 180.2, Peso = 78.5, Larghezza As Double

        Larghezza = 55

        Dim _Maggiorenne As Boolean = True
        Dim anno_nascita As Integer = 1976

        weight2 = weight3

        'File.WriteAllText("Z:\\Prova.txt", "Igor")

        'PascalCase (iniziali maiuscole di ciascuna parola)
        ' Scrive il messaggio tra apici sullo schermo (NON fa nessuna pausa)
        Console.WriteLine("Per favore, scrivi la tua età:")
        età = Console.ReadLine()

        ' camelCase
        ' (iniziali maiuscole di ciascuna parola, tranne la prima)
        Dim annoNascita As Integer = DateTime.Now.Year - età

        'Console.WriteLine("Ok, hai ___ anni, perciò sei nato nel ___!")
        'Console.WriteLine("Ok, hai " + età.ToString() + " anni, perciò sei nato nel " + annoNascita.ToString() + "!")
        'Console.WriteLine(String.Format("Ok, hai {0} anni, perciò sei nato nel {1}!", età, annoNascita))

        Dim messaggioUtente As String
        messaggioUtente = String.Format("Se hai {0} anni, significa che sei nato nell'anno {1}", età, annoNascita)

        Console.WriteLine(messaggioUtente)
        File.WriteAllText("Z:\\Prova.txt", messaggioUtente)
        Console.ReadKey()

    End Sub

End Module
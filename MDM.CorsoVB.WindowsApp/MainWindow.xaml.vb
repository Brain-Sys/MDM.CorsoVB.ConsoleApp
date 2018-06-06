Imports MDM.CorsoVB.LogicaApplicazione

Class MainWindow
    Private Sub btnCalcolaAnnoNascita_Click(sender As Object, e As RoutedEventArgs) Handles btnCalcolaAnnoNascita.Click

        Dim calcolatrice As New CalcoloAnno
        Dim anno As UShort = calcolatrice.DammiAnno(txtEtà.Text)

        If anno <> 0 Then
            Dim messaggioUtente As String = String.Format("Se hai {0} anni, significa che sei nato nell'anno {1}", txtEtà.Text, anno)
            lblRisultatoFinale.Content = messaggioUtente
            MessageBox.Show(messaggioUtente)

        Else

            MessageBox.Show("Oops, qualcosa è andato storto!!!")

        End If


        '' Dichiarazione
        '' U = Unsigned (solo numeri positivi)
        '' Short = -32767 / +32768
        'Dim annoNascita As UShort

        'If txtEtà.Text <= 0 OrElse txtEtà.Text >= 130 Then
        '    Beep()
        '    MessageBox.Show("Spiacente, l'età non è valida!")
        '    Return
        'End If

        '' Assegnazione
        'annoNascita = DateTime.Now.Year - txtEtà.Text
        'Dim messaggioUtente As String = String.Format("Se hai {0} anni, significa che sei nato nell'anno {1}", txtEtà.Text, annoNascita)
        ''MessageBox.Show(messaggioUtente)

        'lblRisultatoFinale.Content = messaggioUtente
    End Sub

    Private Sub txtEtà_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEtà.KeyDown
        If e.Key = Key.Return Then
            btnCalcolaAnnoNascita_Click(Nothing, Nothing)
        End If
    End Sub
End Class
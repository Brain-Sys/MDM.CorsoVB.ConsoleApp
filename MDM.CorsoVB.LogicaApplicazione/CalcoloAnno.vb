Public Class CalcoloAnno

    Public Function DammiAnno(età As UShort) As UShort

        If età <= 0 Then
            Return 0
        End If

        Dim anno As UShort = DateTime.Now.Year - età

        Return anno
    End Function



End Class
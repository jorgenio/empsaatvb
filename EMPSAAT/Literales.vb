Module Literales
    Function Literal(ByVal nNumero As Double, ByVal cGenero As String) As String

        '// Declaraci¢n de Variables
        Dim aGrupos(6), aUnidad(10), adecena(10, 10), acentena(10), aConector(5), cEnLetra As String, nGrupo As Single, cNumStr As String, cUnidad As String, cDecena As String, cCentena As String
        Dim nDec As Double

        '// Control de Par metros opcionales
        If IsDBNull(cGenero) Then
            cGenero = "F"
        Else
            cGenero = UCase(cGenero)
        End If

        '// Control del tipo de los par metros
        If Not IsNumeric(nNumero) Then 'Or cGenero <> "C" Then
            Exit Function
        End If

        '// Conversi¢n a car cter del n£mero,
        '// justificando con 0 a la izquierda
        'cNumStr = Trim(Str(nNumero))
        cNumStr = Format(Int(Math.Round(nNumero, 2)), "000000000000000")

        '// Confecci¢n de los Grupos
        For nGrupo = 1 To 5
            aGrupos(5 - nGrupo + 1) = Mid(cNumStr, (nGrupo - 1) * 3 + 1, 3)
        Next

        '// Proceso
        cEnLetra = ""

        For nGrupo = 5 To 1 Step -1
            '// Extraer cada una de las 3 cifras del Grupo en curso
            cUnidad = Right(aGrupos(nGrupo), 1)
            cDecena = Mid(aGrupos(nGrupo), 2, 1)
            cCentena = Left(aGrupos(nGrupo), 1)

            '// Componer la cifra en letra del Grupo en curso
            cEnLetra = cEnLetra + (centenas(Val(cUnidad), Val(cDecena), Val(cCentena), nGrupo, cGenero)) & _
                                  (decenas(Val(cUnidad), Val(cDecena)) & _
                                  (unidades(nNumero, Val(cUnidad), Val(cDecena), Val(cCentena), aGrupos(nGrupo), nGrupo, cGenero) & _
                                  (conectores(nGrupo, aGrupos(nGrupo)))))
        Next

        '// Salida
        nDec = Str((Math.Round((nNumero - Int(nNumero)), 2) * 100))
        Literal = UCase(cEnLetra + Format(nDec, "00") & "/100")
    End Function



    Function unidades(ByVal nvalor, ByVal Unidad, ByVal decena, ByVal centena, ByVal dat, ByVal grupo, ByVal genero) As String
        '// Code Blocks para las Unidades
        Select Case Unidad
            Case 0
                If nvalor = 0 Then
                    If grupo = 1 Then
                        unidades = "cero"
                    End If
                Else
                    unidades = ""
                End If
            Case 1
                If decena = 1 Then
                    unidades = ""
                    'decena(2, Val(cUnidad) + 1)
                ElseIf dat = "001" And grupo = 2 Or grupo = 4 Then
                    unidades = "un "
                ElseIf grupo > 1 Then
                    If genero = "F" Then
                        unidades = "un "
                    Else
                        unidades = "un "
                    End If
                ElseIf grupo = 1 Then
                    If genero = "F" Then
                        unidades = "una "
                    Else
                        unidades = "uno "
                    End If
                End If
            Case 2
                If decena = "1" Then
                    unidades = ""
                    ', adecena(2, Val(cUnidad) + 1)
                Else
                    unidades = "dos "
                End If
            Case 3
                If decena = "1" Then
                    unidades = ""
                    'adecena(2, Val(cUnidad) + 1)
                Else
                    unidades = "tres "
                End If
            Case 4
                If decena = "1" Then
                    unidades = ""
                    ', adecena(2, Val(cUnidad) + 1)
                Else
                    unidades = "cuatro "
                End If
            Case 5
                If decena = "1" Then
                    unidades = ""
                    ', adecena(2, Val(cUnidad) + 1)
                Else
                    unidades = "cinco "
                End If
            Case 6
                If decena = "1" Then
                    unidades = ""
                    ', adecena(2, Val(cUnidad) + 1)
                Else
                    unidades = "seis "
                End If
            Case 7
                If decena = "1" Then
                    unidades = ""
                    'cdecena(2, Val(cUnidad) + 1)
                Else
                    unidades = "siete "
                End If
            Case 8
                If decena = "1" Then
                    unidades = ""
                    'adecena(2, Val(cUnidad) + 1)
                Else
                    unidades = "ocho "
                End If
            Case 9
                If decena = "1" Then
                    unidades = ""
                    ', adecena(2, Val(cUnidad) + 1)
                Else
                    unidades = "nueve "
                End If
        End Select
    End Function

    Function decenas(ByVal Unidad, ByVal decena) As String
        Select Case decena
            Case 0
                decenas = ""
            Case 1
                '// Code Blocks para las Decenas
                Select Case Unidad
                    Case 0
                        'adecena(1, 1) = ""
                        decenas = IIf(Unidad = "0", "diez ", "")
                    Case 1
                        decenas = "once "
                    Case 2
                        decenas = "doce "
                    Case 3
                        decenas = "trece "
                    Case 4
                        decenas = "catorce "
                    Case 5
                        decenas = "quince "
                    Case 6
                        decenas = "dieciseis "
                    Case 7
                        decenas = "diecisiete "
                    Case 8
                        decenas = "dieciocho "
                    Case 9
                        decenas = "diecinueve "
                End Select
            Case 2
                decenas = IIf(Unidad = "0", "veinte ", "veinti")
            Case 3
                decenas = "treinta " + IIf(Unidad <> "0", "y ", "")
            Case 4
                decenas = "cuarenta " + IIf(Unidad <> "0", "y ", "")
            Case 5
                decenas = "cincuenta " + IIf(Unidad <> "0", "y ", "")
            Case 6
                decenas = "sesenta " + IIf(Unidad <> "0", "y ", "")
            Case 7
                decenas = "setenta " + IIf(Unidad <> "0", "y ", "")
            Case 8
                decenas = "ochenta " + IIf(Unidad <> "0", "y ", "")
            Case 9
                decenas = "noventa " + IIf(Unidad <> "0", "y ", "")
        End Select
    End Function



    Function centenas(ByVal Unidad, ByVal decena, ByVal centena, ByVal grupo, ByVal genero) As String

        '// Code Blocks para las Centenas
        Select Case centena
            Case 0
                centenas = ""
            Case 1
                centenas = IIf(LTrim(Str(decena)) + LTrim(Str(Unidad)) = "00", "cien ", "ciento ")
            Case 2
                centenas = "doscient" + IIf(grupo < 3 And genero = "F", "as ", "os ")
            Case 3
                centenas = "trescient" + IIf(grupo < 3 And genero = "F", "as ", "os ")
            Case 4
                centenas = "cuatrocient" + IIf(grupo < 3 And genero = "F", "as ", "os ")
            Case 5
                centenas = "quinient" + IIf(grupo < 3 And genero = "F", "as ", "os ")
            Case 6
                centenas = "seiscient" + IIf(grupo < 3 And genero = "F", "as ", "os ")
            Case 7
                centenas = "setecient" + IIf(grupo < 3 And genero = "F", "as ", "os ")
            Case 8
                centenas = "ochocient" + IIf(grupo < 3 And genero = "F", "as ", "os ")
            Case 9
                centenas = "novecient" + IIf(grupo < 3 And genero = "F", "as ", "os ")
        End Select
    End Function


    Function conectores(ByVal grupos As Single, ByVal grup As String) As String
        '// Code Blocks para los Conectores
        Dim gru As String
        gru = LTrim(grup)
        Select Case grupos
            Case 1
                conectores = ""
            Case 2
                conectores = IIf(gru <> "000", "mil ", "")
            Case 3
                conectores = IIf(gru <> "000" Or gru <> "000", IIf(gru = "001", "millon ", "millones "), "")
            Case 4
                conectores = IIf(gru <> "000", "mil ", "")
            Case 5
                conectores = IIf(gru <> "000", IIf(gru = "001", "billon ", "billones "), "")
        End Select
    End Function


    Function Enteros(ByVal nNumero As Double, ByVal cGenero As String) As String

        '// Declaraci¢n de Variables
        Dim aGrupos(6), aUnidad(10), adecena(10, 10), acentena(10), aConector(5), cEnLetra As String, nGrupo As Single, cNumStr As String, cUnidad As String, cDecena As String, cCentena As String

        '// Control de Par metros opcionales
        If IsDBNull(cGenero) Then
            cGenero = "F"
        Else
            cGenero = UCase(cGenero)
        End If

        '// Control del tipo de los par metros
        If Not IsNumeric(nNumero) Then 'Or cGenero <> "C" Then
            Exit Function
        End If

        '// Conversi¢n a car cter del n£mero,
        '// justificando con 0 a la izquierda
        'cNumStr = Trim(Str(nNumero))
        cNumStr = Format(Int(nNumero), "000000000000000")

        '// Confecci¢n de los Grupos
        For nGrupo = 1 To 5
            aGrupos(5 - nGrupo + 1) = Mid(cNumStr, (nGrupo - 1) * 3 + 1, 3)
        Next

        '// Proceso
        cEnLetra = ""


        For nGrupo = 5 To 1 Step -1
            '// Extraer cada una de las 3 cifras del Grupo en curso
            cUnidad = Right(aGrupos(nGrupo), 1)
            cDecena = Mid(aGrupos(nGrupo), 2, 1)
            cCentena = Left(aGrupos(nGrupo), 1)

            '// Componer la cifra en letra del Grupo en curso
            cEnLetra = cEnLetra + (centenas(Val(cUnidad), Val(cDecena), Val(cCentena), nGrupo, cGenero)) & _
                                  (decenas(Val(cUnidad), Val(cDecena)) & _
                                  (unidades(nNumero, Val(cUnidad), Val(cDecena), Val(cCentena), aGrupos(nGrupo), nGrupo, cGenero) & _
                                  (conectores(nGrupo, aGrupos(nGrupo)))))
        Next

        '// Salida
        Enteros = UCase(cEnLetra)
    End Function

End Module

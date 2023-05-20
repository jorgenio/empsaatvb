Public Class CodigoV7
    Private qNoAutorizacion As Int64
    Private qNoFactura As Int64
    Private qNit As Int64
    Private qFecha As Date
    Private qImporte As Int64
    Private qLlave As String
    Private dSuma As Int64
    Private dModulo As Int64
    Private dBase As String
    Private dCodigo As String

    Property NoAutorizacion() As Int64
        Get
            Return qNoAutorizacion
        End Get
        Set(ByVal Value As Int64)
            qNoAutorizacion = Value
        End Set
    End Property

    Property NoFactura() As Int64
        Get
            Return qNoFactura
        End Get
        Set(ByVal Value As Int64)
            qNoFactura = Value
        End Set
    End Property

    Property NoNit() As Int64
        Get
            Return qNit
        End Get
        Set(ByVal Value As Int64)
            qNit = Value
        End Set
    End Property

    Property Fecha() As Date
        Get
            Return qFecha
        End Get
        Set(ByVal Value As Date)
            'qFecha = Microsoft.VisualBasic.Year(Value) & Format(Microsoft.VisualBasic.Month(Value), "00") & Format(Microsoft.VisualBasic.Day(Value), "00")
            qFecha = Value
        End Set
    End Property

    Property Importe() As Double
        Get
            Return qImporte
        End Get
        Set(ByVal Value As Double)
            If (Value - Int(Value)) = 0.5 Then
                qImporte = (Int(Value) + 1)
            Else
                qImporte = Math.Round(Value, 0)
            End If
        End Set
    End Property

    Property Llave() As String
        Get
            Return qLlave
        End Get
        Set(ByVal Value As String)
            qLlave = Value
        End Set
    End Property

    ReadOnly Property Codigo() As String
        Get
            Return ObtenerCodigo(Str(qNoAutorizacion), Str(qNoFactura), Str(qNit), qFecha, Str(qImporte), qLlave)
        End Get
    End Property

    Private Function ObtenerCodigo(ByVal QNoAutorizacion As String, ByVal QNoFactura As String, ByVal QNit As String, ByVal QFecha As Date, ByVal QImporte As String, ByVal QLlave As String) As String
        Dim dNoFactura As String
        Dim dNit As String
        Dim dFecha As String
        Dim dImporte As String
        Dim dSuma As String
        Dim dVer1 As Integer
        Dim dVer2 As Integer
        Dim dVer3 As Integer
        Dim dVer4 As Integer
        Dim dVer5 As Integer
        Dim dCad1 As String
        Dim dCad2 As String
        Dim dCad3 As String
        Dim dCad4 As String
        Dim dCad5 As String
        Dim dLlave As String

        dFecha = Microsoft.VisualBasic.Year(QFecha) & Format(Microsoft.VisualBasic.Month(QFecha), "00") & Format(Microsoft.VisualBasic.Day(QFecha), "00")

        '------- PASO 1 ------'
        dNoFactura = QNoFactura & ObtenerVerhoeff(Int(QNoFactura))
        dNit = QNit & ObtenerVerhoeff(Int(QNit))
        dFecha = dFecha & ObtenerVerhoeff(Int(dFecha))
        dImporte = Str(Math.Round(Val(QImporte), 0)) & ObtenerVerhoeff(Math.Round(Val(QImporte), 0))
        dNoFactura = dNoFactura & ObtenerVerhoeff(dNoFactura)
        dNit = dNit & ObtenerVerhoeff(dNit)
        dFecha = dFecha & ObtenerVerhoeff(dFecha)
        dImporte = dImporte & ObtenerVerhoeff(dImporte)
        dSuma = Trim(Str(Val(dNoFactura) + Val(dNit) + Val(dFecha) + Val(dImporte)))

        dVer1 = ObtenerVerhoeff(dSuma)
        dSuma = dSuma & Trim(dVer1)
        dVer2 = ObtenerVerhoeff(dSuma)
        dSuma = dSuma & Trim(dVer2)
        dVer3 = ObtenerVerhoeff(dSuma)
        dSuma = dSuma & Trim(dVer3)
        dVer4 = ObtenerVerhoeff(dSuma)
        dSuma = dSuma & Trim(dVer4)
        dVer5 = ObtenerVerhoeff(dSuma)
        dSuma = dSuma & Trim(dVer5)

        '----- PASO 2 ------'
        dLlave = QLlave

        dCad1 = Mid(dLlave, 1, dVer1 + 1)
        dCad2 = Mid(dLlave, dVer1 + 2, dVer2 + 1)
        dCad3 = Mid(dLlave, dVer1 + dVer2 + 3, dVer3 + 1)
        dCad4 = Mid(dLlave, dVer1 + dVer2 + dVer3 + 4, dVer4 + 1)
        dCad5 = Mid(dLlave, dVer1 + dVer2 + dVer3 + dVer4 + 5, dVer5 + 1)

        Dim xxNoAutorizacion As String
        Dim xxNoFactura As String
        Dim xxNit As String
        Dim xxFecha As String
        Dim xxImporte As String

        xxNoAutorizacion = Trim(QNoAutorizacion) & dCad1
        xxNoFactura = Trim(dNoFactura) & dCad2
        xxNit = Trim(dNit) & dCad3
        xxFecha = Trim(dFecha) & dCad4
        xxImporte = Trim(dImporte) & dCad5

        'MessageBox.Show(xxNoAutorizacion)
        'MessageBox.Show(xxNoFactura)
        'MessageBox.Show(xxNit)
        'MessageBox.Show(xxFecha)
        'MessageBox.Show(xxImporte)

        '------ PASO 3 -------'

        Dim xxCadena As String
        Dim xxLlaveCif As String
        Dim xxARC4 As String
        xxCadena = xxNoAutorizacion & xxNoFactura & xxNit & xxFecha & xxImporte
        xxLlaveCif = QLlave & Trim(Str(dVer1)) & Trim(Str(dVer2)) & Trim(Str(dVer3)) & Trim(Str(dVer4)) & Trim(Str(dVer5))
        xxARC4 = CifrarMensajeRC4(xxCadena, xxLlaveCif)
        'MessageBox.Show(xxCadena)
        'MessageBox.Show(xxLlaveCif)
        'MessageBox.Show(xxARC4)

        '------- PASO 4 ------'
        Dim ST As Double
        Dim SP1 As Double
        Dim SP2 As Double
        Dim SP3 As Double
        Dim SP4 As Double
        Dim SP5 As Double
        Dim I As Integer
        Dim J As Integer
        J = 1
        For I = 1 To Len(xxARC4)
            ' MessageBox.Show(Asc(Mid(xxARC4, I, 1)))
            ST = ST + Asc(Mid(xxARC4, I, 1))
            Select Case J
                Case 1
                    SP1 = SP1 + Asc(Mid(xxARC4, I, 1))
                Case 2
                    SP2 = SP2 + Asc(Mid(xxARC4, I, 1))
                Case 3
                    SP3 = SP3 + Asc(Mid(xxARC4, I, 1))
                Case 4
                    SP4 = SP4 + Asc(Mid(xxARC4, I, 1))
                Case 5
                    SP5 = SP5 + Asc(Mid(xxARC4, I, 1))
            End Select
            If J < 5 Then
                J += 1
            Else
                J = 1
            End If
        Next

        'MessageBox.Show(ST)
        'MessageBox.Show(SP1)
        'MessageBox.Show(SP2)
        'MessageBox.Show(SP3)
        'MessageBox.Show(SP4)
        'MessageBox.Show(SP5)

        '---- PASO 5 -----'

        Dim MSP1 As Double
        Dim MSP2 As Double
        Dim MSP3 As Double
        Dim MSP4 As Double
        Dim MSP5 As Double
        Dim MTOT As Double
        Dim Base64 As String

        MSP1 = Math.Truncate((SP1 * ST) / (dVer1 + 1))
        MSP2 = Math.Truncate((SP2 * ST) / (dVer2 + 1))
        MSP3 = Math.Truncate((SP3 * ST) / (dVer3 + 1))
        MSP4 = Math.Truncate((SP4 * ST) / (dVer4 + 1))
        MSP5 = Math.Truncate((SP5 * ST) / (dVer5 + 1))
        MTOT = MSP1 + MSP2 + MSP3 + MSP4 + MSP5

        Base64 = ObtenerBase64(MTOT)
        'MessageBox.Show(Base64)

        '------ PASO 6 ------'
        Dim REsultado As String

        REsultado = CifrarMensajeRC4_Final(Base64, QLlave & Trim(dVer1) & Trim(dVer2) & Trim(dVer3) & Trim(dVer4) & Trim(dVer5))

        ObtenerCodigo = REsultado
    End Function

    Private Function ObtenerVerhoeff(ByVal Numero As String) As String
        Dim Mul(9, 9) As Integer
        Dim Per(7, 9) As Integer
        Dim Inv(10) As Integer
        Dim NumeroInvertido As String
        Dim Chek As Integer
        Dim I As Single

        Mul(0, 0) = 0 : Mul(0, 1) = 1 : Mul(0, 2) = 2 : Mul(0, 3) = 3 : Mul(0, 4) = 4 : Mul(0, 5) = 5 : Mul(0, 6) = 6 : Mul(0, 7) = 7 : Mul(0, 8) = 8 : Mul(0, 9) = 9
        Mul(1, 0) = 1 : Mul(1, 1) = 2 : Mul(1, 2) = 3 : Mul(1, 3) = 4 : Mul(1, 4) = 0 : Mul(1, 5) = 6 : Mul(1, 6) = 7 : Mul(1, 7) = 8 : Mul(1, 8) = 9 : Mul(1, 9) = 5
        Mul(2, 0) = 2 : Mul(2, 1) = 3 : Mul(2, 2) = 4 : Mul(2, 3) = 0 : Mul(2, 4) = 1 : Mul(2, 5) = 7 : Mul(2, 6) = 8 : Mul(2, 7) = 9 : Mul(2, 8) = 5 : Mul(2, 9) = 6
        Mul(3, 0) = 3 : Mul(3, 1) = 4 : Mul(3, 2) = 0 : Mul(3, 3) = 1 : Mul(3, 4) = 2 : Mul(3, 5) = 8 : Mul(3, 6) = 9 : Mul(3, 7) = 5 : Mul(3, 8) = 6 : Mul(3, 9) = 7
        Mul(4, 0) = 4 : Mul(4, 1) = 0 : Mul(4, 2) = 1 : Mul(4, 3) = 2 : Mul(4, 4) = 3 : Mul(4, 5) = 9 : Mul(4, 6) = 5 : Mul(4, 7) = 6 : Mul(4, 8) = 7 : Mul(4, 9) = 8
        Mul(5, 0) = 5 : Mul(5, 1) = 9 : Mul(5, 2) = 8 : Mul(5, 3) = 7 : Mul(5, 4) = 6 : Mul(5, 5) = 0 : Mul(5, 6) = 4 : Mul(5, 7) = 3 : Mul(5, 8) = 2 : Mul(5, 9) = 1
        Mul(6, 0) = 6 : Mul(6, 1) = 5 : Mul(6, 2) = 9 : Mul(6, 3) = 8 : Mul(6, 4) = 7 : Mul(6, 5) = 1 : Mul(6, 6) = 0 : Mul(6, 7) = 4 : Mul(6, 8) = 3 : Mul(6, 9) = 2
        Mul(7, 0) = 7 : Mul(7, 1) = 6 : Mul(7, 2) = 5 : Mul(7, 3) = 9 : Mul(7, 4) = 8 : Mul(7, 5) = 2 : Mul(7, 6) = 1 : Mul(7, 7) = 0 : Mul(7, 8) = 4 : Mul(7, 9) = 3
        Mul(8, 0) = 8 : Mul(8, 1) = 7 : Mul(8, 2) = 6 : Mul(8, 3) = 5 : Mul(8, 4) = 9 : Mul(8, 5) = 3 : Mul(8, 6) = 2 : Mul(8, 7) = 1 : Mul(8, 8) = 0 : Mul(8, 9) = 4
        Mul(9, 0) = 9 : Mul(9, 1) = 8 : Mul(9, 2) = 7 : Mul(9, 3) = 6 : Mul(9, 4) = 5 : Mul(9, 5) = 4 : Mul(9, 6) = 3 : Mul(9, 7) = 2 : Mul(9, 8) = 1 : Mul(9, 9) = 0

        Per(0, 0) = 0 : Per(0, 1) = 1 : Per(0, 2) = 2 : Per(0, 3) = 3 : Per(0, 4) = 4 : Per(0, 5) = 5 : Per(0, 6) = 6 : Per(0, 7) = 7 : Per(0, 8) = 8 : Per(0, 9) = 9
        Per(1, 0) = 1 : Per(1, 1) = 5 : Per(1, 2) = 7 : Per(1, 3) = 6 : Per(1, 4) = 2 : Per(1, 5) = 8 : Per(1, 6) = 3 : Per(1, 7) = 0 : Per(1, 8) = 9 : Per(1, 9) = 4
        Per(2, 0) = 5 : Per(2, 1) = 8 : Per(2, 2) = 0 : Per(2, 3) = 3 : Per(2, 4) = 7 : Per(2, 5) = 9 : Per(2, 6) = 6 : Per(2, 7) = 1 : Per(2, 8) = 4 : Per(2, 9) = 2
        Per(3, 0) = 8 : Per(3, 1) = 9 : Per(3, 2) = 1 : Per(3, 3) = 6 : Per(3, 4) = 0 : Per(3, 5) = 4 : Per(3, 6) = 3 : Per(3, 7) = 5 : Per(3, 8) = 2 : Per(3, 9) = 7
        Per(4, 0) = 9 : Per(4, 1) = 4 : Per(4, 2) = 5 : Per(4, 3) = 3 : Per(4, 4) = 1 : Per(4, 5) = 2 : Per(4, 6) = 6 : Per(4, 7) = 8 : Per(4, 8) = 7 : Per(4, 9) = 0
        Per(5, 0) = 4 : Per(5, 1) = 2 : Per(5, 2) = 8 : Per(5, 3) = 6 : Per(5, 4) = 5 : Per(5, 5) = 7 : Per(5, 6) = 3 : Per(5, 7) = 9 : Per(5, 8) = 0 : Per(5, 9) = 1
        Per(6, 0) = 2 : Per(6, 1) = 7 : Per(6, 2) = 9 : Per(6, 3) = 3 : Per(6, 4) = 8 : Per(6, 5) = 0 : Per(6, 6) = 6 : Per(6, 7) = 4 : Per(6, 8) = 1 : Per(6, 9) = 5
        Per(7, 0) = 7 : Per(7, 1) = 0 : Per(7, 2) = 4 : Per(7, 3) = 6 : Per(7, 4) = 9 : Per(7, 5) = 1 : Per(7, 6) = 3 : Per(7, 7) = 2 : Per(7, 8) = 5 : Per(7, 9) = 8

        Inv(0) = 0 : Inv(1) = 4 : Inv(2) = 3 : Inv(3) = 2 : Inv(4) = 1 : Inv(5) = 5 : Inv(6) = 6 : Inv(7) = 7 : Inv(8) = 8 : Inv(9) = 9
        Chek = 0

        NumeroInvertido = InvierteNumero(Numero)
        For I = 0 To (Len(NumeroInvertido) - 1)
            Chek = Mul(Chek, Per(((I + 1) Mod 8), Mid(NumeroInvertido, (I + 1), 1)))
        Next
        ObtenerVerhoeff = Inv(Chek)
    End Function

    Private Function InvierteNumero(ByVal Num As String) As String
        Dim j As Integer
        Dim cNum As String
        Dim tNum As String = ""
        cNum = Trim(Num)
        For j = Len(cNum) To 1 Step -1
            tNum = tNum & Mid(cNum, j, 1)
        Next
        InvierteNumero = Trim(tNum)
    End Function

    Private Function ObtenerBase64(ByVal Numero As Int64) As String
        Dim Diccionario(63) As String
        Dim Cociente As Double
        Dim Resto As Double
        Dim Palabra As String = ""

        Diccionario(0) = "0" : Diccionario(1) = "1" : Diccionario(2) = "2" : Diccionario(3) = "3" : Diccionario(4) = "4" : Diccionario(5) = "5" : Diccionario(6) = "6" : Diccionario(7) = "7" : Diccionario(8) = "8" : Diccionario(9) = "9"
        Diccionario(10) = "A" : Diccionario(11) = "B" : Diccionario(12) = "C" : Diccionario(13) = "D" : Diccionario(14) = "E" : Diccionario(15) = "F" : Diccionario(16) = "G" : Diccionario(17) = "H" : Diccionario(18) = "I" : Diccionario(19) = "J"
        Diccionario(20) = "K" : Diccionario(21) = "L" : Diccionario(22) = "M" : Diccionario(23) = "N" : Diccionario(24) = "O" : Diccionario(25) = "P" : Diccionario(26) = "Q" : Diccionario(27) = "R" : Diccionario(28) = "S" : Diccionario(29) = "T"
        Diccionario(30) = "U" : Diccionario(31) = "V" : Diccionario(32) = "W" : Diccionario(33) = "X" : Diccionario(34) = "Y" : Diccionario(35) = "Z" : Diccionario(36) = "a" : Diccionario(37) = "b" : Diccionario(38) = "c" : Diccionario(39) = "d"
        Diccionario(40) = "e" : Diccionario(41) = "f" : Diccionario(42) = "g" : Diccionario(43) = "h" : Diccionario(44) = "i" : Diccionario(45) = "j" : Diccionario(46) = "k" : Diccionario(47) = "l" : Diccionario(48) = "m" : Diccionario(49) = "n"
        Diccionario(50) = "o" : Diccionario(51) = "p" : Diccionario(52) = "q" : Diccionario(53) = "r" : Diccionario(54) = "s" : Diccionario(55) = "t" : Diccionario(56) = "u" : Diccionario(57) = "v" : Diccionario(58) = "w" : Diccionario(59) = "x"
        Diccionario(60) = "y" : Diccionario(61) = "z" : Diccionario(62) = "+" : Diccionario(63) = "/"

        Cociente = 1

        Do While Cociente > 0
            Cociente = Int(Numero / 64)
            Resto = Int(Numero Mod 64)
            Palabra = Diccionario(Resto) + Palabra
            Numero = Cociente
        Loop
        ObtenerBase64 = Palabra
    End Function

    Private Function CifrarMensajeRC4(ByVal Mensaje As String, ByVal Key As String) As String
        Dim State(255) As Double
        Dim x As Double, y As Double, Index1, Index2, NMen As Double, I As Double
        Dim MensajeCifrado As String = ""
        Dim Aux1 As Double
        Dim Aux2 As Double

        x = 0
        y = 0
        Index1 = 0
        Index2 = 0

        For I = 0 To 255
            State(I) = I
        Next

        For I = 0 To 255
            Index2 = (Asc(Mid(Key, (Index1 + 1), 1)) + State(I) + Index2) Mod 256
            Aux1 = State(I)
            Aux2 = State(Index2)
            State(I) = Aux2
            State(Index2) = Aux1

            Index1 = (Index1 + 1) Mod Len(Key)
        Next

        For I = 0 To Len(Mensaje) - 1
            x = (x + 1) Mod 256
            y = (State(x) + y) Mod 256
            Aux1 = State(x)
            Aux2 = State(y)
            State(x) = Aux2
            State(y) = Aux1
            NMen = Asc(Mid(Mensaje, (I + 1), 1)) Xor State((State(x) + State(y)) Mod 256)
            MensajeCifrado = MensajeCifrado + RellenoCero(Hex(NMen))
        Next

        CifrarMensajeRC4 = Mid(MensajeCifrado, 1, Len(MensajeCifrado))
    End Function

    Private Function CifrarMensajeRC4_Final(ByVal Mensaje As String, ByVal Key As String) As String
        Dim State(255) As Double
        Dim x As Double, y As Double, Index1, Index2, NMen As Double, I As Double
        Dim MensajeCifrado As String = ""
        Dim Aux1 As Double
        Dim Aux2 As Double

        x = 0
        y = 0
        Index1 = 0
        Index2 = 0

        For I = 0 To 255
            State(I) = I
        Next

        For I = 0 To 255
            Index2 = (Asc(Mid(Key, (Index1 + 1), 1)) + State(I) + Index2) Mod 256
            Aux1 = State(I)
            Aux2 = State(Index2)
            State(I) = Aux2
            State(Index2) = Aux1

            Index1 = (Index1 + 1) Mod Len(Key)
        Next

        For I = 0 To Len(Mensaje) - 1
            x = (x + 1) Mod 256
            y = (State(x) + y) Mod 256
            Aux1 = State(x)
            Aux2 = State(y)
            State(x) = Aux2
            State(y) = Aux1
            NMen = Asc(Mid(Mensaje, (I + 1), 1)) Xor State((State(x) + State(y)) Mod 256)
            MensajeCifrado = MensajeCifrado + "-" + RellenoCero(Hex(NMen))
        Next

        CifrarMensajeRC4_Final = Mid(MensajeCifrado, 2, Len(MensajeCifrado))
    End Function


    Private Function RellenoCero(ByVal Texto As String) As String
        If Len(Texto) = 1 Then
            RellenoCero = "0" & Texto
        Else
            RellenoCero = Texto
        End If
    End Function
End Class

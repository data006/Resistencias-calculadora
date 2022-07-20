Public Class frmResistenciasVB


    Dim banda1, banda2, banda3, banda4, valorPrincipal, resultado As Integer
    Dim digitos As String


    'Cargar form
    Private Sub frmResistenciasVB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rdbValor.Checked = True
        rdbColores.Checked = False

        grpBanda1.Enabled = False
        grpBanda2.Enabled = False
        grpBanda3.Enabled = False
        grpBanda4.Enabled = False

        rdbNegro1.Checked = True
        rdbNegro2.Checked = True
        rdbNegro3.Checked = True
        rdbRojo4.Checked = True

        pnlBanda1.BackColor = Color.Black
        pnlBanda2.BackColor = Color.Black
        pnlBanda3.BackColor = Color.Black
        pnlBandaTolerancia.BackColor = Color.Red

        cmbPrimerDigito.SelectedIndex = 0
        cmbSegundoDigito.SelectedIndex = 0
        cmbMultiplicador.SelectedIndex = 0
        cmbTolerancia.SelectedIndex = 0

    End Sub


    'Timer
    Private Sub tmrTiempo_Tick(sender As Object, e As EventArgs) Handles tmrTiempo.Tick

        If rdbColores.Checked = True Then

            grpBanda1.Enabled = True
            grpBanda2.Enabled = True
            grpBanda3.Enabled = True
            grpBanda4.Enabled = True
            grpConValores.Enabled = False




            'Banda 1
            If rdbNegro1.Checked = True Then
                banda1 = 0
                pnlBanda1.BackColor = Color.Black

            ElseIf rdbCafe1.Checked = True Then
                banda1 = 1
                pnlBanda1.BackColor = Color.Brown

            ElseIf rdbRojo1.Checked = True Then
                banda1 = 2
                pnlBanda1.BackColor = Color.Red

            ElseIf rdbNaranja1.Checked = True Then
                banda1 = 3
                pnlBanda1.BackColor = Color.Orange

            ElseIf rdbAmarillo1.Checked = True Then
                banda1 = 4
                pnlBanda1.BackColor = Color.Yellow

            ElseIf rdbVerde1.Checked = True Then
                banda1 = 5
                pnlBanda1.BackColor = Color.Green

            ElseIf rdbAzul1.Checked = True Then
                banda1 = 6
                pnlBanda1.BackColor = Color.Blue

            ElseIf rdbMorado1.Checked = True Then
                banda1 = 7
                pnlBanda1.BackColor = Color.Purple

            ElseIf rdbGris1.Checked = True Then
                banda1 = 8
                pnlBanda1.BackColor = Color.Gray

            ElseIf rdbBlanco1.Checked = True Then
                banda1 = 9
                pnlBanda1.BackColor = Color.White
            End If





            'Banda 2
            If rdbNegro2.Checked = True Then
                banda2 = 0
                pnlBanda2.BackColor = Color.Black

            ElseIf rdbCafe2.Checked = True Then
                banda2 = 1
                pnlBanda2.BackColor = Color.Brown

            ElseIf rdbRojo2.Checked = True Then
                banda2 = 2
                pnlBanda2.BackColor = Color.Red

            ElseIf rdbNaranja2.Checked = True Then
                banda2 = 3
                pnlBanda2.BackColor = Color.Orange

            ElseIf rdbAmarillo2.Checked = True Then
                banda2 = 4
                pnlBanda2.BackColor = Color.Yellow

            ElseIf rdbVerde2.Checked = True Then
                banda2 = 5
                pnlBanda2.BackColor = Color.Green

            ElseIf rdbAzul2.Checked = True Then
                banda2 = 6
                pnlBanda2.BackColor = Color.Blue

            ElseIf rdbMorado2.Checked = True Then
                banda2 = 7
                pnlBanda2.BackColor = Color.Purple

            ElseIf rdbGris2.Checked = True Then
                banda2 = 8
                pnlBanda2.BackColor = Color.Gray

            ElseIf rdbBlanco2.Checked = True Then
                banda2 = 9
                pnlBanda2.BackColor = Color.White
            End If






            '''''''''''''''''''''''''''''''''''''''''''''''''''"""""""
            'Banda 3
            If rdbNegro3.Checked = True Then
                banda3 = 10 ^ 0
                pnlBanda3.BackColor = Color.Black

                If banda1 = 0 Then
                    lblValor.Text = banda2 & " Ω"

                Else
                    lblValor.Text = banda1 & banda2 & " Ω"
                End If


            ElseIf rdbCafe3.Checked = True Then
                banda3 = 10 ^ 1
                pnlBanda3.BackColor = Color.Brown

                If banda1 = 0 Then
                    If banda2 = 0 Then
                        lblValor.Text = banda2 & " Ω"

                    Else
                        lblValor.Text = banda2 & "0" & " Ω"
                    End If


                Else
                    lblValor.Text = banda1 & banda2 & "0" & " Ω"
                End If
                ''''''
            ElseIf rdbRojo3.Checked = True Then
                banda3 = 10 ^ 2
                pnlBanda3.BackColor = Color.Red

                If banda1 = 0 Then
                    If banda2 = 0 Then
                        lblValor.Text = banda2 & " Ω"

                    Else
                        lblValor.Text = banda2 & "0" & "0" & " Ω"
                    End If


                Else
                    If banda2 = 0 Then
                        lblValor.Text = banda1 & " KΩ"

                    Else
                        lblValor.Text = banda1 & "." & banda2 & " KΩ"
                    End If

                End If
                ''''''''
            ElseIf rdbNaranja3.Checked = True Then
                banda3 = 10 ^ 3
                pnlBanda3.BackColor = Color.Orange

                If banda1 = 0 Then
                    If banda2 = 0 Then
                        lblValor.Text = banda2 & " Ω"

                    Else
                        lblValor.Text = banda2 & " KΩ"
                    End If


                Else
                    If banda2 = 0 Then
                        lblValor.Text = banda1 & "0" & " KΩ"

                    Else
                        lblValor.Text = banda1 & banda2 & " KΩ"
                    End If

                End If
                '''''
            ElseIf rdbAmarillo3.Checked = True Then
                banda3 = 10 ^ 4
                pnlBanda3.BackColor = Color.Yellow

                If banda1 = 0 Then
                    If banda2 = 0 Then
                        lblValor.Text = banda2 & " Ω"

                    Else
                        lblValor.Text = banda2 & "0" & " KΩ"
                    End If


                Else
                    If banda2 = 0 Then
                        lblValor.Text = banda1 & banda2 & "0" & " KΩ"

                    Else
                        lblValor.Text = banda1 & banda2 & "0" & " KΩ"
                    End If

                End If
                '''''''
            ElseIf rdbVerde3.Checked = True Then
                banda3 = 10 ^ 5
                pnlBanda3.BackColor = Color.Green

                If banda1 = 0 Then
                    If banda2 = 0 Then
                        lblValor.Text = banda2 & " Ω"

                    Else
                        lblValor.Text = banda2 & "00" & " KΩ"
                    End If


                Else
                    If banda2 = 0 Then
                        lblValor.Text = banda1 & " MΩ"

                    Else
                        lblValor.Text = banda1 & "." & banda2 & " MΩ"
                    End If

                End If
                '''''''
            ElseIf rdbAzul3.Checked = True Then
                banda3 = 10 ^ 6
                pnlBanda3.BackColor = Color.Blue

                If banda1 = 0 Then
                    If banda2 = 0 Then
                        lblValor.Text = banda2 & " Ω"

                    Else
                        lblValor.Text = banda2 & " MΩ"
                    End If


                Else
                    If banda2 = 0 Then
                        lblValor.Text = banda1 & banda2 & " MΩ"

                    Else
                        lblValor.Text = banda1 & banda2 & " MΩ"
                    End If

                End If
                ''''''''''''
            ElseIf rdbMorado3.Checked = True Then
                banda3 = 10 ^ 7
                pnlBanda3.BackColor = Color.Purple

                If banda1 = 0 Then
                    If banda2 = 0 Then
                        lblValor.Text = banda2 & " Ω"

                    Else
                        lblValor.Text = banda2 & "0" & " MΩ"
                    End If


                Else
                    If banda2 = 0 Then
                        lblValor.Text = banda1 & banda2 & "0" & " MΩ"

                    Else
                        lblValor.Text = banda1 & banda2 & "0" & " MΩ"
                    End If

                End If
                '''''''''''''''''''
            ElseIf rdbGris3.Checked = True Then
                banda3 = 10 ^ 8
                pnlBanda3.BackColor = Color.Gray

                If banda1 = 0 Then
                    If banda2 = 0 Then
                        lblValor.Text = banda2 & " Ω"

                    Else
                        lblValor.Text = banda2 & "00" & " MΩ"
                    End If


                Else
                    If banda2 = 0 Then
                        lblValor.Text = banda1 & " GΩ"

                    Else
                        lblValor.Text = banda1 & "." & banda2 & " GΩ"
                    End If

                End If
                ''''''''''''''''''''''
            ElseIf rdbBlanco3.Checked = True Then
                banda3 = 10 ^ 9
                pnlBanda3.BackColor = Color.White

                If banda1 = 0 Then
                    If banda2 = 0 Then
                        lblValor.Text = banda2 & " Ω"

                    Else
                        lblValor.Text = banda2 & " GΩ"
                    End If


                Else
                    If banda2 = 0 Then
                        lblValor.Text = banda1 & banda2 & " GΩ"

                    Else
                        lblValor.Text = banda1 & banda2 & " GΩ"
                    End If

                End If
            End If







            'Banda 4 Tolerancia
            If rdbRojo4.Checked = True Then
                banda4 = 2
                pnlBandaTolerancia.BackColor = Color.Red

                lblValor.Text = lblValor.Text & " +-2%"

            ElseIf rdbDorado4.Checked = True Then
                banda4 = 5
                pnlBandaTolerancia.BackColor = Color.Gold

                lblValor.Text = lblValor.Text & " +-5%"

            ElseIf rdbPlateado4.Checked = True Then
                banda4 = 10
                pnlBandaTolerancia.BackColor = Color.Silver

                lblValor.Text = lblValor.Text & " +-10%"


            End If


            digitos = banda1 & banda2




        End If





        If rdbValor.Checked = True Then

            grpConValores.Enabled = True
            grpBanda1.Enabled = False
            grpBanda2.Enabled = False
            grpBanda3.Enabled = False
            grpBanda4.Enabled = False

            If cmbPrimerDigito.SelectedItem = 0 Then
                pnlBanda1.BackColor = Color.Black

            ElseIf cmbPrimerDigito.SelectedItem = 1 Then
                pnlBanda1.BackColor = Color.Brown

            ElseIf cmbPrimerDigito.SelectedItem = 2 Then
                pnlBanda1.BackColor = Color.Red

            ElseIf cmbPrimerDigito.SelectedItem = 3 Then
                pnlBanda1.BackColor = Color.Orange

            ElseIf cmbPrimerDigito.SelectedItem = 4 Then
                pnlBanda1.BackColor = Color.Yellow

            ElseIf cmbPrimerDigito.SelectedItem = 5 Then
                pnlBanda1.BackColor = Color.Green

            ElseIf cmbPrimerDigito.SelectedItem = 6 Then
                pnlBanda1.BackColor = Color.Blue

            ElseIf cmbPrimerDigito.SelectedItem = 7 Then
                pnlBanda1.BackColor = Color.Purple

            ElseIf cmbPrimerDigito.SelectedItem = 8 Then
                pnlBanda1.BackColor = Color.Gray

            ElseIf cmbPrimerDigito.SelectedItem = 9 Then
                pnlBanda1.BackColor = Color.White
            End If


            If cmbSegundoDigito.SelectedItem = 0 Then
                pnlBanda2.BackColor = Color.Black

            ElseIf cmbSegundoDigito.SelectedItem = 1 Then
                pnlBanda2.BackColor = Color.Brown

            ElseIf cmbSegundoDigito.SelectedItem = 2 Then
                pnlBanda2.BackColor = Color.Red

            ElseIf cmbSegundoDigito.SelectedItem = 3 Then
                pnlBanda2.BackColor = Color.Orange

            ElseIf cmbSegundoDigito.SelectedItem = 4 Then
                pnlBanda2.BackColor = Color.Yellow

            ElseIf cmbSegundoDigito.SelectedItem = 5 Then
                pnlBanda2.BackColor = Color.Green

            ElseIf cmbSegundoDigito.SelectedItem = 6 Then
                pnlBanda2.BackColor = Color.Blue

            ElseIf cmbSegundoDigito.SelectedItem = 7 Then
                pnlBanda2.BackColor = Color.Purple

            ElseIf cmbSegundoDigito.SelectedItem = 8 Then
                pnlBanda2.BackColor = Color.Gray

            ElseIf cmbSegundoDigito.SelectedItem = 9 Then
                pnlBanda2.BackColor = Color.White
            End If

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            If cmbMultiplicador.SelectedIndex = 0 Then
                pnlBanda3.BackColor = Color.Black

                If cmbPrimerDigito.SelectedItem = 0 Then
                    lblValor.Text = cmbSegundoDigito.SelectedItem & " Ω"

                Else
                    lblValor.Text = cmbPrimerDigito.SelectedItem & cmbSegundoDigito.SelectedItem & " Ω"
                End If

            ElseIf cmbMultiplicador.SelectedIndex = 1 Then
                pnlBanda3.BackColor = Color.Brown

                If cmbPrimerDigito.SelectedItem = 0 Then
                    If cmbSegundoDigito.SelectedItem = 0 Then
                        lblValor.Text = cmbSegundoDigito.SelectedItem & " Ω"

                    Else
                        lblValor.Text = cmbSegundoDigito.SelectedItem & "0" & " Ω"
                    End If


                Else
                    lblValor.Text = cmbPrimerDigito.SelectedItem & cmbSegundoDigito.SelectedItem & "0" & " Ω"
                End If

            ElseIf cmbMultiplicador.SelectedIndex = 2 Then
                pnlBanda3.BackColor = Color.Red

                If cmbPrimerDigito.SelectedItem = 0 Then
                    If cmbSegundoDigito.SelectedItem = 0 Then
                        lblValor.Text = cmbSegundoDigito.SelectedItem & " Ω"

                    Else
                        lblValor.Text = cmbSegundoDigito.SelectedItem & "0" & "0" & " Ω"
                    End If


                Else
                    If cmbSegundoDigito.SelectedItem = 0 Then
                        lblValor.Text = cmbPrimerDigito.SelectedItem & " KΩ"

                    Else
                        lblValor.Text = cmbPrimerDigito.SelectedItem & "." & cmbSegundoDigito.SelectedItem & " KΩ"
                    End If

                End If

            ElseIf cmbMultiplicador.SelectedIndex = 3 Then
                pnlBanda3.BackColor = Color.Orange

                If cmbPrimerDigito.SelectedItem = 0 Then
                    If cmbSegundoDigito.SelectedItem = 0 Then
                        lblValor.Text = cmbSegundoDigito.SelectedItem & " Ω"

                    Else
                        lblValor.Text = cmbSegundoDigito.SelectedItem & " KΩ"
                    End If


                Else
                    If cmbSegundoDigito.SelectedItem = 0 Then
                        lblValor.Text = cmbPrimerDigito.SelectedItem & "0" & " KΩ"

                    Else
                        lblValor.Text = cmbPrimerDigito.SelectedItem & cmbSegundoDigito.SelectedItem & " KΩ"
                    End If

                End If

            ElseIf cmbMultiplicador.SelectedIndex = 4 Then
                pnlBanda3.BackColor = Color.Yellow

                If cmbPrimerDigito.SelectedItem = 0 Then
                    If cmbSegundoDigito.SelectedItem = 0 Then
                        lblValor.Text = cmbSegundoDigito.SelectedItem & " Ω"

                    Else
                        lblValor.Text = cmbSegundoDigito.SelectedItem & "0" & " KΩ"
                    End If


                Else
                    If cmbSegundoDigito.SelectedItem = 0 Then
                        lblValor.Text = cmbPrimerDigito.SelectedItem & cmbSegundoDigito.SelectedItem & "0" & " KΩ"

                    Else
                        lblValor.Text = cmbPrimerDigito.SelectedItem & cmbSegundoDigito.SelectedItem & "0" & " KΩ"
                    End If

                End If

            ElseIf cmbMultiplicador.SelectedIndex = 5 Then
                pnlBanda3.BackColor = Color.Green

                If cmbPrimerDigito.SelectedItem = 0 Then
                    If cmbSegundoDigito.SelectedItem = 0 Then
                        lblValor.Text = cmbSegundoDigito.SelectedItem & " Ω"

                    Else
                        lblValor.Text = cmbSegundoDigito.SelectedItem & "00" & " KΩ"
                    End If


                Else
                    If cmbSegundoDigito.SelectedItem = 0 Then
                        lblValor.Text = cmbPrimerDigito.SelectedItem & " MΩ"

                    Else
                        lblValor.Text = cmbPrimerDigito.SelectedItem & "." & cmbSegundoDigito.SelectedItem & " MΩ"
                    End If

                End If

            ElseIf cmbMultiplicador.SelectedIndex = 6 Then
                pnlBanda3.BackColor = Color.Blue

                If cmbPrimerDigito.SelectedItem = 0 Then
                    If cmbSegundoDigito.SelectedItem = 0 Then
                        lblValor.Text = cmbSegundoDigito.SelectedItem & " Ω"

                    Else
                        lblValor.Text = cmbSegundoDigito.SelectedItem & " MΩ"
                    End If


                Else
                    If cmbSegundoDigito.SelectedItem = 0 Then
                        lblValor.Text = cmbPrimerDigito.SelectedItem & cmbSegundoDigito.SelectedItem & " MΩ"

                    Else
                        lblValor.Text = cmbPrimerDigito.SelectedItem & cmbSegundoDigito.SelectedItem & " MΩ"
                    End If

                End If

            ElseIf cmbMultiplicador.SelectedIndex = 7 Then
                pnlBanda3.BackColor = Color.Purple

                If cmbPrimerDigito.SelectedItem = 0 Then
                    If cmbSegundoDigito.SelectedItem = 0 Then
                        lblValor.Text = cmbSegundoDigito.SelectedItem & " Ω"

                    Else
                        lblValor.Text = cmbSegundoDigito.SelectedItem & "0" & " MΩ"
                    End If


                Else
                    If cmbSegundoDigito.SelectedItem = 0 Then
                        lblValor.Text = cmbPrimerDigito.SelectedItem & cmbSegundoDigito.SelectedItem & "0" & " MΩ"

                    Else
                        lblValor.Text = cmbPrimerDigito.SelectedItem & cmbSegundoDigito.SelectedItem & "0" & " MΩ"
                    End If

                End If

            ElseIf cmbMultiplicador.SelectedIndex = 8 Then
                pnlBanda3.BackColor = Color.Gray

                If cmbPrimerDigito.SelectedItem = 0 Then
                    If cmbSegundoDigito.SelectedItem = 0 Then
                        lblValor.Text = cmbSegundoDigito.SelectedItem & " Ω"

                    Else
                        lblValor.Text = cmbSegundoDigito.SelectedItem & "00" & " MΩ"
                    End If


                Else
                    If cmbSegundoDigito.SelectedItem = 0 Then
                        lblValor.Text = cmbPrimerDigito.SelectedItem & " GΩ"

                    Else
                        lblValor.Text = cmbPrimerDigito.SelectedItem & "." & cmbSegundoDigito.SelectedItem & " GΩ"
                    End If

                End If

            ElseIf cmbMultiplicador.SelectedIndex = 9 Then
                pnlBanda3.BackColor = Color.White

                If cmbPrimerDigito.SelectedItem = 0 Then
                    If cmbSegundoDigito.SelectedItem = 0 Then
                        lblValor.Text = cmbSegundoDigito.SelectedItem & " Ω"

                    Else
                        lblValor.Text = cmbSegundoDigito.SelectedItem & " GΩ"
                    End If


                Else
                    If cmbSegundoDigito.SelectedItem = 0 Then
                        lblValor.Text = cmbPrimerDigito.SelectedItem & cmbSegundoDigito.SelectedItem & " GΩ"

                    Else
                        lblValor.Text = cmbPrimerDigito.SelectedItem & cmbSegundoDigito.SelectedItem & " GΩ"
                    End If

                End If
            End If




            If cmbTolerancia.SelectedIndex = 0 Then

                pnlBandaTolerancia.BackColor = Color.Red
                lblValor.Text = lblValor.Text & " +-2%"

            ElseIf cmbTolerancia.SelectedIndex = 1 Then

                pnlBandaTolerancia.BackColor = Color.Gold
                lblValor.Text = lblValor.Text & " +-5%"

            ElseIf cmbTolerancia.SelectedIndex = 2 Then

                pnlBandaTolerancia.BackColor = Color.Silver
                lblValor.Text = lblValor.Text & " +-10%"

            End If

        End If


    End Sub


End Class


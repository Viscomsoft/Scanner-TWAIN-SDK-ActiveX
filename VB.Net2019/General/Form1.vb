Public Class Form1
    Dim clrHashForeColor
    Dim clrHashBackColor
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim I As Integer
        Dim iCount As Integer

        chkautosaveallpage.Text = "Automate save to PDF " & vbCrLf & "when last page scanned"
        cbotifcompression.Items.Add("LZW")
        cbotifcompression.Items.Add("CITT3")
        cbotifcompression.Items.Add("CITT4")
        cbotifcompression.Items.Add("RLE")
        cbotifcompression.Items.Add("None")
        cbotifcompression.SelectedIndex = 0

        cboutputtype.Items.Add("BMP")
        cboutputtype.Items.Add("JPG")
        cboutputtype.Items.Add("GIF")
        cboutputtype.Items.Add("PNG")
        cboutputtype.Items.Add("TIF")
        cboutputtype.Items.Add("PDF")
        cboutputtype.SelectedIndex = 0


        cbodpi.Items.Add("Onscreen Viewing 96dpi")
        cbodpi.Items.Add("Fax 200dpi")
        cbodpi.Items.Add("OCR Text 300dpi")
        cbodpi.Items.Add("Laser Print Fine 600dpi")
        cbodpi.SelectedIndex = 0

        cbopixeltype.Items.Add("Default")
        cbopixeltype.Items.Add("Gray Color")
        cbopixeltype.Items.Add("Black & White Color")
        cbopixeltype.Items.Add("True Color")

        cbopixeltype.SelectedIndex = 0



        clrHashForeColor = RGB(0, 0, 0)
        clrHashBackColor = RGB(255, 255, 255)

        iCount = Me.AxScanner1.GetNumImageSources

        For I = 0 To iCount - 1
            cboimagesource.Items.Add(AxScanner1.GetImageSourceName(I))
        Next

        If iCount > 0 Then
            cboimagesource.SelectedIndex = 0
        End If

        For I = 8 To 60 Step 2
            cbofontsize.Items.Add(Trim(Str(I)))
        Next
        cbofontsize.SelectedIndex = 2


        cbofont.Items.Add("Arial")
        cbofont.Items.Add("Arial Black")
        cbofont.Items.Add("Comic Sans MS")
        cbofont.Items.Add("Times New Roman")
        cbofont.SelectedIndex = 0


        Me.cbofontstyle.Items.Add("Regular")
        Me.cbofontstyle.Items.Add("Bold")
        Me.cbofontstyle.Items.Add("Italic")
        Me.cbofontstyle.Items.Add("BoldItalic")
        Me.cbofontstyle.Items.Add("Underline")
        Me.cbofontstyle.SelectedIndex = 0

        cbotextstyle.Items.Add("Normal")
        cbotextstyle.Items.Add("Outline")
        cbotextstyle.Items.Add("Filled Outline")
        cbotextstyle.Items.Add("Hash Brush")
        cbotextstyle.Items.Add("Texture Brush")
        cbotextstyle.SelectedIndex = 0


        cbohashbrushstyle.Items.Add("HatchStyleHorizontal ")
        cbohashbrushstyle.Items.Add("HatchStyleVertical ")
        cbohashbrushstyle.Items.Add("HatchStyleForwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleBackwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleCross ")
        cbohashbrushstyle.Items.Add("HatchStyleDiagonalCross ")
        cbohashbrushstyle.Items.Add("HatchStyle05Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle10Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle20Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle25Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle30Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle40Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle50Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle60Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle70Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle75Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle80Percent ")
        cbohashbrushstyle.Items.Add("HatchStyle90Percent ")
        cbohashbrushstyle.Items.Add("HatchStyleLightDownwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleLightUpwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleDarkDownwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleDarkUpwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleWideDownwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleWideUpwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleLightVertical ")
        cbohashbrushstyle.Items.Add("HatchStyleLightHorizontal ")
        cbohashbrushstyle.Items.Add("HatchStyleNarrowVertical ")
        cbohashbrushstyle.Items.Add("HatchStyleNarrowHorizontal ")
        cbohashbrushstyle.Items.Add("HatchStyleDarkVertical ")
        cbohashbrushstyle.Items.Add("HatchStyleDarkHorizontal ")
        cbohashbrushstyle.Items.Add("HatchStyleDashedDownwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleDashedUpwardDiagonal ")
        cbohashbrushstyle.Items.Add("HatchStyleDashedHorizontal ")
        cbohashbrushstyle.Items.Add("HatchStyleDashedVertical ")
        cbohashbrushstyle.Items.Add("HatchStyleSmallConfetti ")
        cbohashbrushstyle.Items.Add("HatchStyleLargeConfetti ")
        cbohashbrushstyle.Items.Add("HatchStyleZigZag ")
        cbohashbrushstyle.Items.Add("HatchStyleWave ")
        cbohashbrushstyle.Items.Add("HatchStyleDiagonalBrick ")
        cbohashbrushstyle.Items.Add("HatchStyleHorizontalBrick ")
        cbohashbrushstyle.Items.Add("HatchStyleWeave ")
        cbohashbrushstyle.Items.Add("HatchStylePlaid ")
        cbohashbrushstyle.Items.Add("HatchStyleDivot ")
        cbohashbrushstyle.Items.Add("HatchStyleDottedGrid ")
        cbohashbrushstyle.Items.Add("HatchStyleDottedDiamond ")
        cbohashbrushstyle.Items.Add("HatchStyleShingle ")
        cbohashbrushstyle.Items.Add("HatchStyleTrellis ")
        cbohashbrushstyle.Items.Add("HatchStyleSphere ")
        cbohashbrushstyle.Items.Add("HatchStyleSmallGrid ")
        cbohashbrushstyle.Items.Add("HatchStyleSmallCheckerBoard ")
        cbohashbrushstyle.Items.Add("HatchStyleLargeCheckerBoard ")
        cbohashbrushstyle.Items.Add("HatchStyleOutlinedDiamond ")
        cbohashbrushstyle.Items.Add("HatchStyleSolidDiamond ")
        cbohashbrushstyle.SelectedIndex = 0

    End Sub

    Private Sub Command4_Click(sender As Object, e As EventArgs) Handles Command4.Click
        If chkpanning.Checked Then
            AxScanner1.EnablePanning = True
        Else
            AxScanner1.EnablePanning = False

        End If

        If Check2.Checked Then
            AxScanner1.ShowTwainUI = True
        Else
            AxScanner1.ShowTwainUI = False
        End If

        If Check4.Checked Then
            AxScanner1.ClearImageBuffer = True
        Else
            AxScanner1.ClearImageBuffer = False

        End If


        If chkbufferresize.Checked Then
            AxScanner1.BufferResizeMode = True
            AxScanner1.BufferResizeMaxWidth = txtbufferresizemaxwidth.Text
            AxScanner1.BufferResizeScale = txtbufferresizescale.Text
        Else
            AxScanner1.BufferResizeMode = False
        End If


        If Option1.Checked = True Then
            AxScanner1.SelectImageSourceByIndex(cboimagesource.SelectedIndex)
        Else
            If AxScanner1.SelectImageSource() <> True Then
                Exit Sub
            End If

        End If

        If chkenablefeeder.Checked = True Then
            AxScanner1.FeederEnabled = True
        Else
            AxScanner1.FeederEnabled = False
        End If

        If chkenableduplex.Checked = True Then
            AxScanner1.DuplexEnabled = True
        Else
            AxScanner1.DuplexEnabled = False
        End If

        Select Case cbodpi.SelectedIndex
            Case 0
                AxScanner1.DPI = 96
            Case 1
                AxScanner1.DPI = 200
            Case 2
                AxScanner1.DPI = 300
            Case 3
                AxScanner1.DPI = 600

        End Select



        Select Case cbopixeltype.SelectedIndex
            Case 0
                AxScanner1.PixelType = -1
            Case 1
                AxScanner1.PixelType = 0

            Case 2
                AxScanner1.PixelType = 1

            Case 3
                AxScanner1.PixelType = 2
        End Select


        If chkdefaultcap.CheckState = 1 Then
            AxScanner1.SetCaptureArea(0, 0, 0, 0)
        Else
            AxScanner1.SetCaptureArea(CDbl(txtcapleft.Text), CDbl(txtcaptop.Text), CDbl(txtcapwidth.Text), CDbl(txtcapheight.Text))
        End If


        AxScanner1.Scan()


    End Sub

    Private Sub chkdefaultcap_CheckedChanged(sender As Object, e As EventArgs) Handles chkdefaultcap.CheckedChanged
        If chkdefaultcap.Checked Then
            txtcapleft.Enabled = False
            txtcaptop.Enabled = False
            txtcapwidth.Enabled = False
            txtcapheight.Enabled = False

        Else
            txtcapleft.Enabled = True
            txtcaptop.Enabled = True
            txtcapwidth.Enabled = True
            txtcapheight.Enabled = True
        End If

    End Sub

    Private Sub AxScanner1_EndScan(sender As Object, e As EventArgs) Handles AxScanner1.EndScan
        txt_Width.Text = CStr(Me.AxScanner1.FileWidth)
        txt_Height.Text = CStr(Me.AxScanner1.FileHeight)



        lbltotalpage.Text = CStr(Me.AxScanner1.TotalPage)
        lblcurrentpage.Text = CStr(Me.AxScanner1.GetActivePageNo)
    End Sub

    Private Sub AxScanner1_EndAllScan(sender As Object, e As EventArgs) Handles AxScanner1.EndAllScan
        If chkautosaveallpage.Checked Then
            SaveToPDF()
        End If
    End Sub

    Private Sub AxScanner1_ScanningError(sender As Object, e As EventArgs) Handles AxScanner1.ScanningError
        ListBox1.Items.Add("Error occur, may be paper jam")
    End Sub

    Private Sub SaveToPDF()

        Dim a As Integer

        Dim strFilter As String

        strFilter = "PDF File (*.pdf)|*.pdf"

        SaveFileDialog1.Filter = strFilter
        SaveFileDialog1.DefaultExt = "pdf"
        AxScanner1.View = 5
        AxScanner1.TIFCompression = cbotifcompression.SelectedIndex

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            AxScanner1.SaveAllPage2PDF(SaveFileDialog1.FileName, Check3.CheckState, 1)
        End If

    End Sub

    Private Sub Command1_Click(sender As Object, e As EventArgs) Handles Command1.Click
        Me.AxScanner1.Rotate90()
    End Sub

    Private Sub Command2_Click(sender As Object, e As EventArgs) Handles Command2.Click
        Me.AxScanner1.Rotate180()
    End Sub

    Private Sub Command3_Click(sender As Object, e As EventArgs) Handles Command3.Click
        Me.AxScanner1.Rotate270()
    End Sub

    Private Sub Command12_Click(sender As Object, e As EventArgs) Handles Command12.Click
        AxScanner1.View = 1
        AxScanner1.Focus()

    End Sub

    Private Sub Command11_Click(sender As Object, e As EventArgs) Handles Command11.Click
        AxScanner1.View = 2
        AxScanner1.Focus()
    End Sub

    Private Sub Command8_Click(sender As Object, e As EventArgs) Handles Command8.Click
        AxScanner1.View = 3
        AxScanner1.Focus()
    End Sub

    Private Sub Command9_Click(sender As Object, e As EventArgs) Handles Command9.Click
        AxScanner1.View = 4
        AxScanner1.Focus()
    End Sub

    Private Sub Command7_Click(sender As Object, e As EventArgs) Handles Command7.Click
        AxScanner1.View = 5
        AxScanner1.Focus()

    End Sub

    Private Sub Command6_Click(sender As Object, e As EventArgs) Handles Command6.Click
        AxScanner1.View = 6
        AxScanner1.Focus()
    End Sub

    Private Sub Command10_Click(sender As Object, e As EventArgs) Handles Command10.Click

        AxScanner1.View = 7
        AxScanner1.Focus()
    End Sub

    Private Sub Command5_Click(sender As Object, e As EventArgs) Handles Command5.Click

        AxScanner1.View = 9
        AxScanner1.Focus()
    End Sub

    Private Sub Command20_Click(sender As Object, e As EventArgs) Handles Command20.Click
        AxScanner1.View = 10
        AxScanner1.Focus()
    End Sub

    Private Sub txtLeft_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLeft.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        If KeyCode = 13 Then
            Me.AxScanner1.FileLeft = CInt(txtLeft.Text)
            Me.AxScanner1.FileTop = CInt(txtTop.Text)
            Me.AxScanner1.Redraw()
        End If
    End Sub

    Private Sub txtTop_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTop.KeyDown
        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000
        If KeyCode = 13 Then
            Me.AxScanner1.FileLeft = CInt(txtLeft.Text)
            Me.AxScanner1.FileTop = CInt(txtTop.Text)
            Me.AxScanner1.Redraw()
        End If
    End Sub

    Private Sub Command33_Click(sender As Object, e As EventArgs) Handles Command33.Click
        Me.AxScanner1.ApplyChange()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtconfid.Text = AxScanner1.BlankPageGetConfidence
    End Sub

    Private Sub Command31_Click(sender As Object, e As EventArgs) Handles Command31.Click
        AxScanner1.SetActivePageNo(CShort(Text2.Text))
        lblcurrentpage.Text = CStr(Me.AxScanner1.GetActivePageNo)
    End Sub

    Private Sub Command17_Click(sender As Object, e As EventArgs) Handles Command17.Click
        AxScanner1.DeletePage(AxScanner1.GetActivePageNo)


        AxScanner1.SetActivePageNo(1)
        lbltotalpage.Text = CStr(Me.AxScanner1.TotalPage)
        lblcurrentpage.Text = CStr(Me.AxScanner1.GetActivePageNo)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If AxScanner1.BlankPageIsBlank(CDbl(txtconfid.Text)) Then
            MessageBox.Show("This page is Blank page")
        Else
            MessageBox.Show("This page is not a Blank page")
        End If
    End Sub

    Private Sub Command40_Click(sender As Object, e As EventArgs) Handles Command40.Click
        Dim result As Integer
        Dim strType As String


        strType = cboutputtype.Text

        Me.SaveFileDialog1.Filter = ""

        If Me.SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Dim strTmpFile As String
            strTmpFile = SaveFileDialog1.FileName
            result = Me.AxScanner1.Save(strTmpFile, strType)

            If result = 1 Then
                MessageBox.Show("Save " + strTmpFile + "." + strType + " Complete")
            Else
                MessageBox.Show("Save fail")
            End If

        End If


        AxScanner1.Focus()



    End Sub

    Private Sub Command19_Click(sender As Object, e As EventArgs) Handles Command19.Click
        Dim result As Integer
        Dim strType As String

        strType = cboutputtype.Text


        Me.SaveFileDialog1.Filter = ""

        If Me.SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Dim strTmpFile As String
            strTmpFile = SaveFileDialog1.FileName

            result = Me.AxScanner1.SaveBySize(strTmpFile, strType, Val(txt_Width.Text), Val(txt_Height.Text))


            If result = 1 Then
                MessageBox.Show("Save " + strTmpFile + "." + strType + " Complete")
            Else
                MessageBox.Show("Save fail")
            End If


        End If

        AxScanner1.Focus()
    End Sub

    Private Sub Command24_Click(sender As Object, e As EventArgs) Handles Command24.Click
        AxScanner1.Copy2Clipboard()
    End Sub

    Private Sub Command13_Click(sender As Object, e As EventArgs) Handles Command13.Click
        If ColorDialog1.ShowDialog() Then

            Me.AxScanner1.SetBackgroundColor(Color2Uint32(ColorDialog1.Color))

        End If
    End Sub
    Public Function Color2Uint32(ByVal clr As Color) As UInt32
        Dim t As Int32
        Dim a() As Byte

        t = ColorTranslator.ToOle(clr)


        a = BitConverter.GetBytes(t)

        Return BitConverter.ToUInt32(a, 0)


    End Function

    Private Sub Command14_Click(sender As Object, e As EventArgs) Handles Command14.Click
        AxScanner1.PrintImage(True)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As Integer
        Dim strFilter As String

        strFilter = "Docx File (*.docx)|*.docx"

        SaveFileDialog1.Filter = strFilter
        SaveFileDialog1.DefaultExt = "docx"
        AxScanner1.View = 5

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

            AxScanner1.SaveAllPage2Docx(SaveFileDialog1.FileName, Check3.CheckState, 1)

        End If
    End Sub

    Private Sub Command15_Click(sender As Object, e As EventArgs) Handles Command15.Click
        Dim a As Integer

        Dim strFilter As String

        strFilter = "TIFF File (*.tif)|*.tif"

        SaveFileDialog1.Filter = strFilter
        SaveFileDialog1.DefaultExt = "tif"
        AxScanner1.View = 5
        AxScanner1.TIFCompression = cbotifcompression.SelectedIndex

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            AxScanner1.SaveAllPage2TIF(SaveFileDialog1.FileName, Check3.CheckState, 1)
        End If

    End Sub

    Private Sub Command16_Click(sender As Object, e As EventArgs) Handles Command16.Click
        SaveToPDF()
    End Sub

    Private Sub optborderoff_Click(sender As Object, e As EventArgs) Handles optborderoff.Click
        If Me.optborderon.Checked = True Then
            AxScanner1.Border = True
        Else
            AxScanner1.Border = False
        End If
    End Sub

    Private Sub optborderon_Click(sender As Object, e As EventArgs) Handles optborderon.Click
        If Me.optborderon.Checked = True Then
            AxScanner1.Border = True
        Else
            AxScanner1.Border = False
        End If
    End Sub

    Private Sub opthighno_Click(sender As Object, e As EventArgs) Handles opthighno.Click
        If Me.opthighyes.Checked = True Then
            AxScanner1.HighQuality = True
        Else
            AxScanner1.HighQuality = False
        End If
    End Sub

    Private Sub opthighyes_Click(sender As Object, e As EventArgs) Handles opthighyes.Click
        If Me.opthighyes.Checked = True Then
            AxScanner1.HighQuality = True
        Else
            AxScanner1.HighQuality = False
        End If
    End Sub

    Private Sub Command39_Click(sender As Object, e As EventArgs) Handles Command39.Click
        AxScanner1.DrawText(CShort(txtTextLeft.Text), CShort(txtTextTop.Text), txttext1.Text & Chr(13) & Chr(10) & txttext2.Text)
    End Sub

    Private Sub cmdtextcolor_Click(sender As Object, e As EventArgs) Handles cmdtextcolor.Click
        If ColorDialog1.ShowDialog() Then
            Me.AxScanner1.TextColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub cmdoutlineborder_Click(sender As Object, e As EventArgs) Handles cmdoutlineborder.Click
        If ColorDialog1.ShowDialog() Then
            AxScanner1.SetOutlineTextBorderColor(Color2Uint32(ColorDialog1.Color))
        End If
    End Sub

    Private Sub cmdoutlineback_Click(sender As Object, e As EventArgs) Handles cmdoutlineback.Click
        If ColorDialog1.ShowDialog() Then
            AxScanner1.SetOutlineTextBackColor(Color2Uint32(ColorDialog1.Color))
        End If
    End Sub

    Private Sub cmdhashforecolor_Click(sender As Object, e As EventArgs) Handles cmdhashforecolor.Click
        If ColorDialog1.ShowDialog() Then
            clrHashForeColor = ColorDialog1.Color
            AxScanner1.SetHashBrushValue(cbohashbrushstyle.SelectedIndex, clrHashForeColor, clrHashBackColor)
        End If
    End Sub

    Private Sub cmdhashbackcolor_Click(sender As Object, e As EventArgs) Handles cmdhashbackcolor.Click
        If ColorDialog1.ShowDialog() Then
            clrHashBackColor = ColorDialog1.Color
            AxScanner1.SetHashBrushValue(cbohashbrushstyle.SelectedIndex, clrHashForeColor, clrHashBackColor)
        End If
    End Sub

    Private Sub cmdtextureimage_Click(sender As Object, e As EventArgs) Handles cmdtextureimage.Click

        OpenFileDialog1.Filter = "All Files (*.*)|*.*|JPEG (*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|Gif (*.gif)|*.gif |PNG (*.png)|*.png|Icon (*.ico)|*.ico"
        If OpenFileDialog1.ShowDialog() Then
            txttextureimage.Text = OpenFileDialog1.FileName
            Me.AxScanner1.SetTextureBrushImage(txttextureimage.Text)
        End If
    End Sub

    Private Sub Command37_Click(sender As Object, e As EventArgs) Handles Command37.Click
        Me.AxScanner1.Brightness = CDbl(txtBrightness.Text)
    End Sub

    Private Sub Command36_Click(sender As Object, e As EventArgs) Handles Command36.Click
        Me.AxScanner1.Contrast = CDbl(txtcontrast.Text)
    End Sub

    Private Sub Command38_Click(sender As Object, e As EventArgs) Handles Command38.Click
        Me.AxScanner1.Saturation = CDbl(txtSat.Text)
    End Sub

    Private Sub Command35_Click(sender As Object, e As EventArgs) Handles Command35.Click
        Me.AxScanner1.Hue = CDbl(txthue.Text)
    End Sub

    Private Sub Command34_Click(sender As Object, e As EventArgs) Handles Command34.Click
        Me.AxScanner1.Gamma = CDbl(txtgamma.Text)
    End Sub

    Private Sub chkpanning_CheckedChanged(sender As Object, e As EventArgs) Handles chkpanning.CheckedChanged
        If AxScanner1.IsHandleCreated Then
            If chkpanning.Checked Then
                AxScanner1.EnablePanning = True
            Else
                AxScanner1.EnablePanning = False

            End If
        End If
    End Sub
End Class

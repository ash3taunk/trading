Imports System.Drawing

Public Class ColoredTextBoxColumn
    Inherits DataGridTextBoxColumn

    Protected Overloads Overrides Sub Paint(ByVal graph As Graphics, _
         ByVal rectbounds As Rectangle, ByVal curmngrSrc As _
         CurrencyManager, ByVal RowNumber As Integer, ByVal _
         ForeColorBrush As Brush, ByVal BackColorBrush As Brush, _
         ByVal AlignmentRight As Boolean)

        Dim ObjVal As Object
        ObjVal = Me.GetColumnValueAtRow(curmngrSrc, RowNumber)

        If Not (IsNothing(ObjVal) Or IsDBNull(ObjVal)) Then
            Dim cellValue As Double
            cellValue = CType(ObjVal, Double)
            If (cellValue > 1) Then
                ' Here is where we are going to do 
                ' the actual painting.
                ' Color the contents of the cell Green
                ' and the background of the cell Yellow.
                BackColorBrush = Brushes.Yellow
                ForeColorBrush = Brushes.Green
            Else
                BackColorBrush = Brushes.White
                ForeColorBrush = Brushes.Black
            End If
        End If

        ' Call Paint from the base class to 
        ' accomplish the actual drawing.
        MyBase.Paint(graph, rectbounds, curmngrSrc, RowNumber, _
            BackColorBrush, ForeColorBrush, AlignmentRight)
    End Sub
End Class

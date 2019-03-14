Imports GBM.My.Resources

Public Class mgrThemeEngine

    Public ReadOnly Property colBase As Color
    Public ReadOnly Property colBaseAlt As Color
    Public ReadOnly Property colHightlight As Color
    Public ReadOnly Property colHighlightAlt As Color


    Public Enum eTheme
        Dark
    End Enum

    Public Function SetTheme(thm As eTheme)
        Dim selectedColor As Color
        Select Case thm
            Case eTheme.Dark
                _colBase = New ColorConverter().ConvertFromString(mgrThemeEngine_Color_Dark)
                _colBaseAlt = New ColorConverter().ConvertFromString(mgrThemeEngine_Color_Black)
                _colHightlight = New ColorConverter().ConvertFromString(mgrThemeEngine_Color_White)
                _colHighlightAlt = New ColorConverter().ConvertFromString(mgrThemeEngine_Color_Blue)
        End Select
        Return selectedColor
    End Function
End Class

Imports GBM.My.Resources

Public Class mgrThemeEngine

    Public ReadOnly Property ColorBase As Color
    Public ReadOnly Property ColorBaseSecondary As Color
    Public ReadOnly Property ColorHighlight As Color
    Public ReadOnly Property ColorHighlightSecondary As Color


    ''' <summary>
    ''' Supported themes.
    ''' </summary>
    Public Enum eBaseTheme
        Light = 0
        Dark = 1
    End Enum

    ''' <summary>
    ''' Configures the base colors for the overall theme based on input.
    ''' </summary>
    ''' <param name="_eBaseTheme"></param>
    ''' <returns></returns>
    Public Function SetTheme(_eBaseTheme As eBaseTheme)
        Dim selectedColor As Color
        Select Case _eBaseTheme
            Case eBaseTheme.Dark
                _ColorBase = New ColorConverter().ConvertFromString(
                    mgrThemeEngine_RGB_Dark_Base)

                _ColorBaseSecondary = New ColorConverter().ConvertFromString(
                    mgrThemeEngine_RGB_Dark_BaseSecondary)

                _ColorHighlight = New ColorConverter().ConvertFromString(
                    mgrThemeEngine_RGB_Dark_Highlight)

                _ColorHighlightSecondary = New ColorConverter().ConvertFromString(
                    mgrThemeEngine_RGB_Dark_HighlightSecondary)

            Case eBaseTheme.Light
                _ColorBase = New ColorConverter().ConvertFromString(
                    mgrThemeEngine_RGB_Light_Base)

                _ColorBaseSecondary = New ColorConverter().ConvertFromString(
                    mgrThemeEngine_RGB_Light_BaseSecondary)

                _ColorHighlight = New ColorConverter().ConvertFromString(
                    mgrThemeEngine_RGB_Light_Highlight)

                _ColorHighlightSecondary = New ColorConverter().ConvertFromString(
                    mgrThemeEngine_RGB_Light_HighlightSecondary)

        End Select
        Return selectedColor
    End Function
End Class

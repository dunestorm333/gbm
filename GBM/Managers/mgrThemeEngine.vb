Imports GBM.My.Resources

Public Class mgrThemeEngine

    Public ReadOnly Property colBase As Color
    Public ReadOnly Property colBaseAlt As Color
    Public ReadOnly Property colHightlight As Color
    Public ReadOnly Property colHighlightAlt As Color


    ''' <summary>
    ''' Supported themes.
    ''' </summary>
    Public Enum eBaseTheme
        Dark
        Light
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
                _colBase = New ColorConverter().ConvertFromString(
                    mgrThemeEngine_Theme_Dark_Base)

                _colBaseAlt = New ColorConverter().ConvertFromString(
                    mgrThemeEngine_Theme_Dark_BaseAlt)

                _colHightlight = New ColorConverter().ConvertFromString(
                    mgrThemeEngine_Theme_Dark_Highlight)

                _colHighlightAlt = New ColorConverter().ConvertFromString(
                    mgrThemeEngine_Theme_Dark_HighlightAlt)

            Case eBaseTheme.Light
                _colBase = New ColorConverter().ConvertFromString(
                    mgrThemeEngine_Theme_Light_Base)

                _colBaseAlt = New ColorConverter().ConvertFromString(
                    mgrThemeEngine_Theme_Light_BaseAlt)

                _colHightlight = New ColorConverter().ConvertFromString(
                    mgrThemeEngine_Theme_Light_Highlight)

                _colHighlightAlt = New ColorConverter().ConvertFromString(
                    mgrThemeEngine_Theme_Light_HighlightAlt)

        End Select
        Return selectedColor
    End Function
End Class

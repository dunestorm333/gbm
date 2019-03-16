Imports GBM.My.Resources

Public Class mgrThemeEngine

    Private _ColorBase As Color
    Public Property ColorBase() As Color
        Get
            If _ColorBase = Nothing Then
                Throw New NullReferenceException
            End If
            Return _ColorBase
        End Get
        Private Set(ByVal value As Color)
            _ColorBase = value
        End Set
    End Property

    Private _ColorBaseSecondary As Color
    Public Property ColorBaseSecondary() As Color
        Get
            If _ColorBaseSecondary = Nothing Then
                Throw New NullReferenceException
            End If
            Return _ColorBaseSecondary
        End Get
        Private Set(ByVal value As Color)
            _ColorBaseSecondary = value
        End Set
    End Property

    Private _ColorHighlight As Color
    Public Property ColorHighlight() As Color
        Get
            If _ColorHighlight = Nothing Then
                Throw New NullReferenceException
            End If
            Return _ColorHighlight
        End Get
        Private Set(ByVal value As Color)
            _ColorHighlight = value
        End Set
    End Property

    Private _ColorHighlightSecondary As Color
    Public Property ColorHighlightSecondary() As Color
        Get
            If _ColorHighlightSecondary = Nothing Then
                Throw New NullReferenceException
            End If
            Return _ColorHighlightSecondary
        End Get
        Private Set(ByVal value As Color)
            _ColorHighlightSecondary = value
        End Set
    End Property

    Private _bThemeHasBeenDefined As Boolean
    Public Property bThemeHasBeenDefined() As Boolean
        Get
            Return _bThemeHasBeenDefined
        End Get
        Private Set(ByVal value As Boolean)
            _bThemeHasBeenDefined = value
        End Set
    End Property

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
    Public Sub SetTheme(_eBaseTheme As eBaseTheme)
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

                _bThemeHasBeenDefined = True

            Case eBaseTheme.Light
                _ColorBase = New ColorConverter().ConvertFromString(
                    mgrThemeEngine_RGB_Light_Base)

                _ColorBaseSecondary = New ColorConverter().ConvertFromString(
                    mgrThemeEngine_RGB_Light_BaseSecondary)

                _ColorHighlight = New ColorConverter().ConvertFromString(
                    mgrThemeEngine_RGB_Light_Highlight)

                _ColorHighlightSecondary = New ColorConverter().ConvertFromString(
                    mgrThemeEngine_RGB_Light_HighlightSecondary)

                _bThemeHasBeenDefined = True
        End Select
    End Sub
End Class

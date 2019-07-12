Public Module Valids

    Public Function ValidHatColorsByStyle(style As Hats.Style, color As Hats.Color) As Boolean

        Select Case style
            Case Hats.Style.BaseballCap
                Select Case color
                    Case Hats.Color.Black
                        Return False
                    Case Hats.Color.Pink
                        Return False
                End Select
            Case Hats.Style.Beenie
                Select Case color
                    Case Hats.Color.White
                        Return False
                    Case Hats.Color.Gray
                        Return False
                End Select
            Case Hats.Style.CowboyHat
                Select Case color
                    Case Hats.Color.Red, Hats.Color.Blue, Hats.Color.Yellow
                        Return False
                    Case Hats.Color.Pink, Hats.Color.Green, Hats.Color.Orange
                        Return False
                    Case Hats.Color.Purple
                        Return False
                End Select
        End Select

        Return True

    End Function

    Public Function ValidTopCatByType(cat As Tops.Category, type As Tops.Type) As Boolean
        Select Case cat
            Case Tops.Category.Tees
                If type = Tops.Type.Toddlers Then Return False
            Case Tops.Category.Hoodies
                If type = Tops.Type.Toddlers Then Return False
            Case Tops.Category.Sweatshirts
                If type = Tops.Type.Toddlers Then Return False
            Case Tops.Category.Tanks
                If Not type = (Tops.Type.Boys OrElse Tops.Type.Girls) Then Return False
            Case Tops.Category.Polos
                If type = Tops.Type.Womens Then Return False
                If type = Tops.Type.Toddlers Then Return False
                If type = Tops.Type.Girls Then Return False
            Case Tops.Category.Onesies
                If Not type = Tops.Type.Toddlers Then Return False
        End Select

        Return True

    End Function

    Public Function ValidTopSizeByType(size As Tops.Size, type As Tops.Type) As Boolean
        Select Case size
            Case Tops.Size.XXXL, Tops.Size.XXL
                If Not type = Tops.Type.Mens Then Return False
           Case Tops.Size.XL, Tops.Size.L, Tops.Size.M, Tops.Size.S
                If Not (type = Tops.Type.Mens Or type = Tops.Type.Womens) Then Return False
            Case Tops.Size.XS
                If Not type = Tops.Type.Womens Then Return False
            Case Tops.Size.y13, Tops.Size.y15, Tops.Size.y3, Tops.Size.y5, Tops.Size.y7, _
                 Tops.Size.y9
                If Not (type = Tops.Type.Boys Or type = Tops.Type.Girls) Then Return False
            Case Tops.Size.t18mos, Tops.Size.t12mos, Tops.Size.t9mos, Tops.Size.t6mos
                If Not type = Tops.Type.Toddlers Then Return False
        End Select

        Return True

    End Function

    Public Function ValidTopColorBySizeTypeAndCat(color As Tops.Color, size As Tops.Size, type As Tops.Type, cat As Tops.Category) As Boolean
         If Not (color = Tops.Color.Pink Or color = Tops.Color.Blue)
            If type = Tops.Type.Toddlers
                Return False
            End If
         End If

        If color = Tops.Color.Black
            If type = Tops.Type.Boys
                If size = Tops.Size.y15 Or size = Tops.Size.y13
                    Return False
                End If
            End If
        End If
        Return True

    End Function

End Module

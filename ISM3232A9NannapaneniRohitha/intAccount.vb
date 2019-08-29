Imports ISM3232A9NannapaneniRohitha

Public Interface intAccount
    Property AccountName As String
    Property DebitBalance As Single
    Property CreditBalance As Single
    Property NetBalance As Single
    Sub ComputeBalance()
End Interface

Class IAssetAccount
    Implements intAccount
    Dim mName As String
    Dim mDebit, mCredit, mNetB As Single

    Public Property AccountName As String Implements intAccount.AccountName
        Get
            Return mName
        End Get
        Set(value As String)
            mName = value
        End Set
    End Property

    Public Property DebitBalance As Single Implements intAccount.DebitBalance
        Get
            Return mDebit
        End Get
        Set(value As Single)
            mDebit = value
        End Set
    End Property

    Public Property CreditBalance As Single Implements intAccount.CreditBalance
        Get
            Return mCredit
        End Get
        Set(value As Single)
            mCredit = value
        End Set
    End Property

    Public Property NetBalance As Single Implements intAccount.NetBalance
        Get
            Return mNetB
        End Get
        Set(value As Single)
            mNetB = value
        End Set
    End Property

    Public Sub ComputeBalance() Implements intAccount.ComputeBalance
        NetBalance = DebitBalance - CreditBalance
    End Sub

End Class

Class ILiabilityAccount
    Implements intAccount
    Dim mName As String
    Dim mDebit, mCredit, mNetB As Single

    Public Property AccountName As String Implements intAccount.AccountName
        Get
            Return mName
        End Get
        Set(value As String)
            mName = value
        End Set
    End Property

    Public Property DebitBalance As Single Implements intAccount.DebitBalance
        Get
            Return mDebit
        End Get
        Set(value As Single)
            mDebit = value
        End Set
    End Property

    Public Property CreditBalance As Single Implements intAccount.CreditBalance
        Get
            Return mCredit
        End Get
        Set(value As Single)
            mCredit = value
        End Set
    End Property

    Public Property NetBalance As Single Implements intAccount.NetBalance
        Get
            Return mNetB
        End Get
        Set(value As Single)
            mNetB = value
        End Set
    End Property

    Public Sub ComputeBalance() Implements intAccount.ComputeBalance
        NetBalance = CreditBalance - DebitBalance
    End Sub

End Class

Class IEquityAccount
    Implements intAccount
    Dim mName As String
    Dim mDebit, mCredit, mNetB As Single

    Public Property AccountName As String Implements intAccount.AccountName
        Get
            Return mName
        End Get
        Set(value As String)
            mName = value
        End Set
    End Property

    Public Property DebitBalance As Single Implements intAccount.DebitBalance
        Get
            Return mDebit
        End Get
        Set(value As Single)
            mDebit = value
        End Set
    End Property

    Public Property CreditBalance As Single Implements intAccount.CreditBalance
        Get
            Return mCredit
        End Get
        Set(value As Single)
            mCredit = value
        End Set
    End Property

    Public Property NetBalance As Single Implements intAccount.NetBalance
        Get
            Return mNetB
        End Get
        Set(value As Single)
            mNetB = value
        End Set
    End Property

    Public Sub ComputeBalance() Implements intAccount.ComputeBalance
        NetBalance = CreditBalance - DebitBalance
    End Sub

End Class

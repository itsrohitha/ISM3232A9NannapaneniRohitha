Public MustInherit Class clsAccount
    Dim mAccountName As String
    Dim mDebit As Single
    Dim mCredit As Single
    Dim mNet As Single

    Property AccountName As String
        Get
            Return mAccountName
        End Get
        Set(value As String)
            mAccountName = value
        End Set
    End Property

    Property DebitBalance As Single
        Get
            Return mDebit
        End Get
        Set(value As Single)
            mDebit = value
        End Set
    End Property

    Property CreditBalance As Single
        Get
            Return mCredit
        End Get
        Set(value As Single)
            mCredit = value
        End Set
    End Property

    Property NetBalance As String
        Get
            Return mNet
        End Get
        Set(value As String)
            mNet = value
        End Set
    End Property

    Overridable Sub ComputeBalance()
        mNet = DebitBalance - CreditBalance
    End Sub
End Class

Class clsAssetAccount
    Inherits clsAccount
End Class

Class clsLiabilityAccount
    Inherits clsAccount
    Public Overrides Sub ComputeBalance()
        NetBalance = CreditBalance - DebitBalance
    End Sub
End Class

Class clsEquityAccount
    Inherits clsAccount
    Public Overrides Sub ComputeBalance()
        NetBalance = CreditBalance - DebitBalance
    End Sub
End Class
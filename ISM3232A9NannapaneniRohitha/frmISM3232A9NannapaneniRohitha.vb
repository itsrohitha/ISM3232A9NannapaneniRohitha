Public Class frmISM3232A9NannapaneniRohitha
    Private Sub btnInheritance_Click(sender As Object, e As EventArgs) Handles btnInheritance.Click
        FileOpen(1, "AccountBalancesUsingInheritance.txt", OpenMode.Output)
        Dim Cash As New clsAssetAccount
        Cash.AccountName = "Cash"
        Cash.DebitBalance = 10000
        Cash.CreditBalance = 4000
        Cash.ComputeBalance()
        Print(1, Cash.AccountName & "," & Cash.NetBalance & vbCrLf)

        Dim AR As New clsAssetAccount
        AR.AccountName = "AccountsReceivable"
        AR.DebitBalance = 5000
        AR.CreditBalance = 2000
        AR.ComputeBalance()
        Print(1, AR.AccountName & "," & AR.NetBalance & vbCrLf)

        Dim AP As New clsLiabilityAccount
        AP.AccountName = "AccountsPayable"
        AP.DebitBalance = 6000
        AP.CreditBalance = 8000
        AP.ComputeBalance()
        Print(1, AP.AccountName & "," & AP.NetBalance & vbCrLf)

        Dim RE As New clsEquityAccount
        RE.AccountName = "RetainedEarnings"
        RE.DebitBalance = 7000
        RE.CreditBalance = 14000
        RE.ComputeBalance()
        Print(1, RE.AccountName & "," & RE.NetBalance & vbCrLf)

        FileClose(1)
        MsgBox("Done")
    End Sub

    Private Sub btnPolymorphism_Click(sender As Object, e As EventArgs) Handles btnPolymorphism.Click
        FileOpen(2, "AccountBalancesUsingPolymorphism.txt", OpenMode.Output)

        Dim Account As intAccount
        Account = New IAssetAccount
        Account.AccountName = "Cash"
        Account.DebitBalance = 10000
        Account.CreditBalance = 4000
        Account.ComputeBalance()
        Print(2, Account.AccountName & "," & Account.NetBalance & vbCrLf)

        Account = New IAssetAccount
        Account.AccountName = "AccountsReceivable"
        Account.DebitBalance = 5000
        Account.CreditBalance = 2000
        Account.ComputeBalance()
        Print(2, Account.AccountName & "," & Account.NetBalance & vbCrLf)

        Account = New ILiabilityAccount
        Account.AccountName = "AccountsPayable"
        Account.DebitBalance = 6000
        Account.CreditBalance = 8000
        Account.ComputeBalance()
        Print(2, Account.AccountName & "," & Account.NetBalance & vbCrLf)

        Account = New IEquityAccount
        Account.AccountName = "ReturnedEarnings"
        Account.DebitBalance = 7000
        Account.CreditBalance = 14000
        Account.ComputeBalance()
        Print(2, Account.AccountName & "," & Account.NetBalance & vbCrLf)

        FileClose(2)
        MsgBox("Done")

    End Sub
End Class

Imports System.Net.Http.HttpClient
Imports System.Net.Http
Imports RestSharp

Module Module1

    Sub Main()
        Console.WriteLine("WebJob started!!!")
        Dim _client As New RestSharp.RestClient("http://kynetapp.azurewebsites.net/")
        Dim startAsyncRequest = New RestSharp.RestRequest("api/RatesKeeper/ExtractPricesFromExchanges/", Method.GET)
        Dim startResponce = _client.Execute(startAsyncRequest)
        Console.WriteLine("WebJob completed!!!")
    End Sub

End Module

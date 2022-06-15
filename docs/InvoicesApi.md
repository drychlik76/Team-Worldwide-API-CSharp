# TeamWorldwideAPI.InvoicesApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetGetInvoiceItem**](InvoicesApi.md#getgetinvoiceitem) | **GET** /api/teamww/invoice/get/{houseBill} | Get invoice by house bill

<a name="getgetinvoiceitem"></a>
# **GetGetInvoiceItem**
> GetInvoiceInvoiceJsonldInvoiceItemGetRead GetGetInvoiceItem (string houseBill)

Get invoice by house bill

Retrieves a GetInvoice resource.

### Example
```csharp
using System;
using System.Diagnostics;
using TeamWorldwideAPI;
using IO.Swagger.Client;
using TeamWorldwideModel;

namespace Example
{
    public class GetGetInvoiceItemExample
    {
        public void main()
        {

            var apiInstance = new InvoicesApi();
            var houseBill = houseBill_example;  // string | Resource identifier

            try
            {
                // Get invoice by house bill
                GetInvoiceInvoiceJsonldInvoiceItemGetRead result = apiInstance.GetGetInvoiceItem(houseBill);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetGetInvoiceItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **houseBill** | **string**| Resource identifier | 

### Return type

[**GetInvoiceInvoiceJsonldInvoiceItemGetRead**](GetInvoiceInvoiceJsonldInvoiceItemGetRead.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


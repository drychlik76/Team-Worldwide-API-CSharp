# TeamWorldwideAPI.AuthenticateApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostCredentialsItem**](AuthenticateApi.md#postcredentialsitem) | **POST** /api/authenticate | Authenticate to start session.

<a name="postcredentialsitem"></a>
# **PostCredentialsItem**
> void PostCredentialsItem (Credentials body)

Authenticate to start session.

### Example
```csharp
using System;
using System.Diagnostics;
using TeamWorldwideAPI;
using IO.Swagger.Client;
using TeamWorldwideModel;

namespace Example
{
    public class PostCredentialsItemExample
    {
        public void main()
        {

            var apiInstance = new AuthenticateApi();
            var body = new Credentials(); // Credentials | Start Session (optional) 

            try
            {
                // Authenticate to start session.
                apiInstance.PostCredentialsItem(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticateApi.PostCredentialsItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Credentials**](Credentials.md)| Start Session | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


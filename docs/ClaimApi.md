# TeamWorldwideAPI.ClaimApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetClaimCollection**](ClaimApi.md#getclaimcollection) | **GET** /api/teamww/get-claim | Gets collection of Team WorldWide Claims
[**GetClaimItem**](ClaimApi.md#getclaimitem) | **GET** /api/teamww/get-single-claim/{id} | Gets a single Team WorldWide Claim
[**PostClaimCollection**](ClaimApi.md#postclaimcollection) | **POST** /api/teamww/post-claim | File a single Team WorldWide Claim
[**UpdateClaimItem**](ClaimApi.md#updateclaimitem) | **PATCH** /api/teamww/update-claim/{id} | Update an existing Team WorldWide Claim

<a name="getclaimcollection"></a>
# **GetClaimCollection**
> InlineResponse2002 GetClaimCollection (int? page)

Gets collection of Team WorldWide Claims

Retrieves the collection of Claim resources.

### Example
```csharp
using System;
using System.Diagnostics;
using TeamWorldwideAPI;
using IO.Swagger.Client;
using TeamWorldwideModel;

namespace Example
{
    public class GetClaimCollectionExample
    {
        public void main()
        {

            var apiInstance = new ClaimApi();
            var page = 56;  // int? | The collection page number (optional)  (default to 1)

            try
            {
                // Gets collection of Team WorldWide Claims
                InlineResponse2002 result = apiInstance.GetClaimCollection(page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClaimApi.GetClaimCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The collection page number | [optional] [default to 1]

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclaimitem"></a>
# **GetClaimItem**
> ClaimClaimsResponseJsonldClaimCollectionReadRead GetClaimItem (string id)

Gets a single Team WorldWide Claim

Retrieves a Claim resource.

### Example
```csharp
using System;
using System.Diagnostics;
using TeamWorldwideAPI;
using IO.Swagger.Client;
using TeamWorldwideModel;

namespace Example
{
    public class GetClaimItemExample
    {
        public void main()
        {

            var apiInstance = new ClaimApi();
            var id = id_example;  // string | Resource identifier

            try
            {
                // Gets a single Team WorldWide Claim
                ClaimClaimsResponseJsonldClaimCollectionReadRead result = apiInstance.GetClaimItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClaimApi.GetClaimItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Resource identifier | 

### Return type

[**ClaimClaimsResponseJsonldClaimCollectionReadRead**](ClaimClaimsResponseJsonldClaimCollectionReadRead.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postclaimcollection"></a>
# **PostClaimCollection**
> ClaimClaimsResponseJsonldClaimCollectionReadRead PostClaimCollection (ClaimJsonldClaimCollectionWriteWrite body)

File a single Team WorldWide Claim

Creates a Claim resource.

### Example
```csharp
using System;
using System.Diagnostics;
using TeamWorldwideAPI;
using IO.Swagger.Client;
using TeamWorldwideModel;

namespace Example
{
    public class PostClaimCollectionExample
    {
        public void main()
        {

            var apiInstance = new ClaimApi();
            var body = new ClaimJsonldClaimCollectionWriteWrite(); // ClaimJsonldClaimCollectionWriteWrite | The new Claim resource

            try
            {
                // File a single Team WorldWide Claim
                ClaimClaimsResponseJsonldClaimCollectionReadRead result = apiInstance.PostClaimCollection(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClaimApi.PostClaimCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ClaimJsonldClaimCollectionWriteWrite**](ClaimJsonldClaimCollectionWriteWrite.md)| The new Claim resource | 

### Return type

[**ClaimClaimsResponseJsonldClaimCollectionReadRead**](ClaimClaimsResponseJsonldClaimCollectionReadRead.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/ld+json, application/json, text/html
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateclaimitem"></a>
# **UpdateClaimItem**
> ClaimClaimsResponseJsonldClaimCollectionReadRead UpdateClaimItem (ClaimClaimCollectionWriteWrite body, string id)

Update an existing Team WorldWide Claim

Updates the Claim resource.

### Example
```csharp
using System;
using System.Diagnostics;
using TeamWorldwideAPI;
using IO.Swagger.Client;
using TeamWorldwideModel;

namespace Example
{
    public class UpdateClaimItemExample
    {
        public void main()
        {

            var apiInstance = new ClaimApi();
            var body = new ClaimClaimCollectionWriteWrite(); // ClaimClaimCollectionWriteWrite | The updated Claim resource
            var id = id_example;  // string | Resource identifier

            try
            {
                // Update an existing Team WorldWide Claim
                ClaimClaimsResponseJsonldClaimCollectionReadRead result = apiInstance.UpdateClaimItem(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClaimApi.UpdateClaimItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ClaimClaimCollectionWriteWrite**](ClaimClaimCollectionWriteWrite.md)| The updated Claim resource | 
 **id** | **string**| Resource identifier | 

### Return type

[**ClaimClaimsResponseJsonldClaimCollectionReadRead**](ClaimClaimsResponseJsonldClaimCollectionReadRead.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/merge-patch+json
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


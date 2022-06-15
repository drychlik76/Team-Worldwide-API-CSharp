using IO.Swagger.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamWorldwideAPI;
using TeamWorldwideModel;

namespace TeamWorldwideAPIClientLib
{
    public class Class1
    {
        Credentials credentials = new Credentials
        {
            Username = "daniel",
            Password = "password"
        };


        ApiClient apiClient = new ApiClient();
        

        AuthenticateApi authenticateApi = new AuthenticateApi();
        

    }
}

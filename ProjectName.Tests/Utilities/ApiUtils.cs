using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Project.ProjectName.Tests.Utilities
{
    class ApiUtils
    {
        public static RestRequest BasicAuthenticate(
            String userName,
            String password,
            RestRequest request
        )
        {
            string base64EncodedCredentials = Convert.ToBase64String(
                Encoding.UTF8.GetBytes($"{userName}:{password}")
            );

            request.AddParameter(
                "Authorization",
                $"Basic {base64EncodedCredentials}",
                ParameterType.HttpHeader
            );

            return request;
        }

        public static RestRequest Accept(RestRequest request, String acceptedFormat)
        {
            switch (acceptedFormat)
            {
                case "json":
                default:
                    return request.AddHeader("Accept", "application/json");
                case "xml":
                    return request.AddHeader("Accept", "application/xml");
                case "text":
                    return request.AddHeader("Accept", "text/plain");
                case "html":
                    return request.AddHeader("Accept", "text/html");
                case "csv":
                    return request.AddHeader("Accept", "text/csv");
                case "js":
                    return request.AddHeader("Accept", "application/javascript");
                case "pdf":
                    return request.AddHeader("Accept", "application/pdf");
                case "stream":
                    return request.AddHeader("Accept", "application/octet-stream");
            }
        }
    }
}

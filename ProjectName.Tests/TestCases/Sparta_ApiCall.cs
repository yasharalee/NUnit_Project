using NUnit.Framework;
using NUnit_Project.ProjectBusinessLayer.DataAccess;
using NUnit_Project.ProjectName.Tests.Utilities;
using RestSharp;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace NUnit_Project.ProjectName.Tests.TestCases
{
    [TestFixture]
    class Sparta_ApiCall : BaseApiClass
    {
        [Test]
        public void getAll()
        {
            RestRequest request = new RestRequest(Spa_Api.See_all);
            //request.AddHeader("Content-Type", ContentType.Json.ToString()); // does provide Enum
            request.AddHeader("Accept", "application/json"); // does not provide Enum

            request = ApiUtils.BasicAuthenticate("admin", "admin", request);

            RestResponse response = _client.Execute(request);

            Assert.That(response.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.OK));
            Assert.That(response.Content.Length, Is.Not.EqualTo(0));

            Console.WriteLine("This is length : " + response.Content.Length);

            Console.WriteLine(response.Content);
        }

        [Test]
        public void SearchForOne()
        {
            RestRequest request = new RestRequest(Spa_Api.Search);
            request = ApiUtils.Accept(request, "json");

            request = ApiUtils.BasicAuthenticate("admin", "admin", request);

            request.AddParameter("gender", "Female");
            request.AddParameter("nameContains", "a");

            RestResponse response = _client.Execute(request);

            Console.WriteLine(response.Content);

            Assert.That(response.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.OK));
        }
    }
}

//-----------------------------------------

//string logFilePath = "C:/Users/yasha/source/repos/NUnit_Project/logs.txt";

//// Write the output to the log file
//using (StreamWriter writer = new StreamWriter(logFilePath, true))
//{
//    writer.WriteLine("This is the output: " + response.Content);
//}

//// Write the output to the Debug output
//Debug.WriteLine("This is the output: " + response.Content);



//=========================================

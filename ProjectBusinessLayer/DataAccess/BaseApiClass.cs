using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Project.ProjectBusinessLayer.DataAccess
{
    class BaseApiClass
    {
        protected RestClient _client;

        [OneTimeSetUp]
        public void Setup()
        {
            _client = new RestClient(Qa_1_Env.Ec2_Base + Spa_Api.Spartan_PortNum);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            _client.Dispose();
        }
    }
}

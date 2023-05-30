using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Project.ProjectBusinessLayer.DataAccess
{
    class Qa_1_Env
    {

       private const String BASE_URL = "https://google.com";
        private const String BROWSER = "Chrome";

        private const String EC2_BASE = "http://54.237.233.250";


        public static string BaseUrl => BASE_URL;

        public static string Browser => BROWSER;

        public static string Ec2_Base => EC2_BASE;

    }
}

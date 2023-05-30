using System;

namespace NUnit_Project.ProjectBusinessLayer.DataAccess
{
    class Spa_Api
    {
        private const String SPARTAN_API_PORT = ":7000";

        private const String See_All = "/api/spartans";
        private const String Add_New = "/api/spartans";
        private const String Display_One = "/api/spartans/{id}";
        private const String Update_One = "/api/spartans/{id}";
        private const String Delete_One = "/api/spartans/{id}";
        private const String Patch_One = "/api/spartans/{id}";
        private const String Search_One = "/api/spartans/search";

        public static string See_all => See_All;
        public static string Spartan_PortNum => SPARTAN_API_PORT;
        public static string Add_new => Add_New;
        public static string Display_one => Display_One;
        public static string Update_one => Update_One;
        public static string Delete_one => Delete_One;
        public static string Patch_one => Patch_One;
        public static string Search => Search_One;

        public static string Spartan => SPARTAN_API_PORT;
    }
}

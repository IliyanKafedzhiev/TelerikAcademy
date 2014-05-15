using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringSimpleWrongWritenClasses
{
    private class Database  
    {
        public  void NotifyCreation (bool isCreated)   
        {
            string isCreatedInString = isCreated.ToString();
            Console.WriteLine(isCreatedInString); 
        }
    }   

    class WebServer
    {
        private const int MAX_USERS_ONLINE=6;

        public static void StartDatabase()
        {
            WebServer.Database instanceOfDatabase = new WebServer.Database();
            instanceOfDatabase.NotifyCreation(true); 
        }
}

using System;

namespace Scorpio.Core
{
    public class Router
    {
        private static Router instance;
        public static Router Instance
        {
            get => instance = instance ?? new Router(); 
        }

        public static void Configure()
        {

        }
    }
}
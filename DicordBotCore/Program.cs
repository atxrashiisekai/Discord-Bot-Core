using System;
using DicordBotCore.Storage;
using DicordBotCore.Storage.Implementations;

namespace DicordBotCore
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Olá, Discord");

            
        }

        public class MyProfile
        {
            private readonly IDataStorage _storage;

            public MyProfile(IDataStorage storage)
            {
                _storage = storage;
            }

            public void NewUser(string name)
            {
                var registrationTime = DateTime.UtcNow;
                _storage.StoreObject(registrationTime, name);
            }
        }
    }
}

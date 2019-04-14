using System.Reflection.PortableExecutable;
using DicordBotCore.Storage;
using DicordBotCore.Storage.Implementations;
using Unity;

namespace DicordBotCore
{
    public static class Unity
    {
        private static UnityContainer _container;

        public static UnityContainer Container
        {
            get
            {
                if(_container == null)
                    RegisterTypes();
                return _container;
            }
        }

        public static void RegisterTypes()
        {
            _container = new UnityContainer();
            _container.RegisterType<IDataStorage, InMemoryStorage>();
        }
    }
}
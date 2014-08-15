using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    using System.Configuration;

    using Microsoft.Practices.Unity;
    using Microsoft.Practices.Unity.Configuration;

    public static class Ioc
    {
        private static IUnityContainer container;

        /// <summary>
        /// Initializes the specified resolver.
        /// </summary>
        public static void Initialize()
        {
            container = new UnityContainer();

            var section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            section.Configure(container);
        }

        /// <summary>
        /// Resolves this instance.
        /// </summary>
        /// <typeparam name="T">The Type</typeparam>
        /// <returns>Object of type T</returns>
        public static T Resolve<T>()
        {
            return container.Resolve<T>();
        }

        /// <summary>
        /// Resolves the specified name.
        /// </summary>
        /// <typeparam name="T">The Type</typeparam>
        /// <param name="name">The name.</param>
        /// <returns>Object of type T</returns>
        public static T Resolve<T>(string name)
        {
            return container.Resolve<T>(name);
        }
    }
}

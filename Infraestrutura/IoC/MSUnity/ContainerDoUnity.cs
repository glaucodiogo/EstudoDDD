using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestrutura.IoC.MSUnity
{
    public class ContainerDoUnity
    {

        static IUnityContainer container;
        static ContainerDoUnity()
        {
            //CriarContainer();
        }

        public static IUnityContainer Container
11        {
12            get
13            {
14                return container;
15            }
16 
17            set
18            {
19                container = value;
20            }
21        }
22
23        static void CriaContainer(IUnityContainer container)
24        {
25 
26            //Repositorios
27            container.RegisterType<DbContext, Conexao>(new HierarchicalLifetimeManager());
28            container.RegisterType<IUsuarioRepositorio, UsuarioRepositorio>(new InjectionConstructor(container.Resolve<Conexao>()));
29            container.RegisterType<ITarefaRepositorio, TarefaRepositorio>(new InjectionConstructor(container.Resolve<Conexao>()));
30 
31            //Servicos de Domínio
32            container.RegisterType<IUsuarioServicoDominio, UsuarioServicoDominio>(new InjectionConstructor(container.Resolve<IUsuarioRepositorio>()));
33            container.RegisterType<ITarefaServicoDominio, TarefaServicoDominio>(new InjectionConstructor(container.Resolve<ITarefaRepositorio>()));
34 
35            //Aplicação
36            
37            container.RegisterType<IUsuarioAplicServico, UsuarioAplicServico>(new InjectionConstructor(container.Resolve<IUsuarioServicoDominio>()));
38            container.RegisterType<ITarefaAplicServico, TarefaAplicServico>(new InjectionConstructor(container.Resolve<ITarefaServicoDominio>()));
39            
40        }
41 
42        public static void InicializaContainer(IUnityContainer containerInjetado)
43        {
44            CriaContainer(containerInjetado);
45        }
    }
}

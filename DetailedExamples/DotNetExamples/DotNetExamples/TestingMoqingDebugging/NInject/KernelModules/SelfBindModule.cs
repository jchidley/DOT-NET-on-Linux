using System;
using Ninject;
using Ninject.Modules;

namespace TestingMoqingDebugging.NInject
{
	public class SelfBindModule : NinjectModule
	{
		public override void Load()
		{
			Bind<SelfBindExample>().ToSelf();
		}
	}
}
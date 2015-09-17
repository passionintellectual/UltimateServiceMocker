using Microsoft.Practices.Prism.Commands;

namespace UltimateServiceMocker.Infrastructure.Business
{
    public static class GlobalCommands  
    {
        public static CompositeCommand FiddlerApplicationCloseCommand = new CompositeCommand();
    }
}

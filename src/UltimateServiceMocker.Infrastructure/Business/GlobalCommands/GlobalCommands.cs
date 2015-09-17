using Microsoft.Practices.Prism.Commands;

namespace UltimateServiceMocker.Infrastructure.Business
{
    public static class GlobalCommands  
    {
        public static CompositeCommand FiddlerApplicationCloseCommand = new CompositeCommand();

        public static CompositeCommand FiddlerApplicationStartCommand = new CompositeCommand();

        public static CompositeCommand ApplicationStartCommand = new CompositeCommand();
        public static CompositeCommand ApplicationExitCommand = new CompositeCommand();

    }
}

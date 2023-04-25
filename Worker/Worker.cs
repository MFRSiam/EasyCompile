

namespace CompilerRunner.Worker {
    abstract class Worker {
        public abstract void Run();
        public abstract Dictionary<string,string> Args();
    }

    
}

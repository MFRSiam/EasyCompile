
namespace CompilerRunner.Worker {
    class GccWorker : Worker {
        private string exe = "gcc";
        private List<string> args;

        private List<string> compilationOptions = new List<string> { 
            "-g", "-o","-Wall", "-Wextra", "-Werror"
        };

        private List<string> linkingOptions = new List<string> { "-l",
            "-L",
            "-static",
            "-dynamic"
        };

        private List<string> optimizationOptions = new List<string> { "-OO",
            "-O1",
            "-O2",
            "-O3",
            "-Os"
        };

        private List<string> debuggingOprions = new List<string> {
            "-ggdb",
            "-pg"
        };

        private List<string> preprocessor = new List<string> {
            "-I",
            "-E"
        };

        private List<string> miscellaneous = new List<string> {
            "-v",
            "-std"
        };

        public GccWorker() {
            args = new List<string>();
        }

        public override Dictionary<string, string> Args() {
            throw new NotImplementedException();
        }

        public override void Run() {
            throw new NotImplementedException();
        }
    }
}


using Spectre.Console;

namespace CompilerRunner.Worker {
    public class Tui {
        private string lang;
        private string compiler;
        private readonly string[] c_compiler = { "Gcc", "Clang", "MSVC" };
        private readonly string[] cpp_compiler = { "G++", "Clang++", "MSVC" };
        private readonly string[] language_options = { "C", "Cpp" };
        private bool initiated = false;
        private string launchLocation { get; set; } = "nill";
        public Tui() {
            Initiate();
            initiated = true;
            lang = "";
            compiler = "";
        }

        public void Greetings() {
            AnsiConsole.MarkupLine("[yellow on #070f29] Welcome To Compiler Runner[/]");
            AnsiConsole.MarkupLine("[yellow on #070f29] Dir {0}[/]",launchLocation);
            AnsiConsole.MarkupLine("[yellow on #070f29] Please Select Your Language[/]");
        }

        public void SetLang() {
            lang = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .PageSize(10)
            .Title("Select [green]Language[/]?")
            .MoreChoicesText("[grey](Move up and down to Select)[/]")
            .AddChoices(language_options));
        }
        public void SetCompiler() {
            string[] temp;
            if (compiler == language_options[0]) {
                temp = c_compiler;
            }
            else {
                temp = cpp_compiler;
            }
            compiler = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .PageSize(10)
            .Title("Select [green] Compiler [/]?")
            .MoreChoicesText("[grey](Move up and down to Select)[/]")
            .AddChoices(temp));
        }
        public void ClearScreen() {
            AnsiConsole.Clear();
        }

        public void Initiate() {
            if (!initiated) {
                Greetings();
            }
            SetLang();
            SetCompiler();
            ClearScreen();
        }


        public void MainMenu() {
            AnsiConsole.MarkupLine("[yellow on #070f29]Selected Lang {0} [/]", lang);
            AnsiConsole.MarkupLine("[yellow on #070f29]Selected Compiler {0} [/]", compiler);

        }


    }
}

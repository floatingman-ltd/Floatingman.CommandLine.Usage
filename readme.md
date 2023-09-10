# Usage example of the command line parser

1. Create a solution
1. Create a console project using the dotnet CLI and update to use a full class and main entry point
   - `dotnet new console {your project name}`
1. Add a reference to the nuget package:
   - `dotnet add package Floatingman.CommandLineParser`
1. Inherit from `ConsoleDecorator`
1. Execute `Run(args);` inside the main entiry point
1. Add a folder called plugins to the project

1. Create a command project
   - this project will have two classes
     - the args class, which defines the actual command line arguments 
     - the command class, which defines the `Execute` behaviour
1. In this first pass, we will be using a locally defined library and including it as a reference, in a subsequent pass we will use an external library and include it as a package.

## Pulling this all together

The execution requires the plugin libraries to be under the plugins folder.  The plugin library is the command library.

By executing `dotnet publish` binaries are made of the executables and libraries, the contents of the publish folder of the command library need to be copied to the plugins folder of the application.
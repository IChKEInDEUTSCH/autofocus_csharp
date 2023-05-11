using System;
using Python.Runtime;

namespace autofocus_csharp
{
    class canny_edge_counts
    {
        public static void Initializer()
        {
            string pythonDll = @"python310.dll";
            Environment.SetEnvironmentVariable("PYTHONNET_PYDLL", pythonDll);
            PythonEngine.Initialize();
        }
        static void Main(string[] args){
            string[] photo_path = new string[1]{"C:/Users/ryanr/Downloads/20230413_103128.jpg"};
            Initializer();
            using (Py.GIL())
            {
                dynamic np = Py.Import("numpy");
                Console.WriteLine(np.cos(np.pi * 2));
            }
        }
    }
}
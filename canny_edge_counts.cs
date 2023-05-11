using System;
using Python.Runtime;

namespace autofocus_csharp
{
    class canny_edge_counts
    {
        public static void Initializer()
        {
            string pythonDll = @"C:\Users\ryanr\AppData\Local\Programs\Python\Python310\python310.dll";
            Environment.SetEnvironmentVariable("PYTHONNET_PYDLL", pythonDll);
            PythonEngine.Initialize();
        }
        static void Main(string[] args){
            Initializer();
            using (Py.GIL())
            {
                dynamic np = Py.Import("numpy");
                Console.WriteLine(np.cos(np.pi * 2));
            }
        }
    }
}
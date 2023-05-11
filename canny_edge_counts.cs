using System;
using Python.Runtime;
using System.Collections.Generic;

namespace autofocus_csharp
{
    class canny_edge_counts
    {
        public static void Initializer()
        {
            string pythonDll = @"python310.dll";
            //string pythonDll = @"C:\Users\ryanr\AppData\Local\Programs\Python\Python310\python310.dll";
            Environment.SetEnvironmentVariable("PYTHONNET_PYDLL", pythonDll);
            // dynamic dict = Environment.GetEnvironmentVariables();
            // foreach(string key in dict.Keys)
            // {
            // Console.WriteLine(String.Format("{0}: {1}", key, dict[key]));
            // }
            PythonEngine.Initialize();
        }
        static void Main(string[] args){
            string[] photo_path = new string[1]{"C:/Users/ryanr/Downloads/20230413_103128.jpg"};
            Initializer();
            using (Py.GIL())
            {
                dynamic np = Py.Import("numpy");
                dynamic cv = Py.Import("cv2");
            }
            PythonEngine.Shutdown();
        }
    }
}
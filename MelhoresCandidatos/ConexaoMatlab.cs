using MongoDB.Bson;
using System.Collections;
using System.Collections.Generic;

namespace MelhoresCandidatos
{
    class ConexaoMatlab
    {
        public void getResultFromMatlab(ObjectId[] listaIDs, object[,] criterios)
        {
            // Create the MATLAB instance 
            MLApp.MLApp matlab = new MLApp.MLApp();

            // Change to the directory where the function is located 
            matlab.Execute(@"cd C:\Users\Thais\Dropbox\Projeto Multidisciplinar\Algoritmo de Tomada de Decisão");

            // Define the output 
            object result = null;

            // Call the MATLAB function myfunc
            matlab.Feval("tratamentoDados", 1, out result, listaIDs as object, criterios);

            // Display result 
            object[] res = result as object[];

            //Console.WriteLine(res[0]);
            //Console.WriteLine(res[1]);
            //Console.ReadLine();
        }
    }
}

using System;
using Microsoft.ML;


namespace DeepLearning_ImageClassification
{
    class Program
    {
        static readonly MLContext mlContext = new MLContext();

        static void Main(string[] args)
        {

            ITransformer model = ModelBuilder.GenerateModel(mlContext);
            ModelBuilder.ClassifySingleImage(mlContext, model);
            Console.ReadKey();
        }


    }


}

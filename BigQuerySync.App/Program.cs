using System;
using BigQuerySync.DAL.DAL;
using Microsoft.Extensions.Configuration;
using BigQuerySync.DAL.Models;
using System.Linq;

namespace BigQuerySync.App
{
    class Program
    {
        protected static UnitOfWorks uow;
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder().AddJsonFile($"appsettings.json", true, true);

            var config = builder.Build();
            var dbConnString = config["ConnectionString"];

            uow = new UnitOfWorks(dbConnString);

            var dataPipeline = uow.pipelineDataRepository.GetPipelines();

            uow.pipelineBQRepository.InsertPipeline(dataPipeline.ToList());
        }
    }
}

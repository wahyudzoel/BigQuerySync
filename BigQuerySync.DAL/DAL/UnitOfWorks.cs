using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigQuerySync.DAL.Repositories;

namespace BigQuerySync.DAL.DAL
{
    public class UnitOfWorks
    {
        public PipelineDataRepository pipelineDataRepository { get; set; }
        public PipelineBQRepository pipelineBQRepository { get; set; }
        public UnitOfWorks(string dbConnString)
        {
            pipelineDataRepository = new PipelineDataRepository(dbConnString);
            pipelineBQRepository = new PipelineBQRepository();
        }
    }
}

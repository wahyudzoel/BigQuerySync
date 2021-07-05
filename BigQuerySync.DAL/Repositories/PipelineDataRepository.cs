using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using BigQuerySync.DAL.Models;

namespace BigQuerySync.DAL.Repositories 
{
    public class PipelineDataRepository : DataRepository
    {
        public PipelineDataRepository (string connStr) : base (connStr)
        {

        }

        public IEnumerable<PipelineData> GetPipelines()
        {
            var sql = @"SELECT 
	                        Probability,PeriodDate,Value,ProductName,prjCode as ProjectCode,DeptCode,CustCode,CustName,BusinessRepresentative,isGroupValue as isGroup, isIndustriValue as Industry, isRecuring
                        FROM vw_Pipeline
                        WHERE Value is not null
                        AND PeriodDate >= '2021-01-01'";
            var data = Connection.Query<PipelineData>(sql);
            if (data.Any())
                return data;
            return null;
        }
    }
}

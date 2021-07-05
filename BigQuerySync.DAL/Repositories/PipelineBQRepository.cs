using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigQuerySync.DAL.Models;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.BigQuery.V2;


namespace BigQuerySync.DAL.Repositories
{
    public class PipelineBQRepository
    {

        public int truncatePipeline()
        {

            return 0;
        }
        public int InsertPipeline(List<PipelineData> data)
        {
            var credentials = GoogleCredential.FromFile("/Git Home/RnD/RnD/BigQuerySync.DAL/Asset/salespipelinedata.json");
            var client = BigQueryClient.Create("salespipelinedata",credentials);
            var dataset = client.GetOrCreateDataset("SalesSEA");
            var table = dataset.GetTableReference("Pipeline5");

            List<BigQueryInsertRow> rows = new  List<BigQueryInsertRow>() ;

            //for(int i =0;i<5;i++)
            //{
            //    BigQueryInsertRow item = new BigQueryInsertRow()
            //    {
            //        {"Probability",data[i].Probability },
            //        //{"PeriodDate2",data[i].PeriodDate },
            //        {"PeriodDate",data[i].PeriodDate.ToString("yyyy-MM-dd") },
            //        {"Value",Convert.ToDouble(data[i].Value) },
            //        {"ProductName",data[i].ProductName },
            //        {"prjCode",data[i].ProjectCode },
            //        {"deptCode",data[i].DeptCode },
            //        {"custCode",data[i].CustCode },
            //        {"custName",data[i].CustName },
            //        {"BusinessRepresentative",data[i].BusinessRepresentative },
            //        {"isGroupValue",data[i].isGroup },
            //        {"isIndustriValue",data[i].Industry },
            //        {"isRecuring",data[i].isRecurring }
            //    };

            //    rows.Add(item);
            //}
            foreach (PipelineData row in data)
            {
                BigQueryInsertRow item = new BigQueryInsertRow()
                    {
                        {"Probability",row.Probability },
                        //{"PeriodDate2",data[i].PeriodDate },
                        {"PeriodDate",row.PeriodDate.ToString("yyyy-MM-dd") },
                        {"Value",Convert.ToDouble(row.Value) },
                        {"ProductName",row.ProductName },
                        {"prjCode",row.ProjectCode },
                        {"deptCode",row.DeptCode },
                        {"custCode",row.CustCode },
                        {"custName",row.CustName },
                        {"BusinessRepresentative",row.BusinessRepresentative },
                        {"isGroupValue",row.isGroup },
                        {"isIndustriValue",row.Industry },
                        {"isRecuring",row.isRecurring }
                    };

                rows.Add(item);

            }
             client.InsertRows(table, rows);

            return 0;
        }
    }
}

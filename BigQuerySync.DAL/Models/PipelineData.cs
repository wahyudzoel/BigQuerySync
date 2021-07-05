using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigQuerySync.DAL.Models
{
    public class PipelineData
    {
        public string Probability { get; set; }
        public DateTime PeriodDate { get; set; }
        public Decimal Value { get; set; }
        public string  ProductName{ get; set; }
        public string Definition { get; set; }
        public string ProjectCode { get; set; }
        public string DeptCode { get; set; }
        public string CustCode { get; set; }
        public string CustName { get; set; }
        public string BusinessRepresentative { get; set; }
        public string isGroup  { get; set; }
        public string  Industry  { get; set; }
        public string isRecurring { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.DataAccess.Params
{
    public class SupplierParam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset JoinDate { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
    }
}

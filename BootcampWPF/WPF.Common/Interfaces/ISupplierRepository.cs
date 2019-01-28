using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.DataAccess.Model;
using WPF.DataAccess.Params;

namespace WPF.Common.Interfaces
{
    public interface ISupplierRepository
    {
        bool Insert(SupplierParam supplierParam);
        bool Update(int? id, SupplierParam supplierParam);
        bool Delete(int? id);
        List<Suppliers> Get();
        Suppliers Get(int? id);

        List<Suppliers> Search(string search,string cmb);
    }
}

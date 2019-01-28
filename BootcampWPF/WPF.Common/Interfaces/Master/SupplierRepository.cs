using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPF.DataAccess.Model;
using WPF.DataAccess.Params;

namespace WPF.Common.Interfaces.Master
{
    public class SupplierRepository : ISupplierRepository
    {
        bool status = false;
        MyContext _contex = new MyContext();
        Suppliers supplier = new Suppliers();
        public bool Delete(int? id)
        {
            var result = 0;
            var supplier = Get(id);
            supplier.IsDelete = true;
            supplier.DeleteDate = DateTimeOffset.Now.LocalDateTime;
            result = _contex.SaveChanges();

            if (result > 0)
            {
                status = true;
                MessageBox.Show("Delete Successfully");
            }
            return status;
        }

        public List<Suppliers> Get()
        {
            return _contex.Suppliers.Where(x => x.IsDelete == false).ToList();
        }

        public Suppliers Get(int? id)
        {
            return _contex.Suppliers.Where(x => x.Id == id && x.IsDelete == false).SingleOrDefault();
            
        }

        public bool Insert(SupplierParam supplierParam)
        {
            var result = 0;
            supplier.Name = supplierParam.Name;
            supplier.JoinDate = DateTimeOffset.Now.LocalDateTime;
            supplier.CreateDate = DateTimeOffset.Now.LocalDateTime;
            _contex.Suppliers.Add(supplier);
            result = _contex.SaveChanges();

            if (result > 0)
            {
                status = true;
                MessageBox.Show("Insert Successfully");
            }
            return status;

        }

        public bool Update(int? id, SupplierParam supplierParam)
        {
            var result = 0;
            Suppliers supplier = Get(id);
            supplier.Name = supplierParam.Name;
            supplier.UpdateDate = DateTimeOffset.Now.LocalDateTime;
            result = _contex.SaveChanges();
            if (result > 0)
            {
                status = true;
                MessageBox.Show("Update Successfully");

            }
            return status;
        }

        public List<Suppliers> Search(string search,string cmb)
        {
            if (cmb == "Id")
            {
                return _contex.Suppliers.Where(x => x.IsDelete == false && x.Id.ToString().Contains(search)).ToList();
                
            }
            else if (cmb == "Name")
            {
                return _contex.Suppliers.Where(x => x.IsDelete == false && x.Name.ToString().Contains(search)).ToList();
            }
            else if (cmb=="Join Date")
            {
                DateTimeOffset parseDate = DateTimeOffset.Parse(search);
                //MessageBox.Show(parseDate.ToString());
                return _contex.Suppliers.Where(x => x.IsDelete == false && x.JoinDate <= parseDate).ToList();
            }
            else
            {
                return _contex.Suppliers.Where(x => x.IsDelete == false).ToList();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Common.Interfaces;
using WPF.Common.Interfaces.Master;
using WPF.DataAccess.Model;
using WPF.DataAccess.Params;
using System.Windows.Forms;

namespace WPF.BussinessLogic.Services.Master
{
    public class SupplierService : ISupplierService
    {
        ISupplierRepository _supplierRepository = new SupplierRepository();
        MyContext _contex = new MyContext();
        bool status = false;
        public bool Delete(int? id)
        {
            if (String.IsNullOrWhiteSpace(id.ToString()) == true)
            {
                MessageBox.Show("Please Input ID Correctly");
            }
            else
            {
                var getsupplier = _supplierRepository.Get(id);
                if (getsupplier == null)
                {
                    MessageBox.Show("Id Not Found in Database");
                }
                else
                {
                    status = _supplierRepository.Delete(id);
                }

            }
            return status;

        }

        public List<Suppliers> Get()
        {
            return _supplierRepository.Get();
        }

        public Suppliers Get(int? id)
        {
            return _supplierRepository.Get(id);
        }

        public bool Insert(SupplierParam supplierParam)
        {
            //belum fix
            if (String.IsNullOrWhiteSpace(supplierParam.Name) == true)
            {
                MessageBox.Show("Name Don't Empty");
            }
            else
            {
                _supplierRepository.Insert(supplierParam);
                status = true;
            }
            return status;


        }

        public bool Update(int? id, SupplierParam supplierParam)
        {
            //belum fix
            if (String.IsNullOrWhiteSpace(id.ToString()))
            {
                MessageBox.Show("Please Input ID Correctly");

            }
            else
            {
                var getsupplier = _supplierRepository.Get(id);
                if (getsupplier == null)
                {
                    MessageBox.Show("Id Not Found in Database");
                }
                else
                {
                    if (String.IsNullOrWhiteSpace(supplierParam.Name) == true)
                    {
                        MessageBox.Show("Name Don't Empty");
                    }
                    else
                    {
                        _supplierRepository.Update(id, supplierParam);
                        status = true;
                    }
                }
            }

            return status;
        }

        public List<Suppliers> Search(string search,string cmb)
        {
           return _supplierRepository.Search(search,cmb);
        }
    }
}

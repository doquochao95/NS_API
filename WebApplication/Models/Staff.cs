using EF_CONFIG;
using EF_CONFIG.WebBaseModel;
using EF_CONFIG.BaseModel;
using EF_CONFIG.DataTransform;
using EF_CONFIG.Model;

namespace WebApplicationAPI.Models
{
    public class Staff
    {
        private NeedleSupplierDataContext _dataContext;
        private WebStaffBase _staffBase;

        public Staff(NeedleSupplierDataContext dataContext,int id)
        {
            _dataContext = dataContext;
            _staffBase = new WebStaffBase(_dataContext);
            var staff = _staffBase.Get_Staff(id);
            ID = id;
            Name = staff.StaffName;
            CardNumber = staff.CardNumber;
            Department = staff.Department;
            UserName = staff.UserName;
            UserPassword = staff.UserPassword;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int CardNumber { get; set; }
        public string Department { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }

    }
}
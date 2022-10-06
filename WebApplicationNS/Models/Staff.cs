using EF_CONFIG;
using EF_CONFIG.WebBaseModel;
using EF_CONFIG.BaseModel;
using EF_CONFIG.DataTransform;
using EF_CONFIG.Model;

namespace WebApplicationNS.Models
{
    public class Staff
    {
        private NS_Staffs staff;

        public Staff(int id)
        {
            staff = EF_CONFIG.DataTransform.StaffBase.Get_Staffs(id);
            ID = id;
            Name = staff.StaffName;
            Department = staff.Department;
            UserName = staff.UserName;
            UserPassword = staff.UserPassword;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }

    }
}
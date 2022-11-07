using Dal_lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test
{
    public class validate
    {
        MyContext db=new MyContext();
        public bool check()
        {
            bool ans = false;
            var found = db.AdminInfos.ToList();
            if (found[0].EmailId == "avs@gmail.com" && found[0].Password == "avs123")
            {
                ans = true;
            }
            return ans;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<AdminInfo> adminInfos = new List<AdminInfo>();
            adminInfos.Add(new AdminInfo() { Email = "bhavya_arora@gamil.com", Password = "arora" });
            adminInfos.Add(new AdminInfo() { Email = "aubrey_graham@gamil.com", Password = "drake" });
            context.AdminInfos.AddRange(adminInfos);
            context.SaveChanges();
            List<EmpInfo> empInfos = new List<EmpInfo>();
            empInfos.Add(new EmpInfo() { Email = "kanye@gmail.com" , Passcode =016 , DateOfJoining =new  DateTime(2020,09,11) , Name ="kanye"});
            empInfos.Add(new EmpInfo() { Email = "jwrld@gmail.com" , Passcode =999 , DateOfJoining =new  DateTime(2019,04,11) , Name ="WRLD"});
            empInfos.Add(new EmpInfo() { Email = "sdogg@gmail.com" , Passcode =420 , DateOfJoining =new  DateTime(2020,03,22) , Name ="snoop"});
            context.EmpInfos.AddRange(empInfos);
            List<BlogInfo> blogInfos = new List<BlogInfo>();
            blogInfos.Add(new BlogInfo() { Email ="sdogg@gmail.com" , BlogUrl= "https://github.com/bhavyaarora0016?tab=repositories" , DateOfCreation = new DateTime(2020,02,02) , Subject="GitRepo" , Title ="My GitRepo"});
            blogInfos.Add(new BlogInfo() { Email ="kanye@gmail.com" , BlogUrl= "https://github.com/bhavyaarora0016?tab=repositories" , DateOfCreation = new DateTime(2020,02,02) , Subject="GitRepo" , Title ="My GitRepo"});
            context.BlogInfos.AddRange(blogInfos);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Repository;

namespace Dal.Test
{
    [TestFixture]
    public class BlogTrackerTest
    {
        BlogContext blog = new BlogContext();
        UnitOfWork unit = new UnitOfWork();
        [TestCase("bhavya_arora@gmail.com" ,ExpectedResult =true )]
        [TestCase("kanye@gmail.com",ExpectedResult = true)]
        [TestCase("aubrey_graham@gmail.com", ExpectedResult = true)]
        [TestCase("sdogg@gmail.com", ExpectedResult = true)]
        public bool Validate(string ans)
        {
            var found = unit.AdminRepo.GetByID(ans);
            if(found != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}

using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfAboutDal : GenericRepository<About>, IAboutDal // crud operasyonları dışında ayrı bir işlem yapılmak istenirse ve bu işlem sadece ilgili entity'e ait olursa imza IAboutDal'da atılacak. İçi ise bu kısımda doldurulacak. O yüzden IAboutDal kısmı burada miras olarak tanımlanır. 
    {

    }
}

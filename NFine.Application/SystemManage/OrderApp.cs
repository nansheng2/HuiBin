using NFine.Domain.Entity.SystemManage;
using NFine.IRepository.SystemManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Application.SystemManage
{
    /// <summary>
    /// 预约处理
    /// </summary>
    public class OrderApp
    {
        private IOrderRepository service = new OrderRepository();

        public IQueryable<OrderEntity> GetList(Expression<Func<OrderEntity, bool>> predicate)
        {
            return service.IQueryable(predicate);
        }
    }
}

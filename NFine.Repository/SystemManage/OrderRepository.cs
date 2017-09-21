﻿using NFine.Data;
using NFine.Domain.Entity.SystemManage;
using NFine.Domain.IRepository.SystemManage;
using System.Collections.Generic;

namespace NFine.IRepository.SystemManage
{
    /// <summary>
    /// 预约表
    /// </summary>
    public class OrderRepository : RepositoryBase<OrderEntity>, IOrderRepository
    {
        /// <summary>
        /// 删除操作
        /// </summary>
        /// <param name="keyValue">key</param>
        public void DeleteForm(string keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
              
                db.Commit();
            }
        }
        
        /// <summary>
        /// 保存操作
        /// </summary>
        /// <param name="entity">entity</param>
        /// <param name="keyValue">key</param>
        public void SubmitForm(OrderEntity entity, string keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                db.Commit();
            }
        }
    }
}
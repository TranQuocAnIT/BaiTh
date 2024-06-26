﻿using BaiTh.Models;

namespace BaiTh.Repository
{
    public interface IOrderRepositorycs
    {
        Task<IEnumerable<Order>> GetAllAsync();
        Task<Order> GetByIdAsync(int id);
    }
}

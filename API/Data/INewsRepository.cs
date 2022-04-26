using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;
using API.DTOs;

namespace API.Data
{
    public interface INewsRepository
    {
      Task<bool> SaveAll();
      Task<List<NewsE>> GetNewsAsync(NewsDto n);
    }
}
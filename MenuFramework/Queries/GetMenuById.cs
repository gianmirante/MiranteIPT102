using Dapper;
using MenuDomain.Models;
using MenuDomain.Queries;
using MenuRepository.Interface;
using MenuRepository.Interface;
using System.Data;

namespace MenuFramework.Queries
{
    public class GetMenuById : IGetMenuById
    {
        private readonly IRepository _repo;

        public GetMenuById(IRepository repo)
        {
            _repo = repo;
        }

        public MenuModel Execute(int menuId)
        {
            using var db = _repo.CreateConnection();
            return db.QueryFirstOrDefault<MenuModel>(
                "sp_GetMenuById",
                new { MenuId = menuId },
                commandType: CommandType.StoredProcedure);
        }
    }
}

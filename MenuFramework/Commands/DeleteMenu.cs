using Dapper;
using MenuDomain.Commands;
using MenuRepository.Interface;
using MenuRepository.Interface;
using System.Data;

namespace MenuFramework.Commands
{
    public class DeleteMenu : IDeleteMenu
    {
        private readonly IRepository _repo;

        public DeleteMenu(IRepository repo)
        {
            _repo = repo;
        }

        public void Execute(int menuId)
        {
            using var db = _repo.CreateConnection();
            db.Execute("DeleteMenu", new { MenuId = menuId }, commandType: CommandType.StoredProcedure);
        }
    }
}

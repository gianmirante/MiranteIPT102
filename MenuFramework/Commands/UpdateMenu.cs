using Dapper;
using MenuDomain.Commands;
using MenuDomain.Models;
using MenuRepository.Interface;
using System.Data;

namespace MenuFramework.Commands
{
    public class UpdateMenu : IUpdateMenu
    {
        private readonly IRepository _repo;

        public UpdateMenu(IRepository repo)
        {
            _repo = repo;
        }

        public void Execute(MenuModel model)
        {
            using var db = _repo.CreateConnection();
            db.Execute("UpdateMenu", model, commandType: CommandType.StoredProcedure);
        }
    }
}

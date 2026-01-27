using Dapper;
using MenuDomain.Commands;
using MenuDomain.Models;
using MenuRepository.Interface;
using System.Data;

namespace MenuFramework.Commands
{
    public class CreateMenu : ICreateMenu
    {
        private readonly IRepository _repo;

        public CreateMenu(IRepository repo)
        {
            _repo = repo;
        }

        public void Execute(MenuModel model)
        {
            using var db = _repo.CreateConnection();
            db.Execute("CreateMenu", model, commandType: CommandType.StoredProcedure);
        }
    }
}

using MenuDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuDomain.Commands
{
    public interface IUpdateMenu
    {
        void Execute(MenuModel model);
    }
}

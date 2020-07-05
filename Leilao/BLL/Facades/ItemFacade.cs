using TFLeilao.PL;
using TFLeilao.BLL.DAO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TFLeilao.BLL.Facades
{
    public class ItemFacade
    {
        private ItemDao ItemDao;

        public ItemFacade()
        {
            ItemDao = new ItemDao();
        }

        public  Task<List<Item>> ListarTudo() =>  ItemDao.ListarTudo();

        public  Task Create(Item item) =>  ItemDao.Create(item);

        public Task DeletarId(int? id) => ItemDao.DeletarId(id);

        public  Task<Item> EditarId(int? id) =>  ItemDao.EditarId(id);

        public async Task UpdateItem(Item item) => await ItemDao.UpdateItem(item);

        public bool ItemExists(int id) => ItemDao.ItemExists(id);
    }
}

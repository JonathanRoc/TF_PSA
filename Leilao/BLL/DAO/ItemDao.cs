using TFLeilao.PL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFLeilao.BLL.DAO
{
    public class ItemDao
    {
        private readonly LeilaoContext _context;

        public ItemDao()
        {
            _context = new LeilaoContext();
        }

        public LeilaoContext GetContext()
        {
            return _context;
        }

        public async Task<List<Item>> ListarTudo() => await _context.Itens.ToListAsync();

        public async Task<Item> DetalhesId(int? id)
        {
            return await _context.Itens.FirstOrDefaultAsync(m => m.ItemId == id);
        }

        public async Task Create(Item item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
        }

        public async Task<Item> EditarId(int? id)
        {
            return await _context.Itens.FindAsync(id);
        }

        public async Task UpdateItem(Item item)
        {
            _context.Update(item);
            await _context.SaveChangesAsync();
        }


        public async Task<Item> GetDeletadosId(int? id)
        {
            var item = await _context.Itens.FirstOrDefaultAsync(m => m.ItemId == id);

            return item;
        }

        public async Task DeletarId(int? id)
        {
            var item = await _context.Itens.FirstOrDefaultAsync(m => m.ItemId == id);
            _context.Itens.Remove(item);
            await _context.SaveChangesAsync();
        }
        public bool ItemExists(int id)
        {
            return _context.Itens.Any(e => e.ItemId == id);
        }
    }
}
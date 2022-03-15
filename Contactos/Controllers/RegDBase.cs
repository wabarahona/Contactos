using System;
using SQLite;
using Contactos.Models;
using Contactos.Views;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Contactos.Controllers
{
    public class RegDBase
    {
        readonly SQLiteAsyncConnection dbaseconnection;


        public RegDBase(String dbpath)
        {
            dbaseconnection = new SQLiteAsyncConnection(dbpath);


            dbaseconnection.CreateTableAsync<RegistroPersonas>();
        }

        public Task<List<RegistroPersonas>> GetRegistroPersonas(Xamarin.Forms.CollectionView listaRegistros)
        {
            return dbaseconnection.Table<RegistroPersonas>().ToListAsync();
        }
        //Opreaciones CRUD

        public Task<int> AddRegistroPersonas(RegistroPersonas personas)
        {
            if (personas.ID != 0)
            {
                return dbaseconnection.UpdateAsync(personas);
            }
            else
            {
                return dbaseconnection.InsertAsync(personas);
            }
        }
        public Task<RegistroPersonas> GetPersonas(int pid)
        {

            return dbaseconnection.Table<RegistroPersonas>().
                Where(i => i.ID == pid).FirstOrDefaultAsync();
        }

        public Task<int> DelPersona(RegistroPersonas personas)
        {
            return dbaseconnection.DeleteAsync(personas);
        }
    }
}

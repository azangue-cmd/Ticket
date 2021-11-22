using BibliothèqueSerialisation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.BO;

namespace Ticket.DAL
{
    public class BaseRepertory <T> where T: Produit
    {
        protected List<T> datas;

        private readonly string PATH;
        private Serializer<List<T>> serializer;

        public BaseRepertory()
        {
            datas = new List<T>();
            PATH = $"Data/{typeof(T).Name}.json";

            FileInfo fi = new FileInfo(PATH);
            if (!fi.Directory.Exists)
            {
                fi.Directory.Create();
            }

            serializer = new Serializer<List<T>>(BibliothèqueSerialisation.Mode.JSON, PATH);
            Restor();
        }


        public void Restor()
        {
            FileInfo fi = new FileInfo(PATH);
            if (fi.Exists && fi.Length > 0)
            {
                datas = serializer.Deserialize();
            }

        }

        public void Delete(T objet)
        {
            var index = -1;
            for (int i = 0; i < datas.Count; i++)
                if (datas[i].Equals(objet))
                    index = i;
            if (index >= 0)
                datas.RemoveAt(index);
        }

        public void Add(T objet)
        {
            foreach (var data in datas)
                if (data.Equals(objet))
                    throw new DuplicateWaitObjectException($"{ nameof(T) } already exixt !");

            datas.Add(objet);
        }

        public void Save()
        {
            serializer.Serialize(datas);
        }

        public void Update (T oldobjet, T newobjet)
        {
            var oldindex = -1;
            for (int i = 0; i < datas.Count; i++)
                if (datas[i].Equals(oldobjet))
                    oldindex = i;
            if (oldindex < 0)
                throw new KeyNotFoundException($"{nameof(T)} not found !");

            var newindex = -1;
            for (int i = 0; i < datas.Count; i++)
                if (datas[i].Equals(newobjet))
                    newindex = i;
            if (newindex >= 0 && newindex != oldindex)
                throw new KeyNotFoundException($"{nameof(T)} already exixt !");

            datas[oldindex] = newobjet;
        }

        public List<T> GetAll()
        {
           
            T[] copy = new T[datas.Count];
            datas.CopyTo(copy);
            return copy.ToList();
        }
    }
}

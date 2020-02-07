using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class FileRepository<T> : IRepository<T>
    {
        private FileContext fileContext;

        public FileRepository(FileContext fileContext)
        {
            this.fileContext = fileContext;
        }

        public void Add(T entity)
        {
            string item = JsonConvert.SerializeObject(entity);

            List<string> contents = fileContext.Read();

            contents.Add(item);

            fileContext.Save(contents);
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            IEnumerable<T> results = null;
            List<T> responseObject = new List<T>();

            List<string> contents = fileContext.Read();

            foreach (string item in contents)
            {
                T t = JsonConvert.DeserializeObject<T>(item);
                responseObject.Add(t);
            }

            results = responseObject;

            return results;
        }
    }
}

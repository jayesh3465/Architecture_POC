using System.Linq.Expressions;
using System.Security.Principal;

namespace NetCoreMicroServices_POC.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ProductContext context;
        private DbSet<T> entities;
        public Repository(ProductContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return entities.AsEnumerable();
        }
        public async Task<T> Get(int id)
        {
            return await entities.FindAsync(id);
        }
        public async Task Insert(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                await entities.AddAsync(entity);
                await SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public async Task Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            await SaveChanges();
        }
        public async Task Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            await SaveChanges();
        }
        public async Task SaveChanges()
        {
            await context.SaveChangesAsync();
        }

       
    }
   
}

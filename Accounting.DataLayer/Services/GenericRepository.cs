using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer
{
    public class GenericRepository <TEntity> where TEntity : class // مخفف تایب انتیتی یا همون نام جدول مورد نظر هست
    {
        private ShopAccountingDBEntities _db;
        private DbSet<TEntity> _dbSet; // نماینده اون تیبل هست

        // یه کاسنتراکتور باید براش بسازیم 
        public GenericRepository(ShopAccountingDBEntities db)
        {
            // همون کاری که تو اون ری\وزیتوری کردیم کسی حق نداره از رو این نمونه سازه باید از رو یونیت اف ورک نمونه بسازن
            _db = db;
            // میگیم آندرلاین دیبی این تیبل رو بده به دیبی و بریزش تو دیبی ست
            _dbSet = _db.Set<TEntity>();
        }
        // گت باید سه تا کار بکنه 
        // بتونه لامبدا بگیره
        // نتیجه همینجا بتونه مرتب بشه
        // روابط باید به نتیجه انکلود بشن
        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where = null) // اینطوری کسی که گت رو صدا بزنه میتونه عبارت لامبدا بهش بده
        {
            IQueryable<TEntity> query = _dbSet;

            if (where != null)
            {
                query = query.Where(where);
            }

            return query.ToList();
        }

        public virtual TEntity GetById(object Id)
        {
            return _dbSet.Find(Id);
        }

        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }

            _dbSet.Remove(entity);
        }

        public virtual void Delete(object Id)
        {
            var entity = GetById(Id);
            Delete(entity);
        }
    }
}

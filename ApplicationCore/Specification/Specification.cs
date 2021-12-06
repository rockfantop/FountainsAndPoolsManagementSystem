using ApplicationCore.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ApplicationCore.Specification
{
    public class Specification<TEntity>
        where TEntity : BaseDbEntity
    {
        public Expression<Func<TEntity, bool>> Expression { get; }

        public Func<TEntity, bool> Func => this.Expression.Compile();

        public Specification(Expression<Func<TEntity, bool>> expression)
        {
            this.Expression = expression;
        }

        public bool IsSatisfiedBy(TEntity entity)
        {
            return this.Func(entity);
        }
    }
}

using ApplicationCore.Entities;
using ApplicationCore.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Specification.Methods
{
    public static class SpecificationMethods
    {
        public static Specification<TEntity> GetById<TEntity>(Guid id)
            where TEntity : BaseDbEntity
        {
            return new Specification<TEntity>(x => x.Id == id);
        }

        public static Specification<PoolConfiguration> GetConfigurationByName(string name)
        {
            return new Specification<PoolConfiguration>(x => x.Name == name);
        }

        public static Specification<Pool> GetPoolByConfiguration(Guid id)
        {
            return new Specification<Pool>(x => x.ConfigurationId == id);
        }

        public static Specification<PoolSchedule> GetScheduleByDate(DateTime date)
        {
            return new Specification<PoolSchedule>(x => x.DateStart <= date && x.DateEnd >= date);
        }
    }
}

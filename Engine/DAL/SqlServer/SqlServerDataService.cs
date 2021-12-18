using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Engine.DAL.Interface;
using Engine.DAL.Model;

namespace Engine.DAL.SqlServer
{
    public class SqlServerDataService : IDataService
    {
        private readonly SqlServerContext _sqlServerContext;

        public SqlServerDataService(SqlServerContext sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }

        public Data GetById(int id) => _sqlServerContext.Data.SingleOrDefault(d => d.ID == id);

        public List<Data> GetAll() => _sqlServerContext.Data.ToList();

        public List<Data> GetByKey(string key) => _sqlServerContext.Data.Where(d => d.Key.Contains(key)).ToList();

        public List<Data> GetByDescription(string description) => _sqlServerContext.Data.Where(d => d.Description.Contains(description)).ToList();

        public List<Data> GetByValue(string value) => _sqlServerContext.Data.Where(d => d.Value.Contains(value)).ToList();

        public List<Data> GetByCreatedDate(DateTime createdDate) =>
            _sqlServerContext.Data.Where(d => d.CreatedDate.Date == createdDate.Date).ToList();

        public List<Data> GetByBox(int box)
            => _sqlServerContext.Data.Where(d => d.Box == box).ToList();

        public List<Data> GetBySection(int section)
            => _sqlServerContext.Data.Where(d => d.Section == section).ToList();

        public List<Data> GetByFullSection(int box, int section)
            => _sqlServerContext.Data.Where(d => d.Box == box && d.Section == section).ToList();

        public void Create(Data data)
        {
            _sqlServerContext.Data.Add(data);
            _sqlServerContext.SaveChanges();
        }

        public void Update(Data data)
        {
            var readedData = GetById(data.ID);
            if (readedData == null)
                Create(data);
            else
            {
                readedData.Key = data.Key;
                readedData.Description = data.Description;
                readedData.Value = data.Value;
            }

            _sqlServerContext.SaveChanges();
        }

        public void UpdateBoxes()
        {
            var datas = _sqlServerContext.Data
                .Where(h => h.Date != DateTime.Now)
                .ToList();
            foreach (var data in datas)
            {
                data.Date = DateTime.Now;
                if (data.Section < (int) Math.Pow(2, data.Box - 1))
                    data.Section += 1;
            }

            _sqlServerContext.SaveChanges();
        }

        public void Delete(Data data)
        {
            if (data == null)
                return;
            _sqlServerContext.Data.Remove(data);
            _sqlServerContext.SaveChanges();
        }
    }
}
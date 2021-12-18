using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Engine.DAL.Interface;
using Engine.DAL.Model;
using Newtonsoft.Json;

namespace Engine.DAL.Txt
{
    public class TxtDataService : IDataService
    {
        private readonly string _dbFilePath = $"{AppDomain.CurrentDomain.BaseDirectory}/DataBase.txt";
        private List<Data> _datas;

        public TxtDataService()
        {
            Read();
        }

        public Data GetById(int id) => _datas.SingleOrDefault(d => d.ID == id);

        public List<Data> GetAll() => _datas.ToList();

        public List<Data> GetByKey(string key) => _datas.Where(d => d.Key.Contains(key)).ToList();

        public List<Data> GetByDescription(string description) => _datas.Where(d => d.Description.Contains(description)).ToList();

        public List<Data> GetByValue(string value) => _datas.Where(d => d.Value.Contains(value)).ToList();

        public List<Data> GetByCreatedDate(DateTime createdDate) =>
            _datas.Where(d => d.CreatedDate.Date == createdDate.Date).ToList();

        public List<Data> GetByBox(int box)
            => _datas.Where(d => d.Box == box).ToList();

        public List<Data> GetBySection(int section)
            => _datas.Where(d => d.Section == section).ToList();

        public List<Data> GetByFullSection(int box, int section)
            => _datas.Where(d => d.Box == box && d.Section == section).ToList();

        public void Create(Data data)
        {
            _datas.Add(data);
            Write();
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

            Write();
        }

        public void UpdateBoxes()
        {
            var datas = _datas
                .Where(h => h.Date != DateTime.Now)
                .ToList();
            foreach (var data in datas)
            {
                data.Date = DateTime.Now;
                if (data.Section < (int) Math.Pow(2, data.Box - 1))
                    data.Section += 1;
            }

            Write();
        }

        public void Delete(Data data)
        {
            if (data == null)
                return;
            _datas.Remove(data);
            Write();
        }

        private void Read()
        {
            if (!File.Exists(_dbFilePath))
            {
                _datas = new List<Data>();
            }
            else
            {
                var dbFileContent = string.Empty;
                using (var sr = new StreamReader(_dbFilePath))
                {
                    dbFileContent = sr.ReadToEnd();
                }
                _datas = string.IsNullOrWhiteSpace(dbFileContent)
                    ? new List<Data>()
                    : JsonConvert.DeserializeObject<List<Data>>(dbFileContent);
            }
        }

        private void Write()
        {
            using (var sw = new StreamWriter(_dbFilePath))
            {
                sw.WriteLine(JsonConvert.SerializeObject(_datas));
            }
        }
    }
}
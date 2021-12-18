using System;
using System.Collections.Generic;
using Engine.DAL.Model;

namespace Engine.DAL.Interface
{
    public interface IDataService
    {
        Data GetById(int id);
        List<Data> GetAll();
        List<Data> GetByKey(string vocab);
        List<Data> GetByDescription(string description);
        List<Data> GetByValue(string value);
        List<Data> GetByCreatedDate(DateTime createdDate);
        List<Data> GetByBox(int box);
        List<Data> GetBySection(int section);
        List<Data> GetByFullSection(int box, int section);
        void Create(Data data);
        void Update(Data data);
        void UpdateBoxes();
        void Delete(Data data);
    }
}
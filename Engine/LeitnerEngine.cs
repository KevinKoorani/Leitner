using System;
using Engine.DAL.Interface;
using Engine.DAL.SqlServer;
using Engine.DAL.Txt;

namespace Engine
{
    public class LeitnerEngine
    {
        public IDataService GetDataService(DbEnum dbTypEnum)
        {
            switch (dbTypEnum)
            {
                case DbEnum.SqlServer:
                    return new SqlServerDataService(SqlServerContext.GetContext);
                case DbEnum.MsAccess:
                    return new SqlServerDataService(SqlServerContext.GetContext);
                case DbEnum.TxtFile:
                    return new TxtDataService();
                default:
                    throw new ArgumentOutOfRangeException(nameof(dbTypEnum), dbTypEnum, null);
            }
        }
    }
}

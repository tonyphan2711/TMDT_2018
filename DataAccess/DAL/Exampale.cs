using Dapper;
using DBO.DATA;
using ERP.Framework.Common;
using ERP.Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL
{
    public class Exampale : BaseDal<ADOProvider>
    {

        //public IList<Contract> GetContracts(BaseListParam listParam, out int? totalRecord)
        //{
        //    try
        //    {
        //        var param = new DynamicParameters();
        //        param.Add("@FilterField", listParam.FilterField);
        //        param.Add("@OrderByField", listParam.OrderByField);
        //        param.Add("@PageIndex", listParam.PageIndex);
        //        param.Add("@PageSize", listParam.PageSize);
        //        param.Add("@UserId", listParam.UserId);
        //        param.Add("@RoleId", listParam.UserType);
        //        param.Add("@DeptId", listParam.DeptId);
        //        param.Add("@LanguageID", listParam.LanguageCode);
        //        param.Add("@TotalRecord", dbType: DbType.Int32, direction: ParameterDirection.Output);
        //        var values = UnitOfWork.Procedure<Contract>("Contract_Gets", param).ToList();
        //        totalRecord = param.GetDataOutput<int>("@TotalRecord");
        //        return values;
        //    }
        //    catch (Exception)
        //    {
        //        totalRecord = 0;
        //        return new List<Contract>();
        //    }
        //}
        public IList<Exam> GetContracts()
        {
            return UnitOfWork.Procedure<Exam>("Exam_GetAll").ToList();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProInterface.Models;

namespace ProInterface
{
    /// <summary>
    /// 客户内容
    /// </summary>
    public interface IZ_Client
    {
        #region 默认接口

        /// <summary>
        /// 查找所有
        /// </summary>
        /// <param name="loginKey">登录凭证</param>
        /// <param name="err">错误信息</param>
        /// <returns></returns>
        IList<YL_CLIENT> Client_FindAll(string loginKey, ref ErrorInfo err);

        /// <summary>
        /// 修改客户
        /// </summary>
        /// <param name="loginKey">登录凭证</param>
        /// <param name="err">错误信息</param>
        /// <param name="inEnt">实体类</param>
        /// <param name="allPar">更新的参数</param>
        /// <returns>修改客户</returns>
        bool Client_Save(string loginKey, ref ErrorInfo err, YL_CLIENT inEnt, IList<string> allPar);

        /// <summary>
        /// 查询一条
        /// </summary>
        /// <param name="loginKey">登录凭证</param>
        /// <param name="err">错误信息</param>
        /// <param name="keyId">主键</param>
        /// <returns></returns>
        YL_CLIENT Client_SingleId(string loginKey, ref ErrorInfo err, int keyId);

        /// <summary>
        /// 删除客户
        /// </summary>
        /// <param name="loginKey">登录凭证</param>
        /// <param name="err">错误信息</param>
        /// <param name="keyId">删除客户</param>
        /// <returns></returns>
        bool Client_Delete(string loginKey, ref ErrorInfo err, int keyId);
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="loginKey">登录凭证</param>
        /// <param name="err">错误信息</param>
        /// <param name="pageIndex">当前页数</param>
        /// <param name="pageSize">页面大小</param>
        /// <param name="whereLambda">条件lambda表达表</param>
        /// <param name="orderField">排序</param>
        /// <param name="orderBy">排序方式</param>
        /// <returns>返回满足条件的泛型</returns>
        IList<YL_CLIENT> Client_Where(string loginKey, ref ErrorInfo err, int pageIndex, int pageSize, string whereLambda, string orderField, string orderBy);

        /// <summary>
        /// 满足条件记录数
        /// </summary>
        /// <param name="loginKey">登录凭证</param>
        /// <param name="err">错误信息</param>
        /// <param name="whereLambda">条件lambda表达表</param>
        /// <returns></returns>
        int Client_Count(string loginKey, ref ErrorInfo err, string whereLambda);

        #endregion
    }
}
using System;
using System.Collections.Generic;
//using iih.ci.ord.cior.s.itf;
using xap.mw.core.utils;
using xap.mw.coreitf.d;
using xap.mw.serviceframework;
using xap.rui.appfw;
using xap.mw.core.data;
using xap.sys.appfw.tmpl.qryscheme; 
using iih.ci.ord.cior.d;
using xap.sys.basebiz.appfwdata;
using xap.sys.appfw.tmpl.qryscheme.qrydto;

namespace iih.ci.ord.cior.i
{
    public class IOrdApPathgySampDOCrudServiceImpl : IOrdApPathgySampDOCrudService
    {
        private string url   = XapSvrConfig.BaseUrl + "iihci.ord/iih.ci.ord.cior.i.IOrdApPathgySampDOCudService";//ConfigUtil.getServiceUrl();
        private string url_r = XapSvrConfig.BaseUrl + "iihci.ord/iih.ci.ord.cior.i.IOrdApPathgySampDORService";//ConfigUtil.getServiceUrl();
        
        private ServiceInvocation si;
		private CacheHelper<OrdApPathgySampDO> ch;
        /// <summary>
        /// 构造函数
        /// </summary>
        public IOrdApPathgySampDOCrudServiceImpl()
        {
        	ch = new CacheHelper<OrdApPathgySampDO>();
            si = new ServiceInvocationImpl();
            si.url = url;
        }

        /// <summary>
        /// 病理申请单AggDO数据真删除
        /// </summary>
        /// <param name="aggdos"></param>
        public void delete(OrdApPathgySampDO[] aggdos)
        {
            List<object> param = new List<object>();
            param.Add(aggdos);
            si.url = url;
            si.invokeList<OrdApPathgySampDO>("delete", param.ToArray());  
        }

        /// <summary>
        /// 病理申请单AggDO数据插入保存
        /// </summary>
        /// <param name="aggdos"></param>
        /// <returns></returns>
        public OrdApPathgySampDO[] insert(OrdApPathgySampDO[] aggdos)
        {
            List<object> param = new List<object>();
            param.Add(aggdos);
            si.url = url;
            OrdApPathgySampDO[] rtn = si.invokeList<OrdApPathgySampDO>("insert", param.ToArray());
            return rtn;
        }

        /// <summary>
        /// 病理申请单AggDO数据保存
        /// </summary>
        /// <param name="aggdos"></param>
        /// <returns></returns>
        public OrdApPathgySampDO[] save(OrdApPathgySampDO[] aggdos)
        {
            List<object> param = new List<object>();
            param.Add(aggdos);
            si.url = url;
            OrdApPathgySampDO[] rtn = si.invokeList<OrdApPathgySampDO>("save", param.ToArray());
            return rtn;
        }

        /// <summary>
        /// 病理申请单AggDO数据更新
        /// </summary>
        /// <param name="aggdos"></param>
        /// <returns></returns>
        public OrdApPathgySampDO[] update(OrdApPathgySampDO[] aggdos)
        {
            List<object> param = new List<object>();
            param.Add(aggdos);
            si.url = url;
            OrdApPathgySampDO[] rtn = si.invokeList<OrdApPathgySampDO>("update", param.ToArray());
            return rtn;
        }

        /// <summary>
        /// 病理申请单AggDO数据逻辑删除
        /// </summary>
        /// <param name="aggdos"></param>
        public void logicDelete(OrdApPathgySampDO[] aggdos)
        {
            List<object> param = new List<object>();
            param.Add(aggdos);
            si.url = url;
            si.invokeList<OrdApPathgySampDO>("logicDelete", param.ToArray());  
        }

        /// <summary>
        /// 根据id值查找病理申请单AggDO数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public OrdApPathgySampDO findById(String id)
        {
        	#region "缓存处理"
        	if (ch.IsCached("findById"))
            {
                return ch.findById(id);
            }
            #endregion
            List<object> param = new List<object>();
            param.Add(id);
            si.url = url_r;
            OrdApPathgySampDO rtn = si.invoke<OrdApPathgySampDO>("findById", param.ToArray());
            return rtn;
        }

        /// <summary>
        /// 根据id值集合查找病理申请单AggDO数据集合
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="isLazy"></param>
        /// <returns></returns>
        public OrdApPathgySampDO[] findByIds(String[] ids, FBoolean isLazy)
        {
        	#region "缓存处理"
         	if (ch.IsCached("findByIds"))
            {
                return ch.findByIds(ids, isLazy);
            }
            #endregion
            List<object> param = new List<object>();
            param.Add(ids);
            param.Add(isLazy);
            si.url = url_r;
            OrdApPathgySampDO[] rtn = si.invokeList<OrdApPathgySampDO>("findByIds", param.ToArray());
            return rtn;
        }

        /// <summary>
        /// 根据id值集合查找病理申请单AggDO数据集合--大数据量
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="isLazy"></param>
        /// <returns></returns>
        public OrdApPathgySampDO[] findByBIds(String[] ids, FBoolean isLazy)
        {
        	#region "缓存处理"
        	if (ch.IsCached("findByBIds"))
            {
                return ch.findByBIds(ids, isLazy);
            }
            #endregion
            List<object> param = new List<object>();
            param.Add(ids);
            param.Add(isLazy);
            si.url = url_r;
            OrdApPathgySampDO[] rtn = si.invokeList<OrdApPathgySampDO>("findByBIds", param.ToArray());
            return rtn;
        }

        /// <summary>
        /// 根据condition条件查找病理申请单AggDO数据集合
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="isLazy"></param>
        /// <returns></returns>
        public OrdApPathgySampDO[] find(String condition, string orderStr, FBoolean isLazy)
        {
        	#region "缓存处理"
        	if (ch.IsCached("find"))
            {
                return ch.find(condition, orderStr, isLazy);
            }
            #endregion
            List<object> param = new List<object>();
            param.Add(condition);
            param.Add(orderStr);
            param.Add(isLazy);
            si.url = url_r;
            OrdApPathgySampDO[] rtn = si.invokeList<OrdApPathgySampDO>("find", param.ToArray());
            return rtn;
        }
        
        /// <summary>
        /// 根据condition条件及管控查找病理申请单数据集合
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="isLazy"></param>
        /// <returns></returns>
        public OrdApPathgySampDO[] findByBDMode(String condition, string orderStr, FBoolean isLazy)
        {
        	#region "缓存处理"
        	if (ch.IsCached("find"))
            {
                return ch.find(condition, orderStr, isLazy);
            }
            #endregion
            List<object> param = new List<object>();
            param.Add(condition);
            param.Add(orderStr);
            param.Add(isLazy);
            si.url = url_r;
            OrdApPathgySampDO[] rtn = si.invokeList<OrdApPathgySampDO>("findByBDMode", param.ToArray());
            return rtn;
        }

        /// <summary>
        /// 根据查询方案查找病理申请单AggDO数据集合
        /// </summary>
        /// <param name="qscheme"></param>
        /// <returns></returns>
        public OrdApPathgySampDO[] findByQScheme(IQryScheme qscheme)
        {
        	#region "缓存处理"
        	if (ch.IsCached("findByQScheme"))
            {
                return ch.findByQScheme(qscheme);
            }
            #endregion
            List<object> param = new List<object>();
            param.Add(qscheme);
            si.url = url_r;
            OrdApPathgySampDO[] rtn = si.invokeList<OrdApPathgySampDO>("findByQScheme", param.ToArray());
            return rtn;
        }

	 	/// <summary>
        /// 根据分页信息及查询与分组条件获得分页数据
        /// </summary>
        /// <param name="pg"></param>
		/// <param name="wherePart"></param>
		/// <param name="orderByPart"></param>
        /// <returns>PagingRtnData</returns>
        public PagingRtnData<OrdApPathgySampDO> findByPageInfo(PaginationInfo pg, String wherePart,String orderByPart)
        {
            List<object> param = new List<object>();
	    	param.Add(pg);
	    	param.Add(wherePart);
	   		param.Add(orderByPart);
            si.url = url_r;
            PagingRtnData<OrdApPathgySampDO> rtn = si.invokePaging<OrdApPathgySampDO>("findByPageInfo", param.ToArray());
            return rtn;
        }
        
        /// <summary>
        /// 根据分页信息、查询与分组条件及管控获得分页数据
        /// </summary>
        /// <param name="pg"></param>
		/// <param name="wherePart"></param>
		/// <param name="orderByPart"></param>
        /// <returns>PagingRtnData</returns>
        public PagingRtnData<OrdApPathgySampDO> findByPageInfoAndBDMode(PaginationInfo pg, String wherePart,String orderByPart)
        {
            List<object> param = new List<object>();
	    	param.Add(pg);
	    	param.Add(wherePart);
	   		param.Add(orderByPart);
            si.url = url_r;
            PagingRtnData<OrdApPathgySampDO> rtn = si.invokePaging<OrdApPathgySampDO>("findByPageInfoAndBDMode", param.ToArray());
            return rtn;
        }
        
        /// <summary>
        /// 批量启用：全部都启用；或者出现异常，启用全部失败
        /// </summary>
        /// <param name="dos"></param>
	    public OrdApPathgySampDO[] enableWithoutFilter(OrdApPathgySampDO[] dos)
	    {
	        List<object> param = new List<object>();
	        param.Add(dos);
	        si.url = url;
	        OrdApPathgySampDO[] rtn = si.invokeList<OrdApPathgySampDO>("enableWithoutFilter", param.ToArray());
	        return rtn;
	    }
	    
	    /// <summary>
        /// 批量启用：可部分启用成功；
        /// 启用成功的记录可通过返回值的getDos方法得到，启用不成功的记录附加日志可通过返回值的getErrLogList方法得到
        /// </summary>
        /// <param name="dos"></param>
	    public DOWithErrLog enableDO(OrdApPathgySampDO[] dos) 
	    {
	        List<object> param = new List<object>();
	        param.Add(dos);
	        si.url = url;
	        DOWithErrLog rtn = si.invoke<DOWithErrLog>("enableDO", param.ToArray());
	        return rtn;
	    }
	    
	    /// <summary>
        /// 批量停用：要不全部都停用；或者出现异常，停用全部失败
        /// </summary>
        /// <param name="dos"></param>
	    public OrdApPathgySampDO[] disableVOWithoutFilter(OrdApPathgySampDO[] dos) 
	    {
	        List<object> param = new List<object>();
	        param.Add(dos);
	        si.url = url;
	        OrdApPathgySampDO[] rtn = si.invokeList<OrdApPathgySampDO>("disableVOWithoutFilter", param.ToArray());
	        return rtn;
	    }
	    
	    /// <summary>
        /// 批量停用：可部分停用成功；
        /// 停用成功的记录可通过返回值的getDos方法得到，停用不成功的记录附加日志可通过返回值的getErrLogList方法得到
        /// </summary>
        /// <param name="dos"></param>
	    public DOWithErrLog disableDO(OrdApPathgySampDO[] dos) 
	    {
	        List<object> param = new List<object>();
	        param.Add(dos);
	        si.url = url;
	        DOWithErrLog rtn = si.invoke<DOWithErrLog>("disableDO", param.ToArray());
	        return rtn;
	    }
        
        /// <summary>
        /// 根据查询方案查询聚合数据集合
        /// </summary>
        /// <param name="qryRootNodeDTO"></param>
        /// <param name="orderStr"></param>
        /// <param name="isLazy"></param>
        public OrdApPathgySampDO[] findByQCond(QryRootNodeDTO qryRootNodeDTO,String orderStr,FBoolean isLazy)
        {
            List<object> param = new List<object>();
            param.Add(qryRootNodeDTO);
            param.Add(orderStr);
            param.Add(isLazy);
            si.url = url_r;
            OrdApPathgySampDO[] rtn = si.invokeList<OrdApPathgySampDO>("findByQCond", param.ToArray());
            return rtn;
        }
        
        /// <summary>
        /// 根据DO某一字符类型属性值查询DO数据
        /// <summary>
        /// <param name="attr"></param>
        /// <param name="value"></param>
        /// <returns>OrdApPathgySampDO[]</return>
        public OrdApPathgySampDO[] findByAttrValString(string attr, string value)
        {
            List<object> param = new List<object>();
            param.Add(attr);
            param.Add(value);
            si.url=url_r;
            OrdApPathgySampDO[] rtn = si.invokeList<OrdApPathgySampDO>("findByAttrValString", param.ToArray());
            return rtn;
        }
        
        /// <summary>
        /// 根据DO某一字符类型属性值数组查询DO数据
        /// <summary>
        /// <param name="attr"></param>
        /// <param name="values"></param>
        /// <returns>OrdApPathgySampDO[]</return>
        public OrdApPathgySampDO[] findByAttrValStrings(string attr, string[] values)
        {
            List<object> param = new List<object>();
            param.Add(attr);
            param.Add(values);
            si.url=url_r;
            OrdApPathgySampDO[] rtn = si.invokeList<OrdApPathgySampDO>("findByAttrValStrings", param.ToArray());
            return rtn;
        }
        
        /// <summary>
        /// 根据DO某一属性值List查询DO数据
        /// <summary>
        /// <param name="attr"></param>
        /// <param name="values"></param>
        /// <returns>OrdApPathgySampDO[]</return>
        public OrdApPathgySampDO[] findByAttrValList(string attr, FArrayList values)
        {
            List<object> param = new List<object>();
            param.Add(attr);
            param.Add(values);
            si.url=url_r;
            OrdApPathgySampDO[] rtn = si.invokeList<OrdApPathgySampDO>("findByAttrValList", param.ToArray());
            return rtn;
        }
        
        /// <summary>
        /// 根据查询模板条件、分页信息查询分页数据集合
        /// </summary>
        /// <param name="qryRootNodeDTO"></param>
        /// <param name="orderStr"></param>
        /// <param name="pg"></param>
        public PagingRtnData<OrdApPathgySampDO> findByQCondAndPageInfo(QryRootNodeDTO qryRootNodeDTO,String orderStr,PaginationInfo pg)
        {
            List<object> param = new List<object>();
        	param.Add(qryRootNodeDTO);
        	param.Add(orderStr);
        	param.Add(pg);
        	si.url = url_r;
        	PagingRtnData<OrdApPathgySampDO> rtn = si.invokePaging<OrdApPathgySampDO>("findByQCondAndPageInfo", param.ToArray());
        	return rtn;
        }
    }
}
package iih.ci.ord.cior.i;

import xap.sys.appfw.tmpl.qryscheme.IQryScheme;
import xap.mw.core.data.BizException;
import xap.mw.coreitf.d.*;
import xap.mw.core.data.*;
import xap.sys.appfw.orm.handle.dataobject.paging.PaginationInfo;
import xap.sys.appfw.orm.handle.dataobject.paging.PagingRtnData;
import iih.ci.ord.cior.d.OrdApPathgySampDO;
import xap.sys.appfw.tmpl.qryscheme.qrydto.QryRootNodeDTO;

/**
* 病理申请单数据维护服务
*/
public interface IOrdApPathgySampDORService {
	/**
	*  根据id值查找病理申请单数据
	*/	
	public abstract OrdApPathgySampDO findById(String id) throws BizException;
	
	/**
	*  根据id值集合查找病理申请单数据集合
	*/	
	public abstract OrdApPathgySampDO[] findByIds(String[] ids, FBoolean isLazy) throws BizException;
	
	/**
	*  根据id值集合查找病理申请单数据集合--大数据量
	*/	
	public abstract OrdApPathgySampDO[] findByBIds(String[] ids, FBoolean isLazy) throws BizException;	
    
    /**
	*  根据condition条件查找病理申请单数据集合
	*/	
	public abstract OrdApPathgySampDO[] find(String whereStr,String orderStr,FBoolean isLazy) throws BizException;
	
//	/**
//	 * 根据condition条件及管控查找病理申请单数据集合
//	 */
//	public abstract OrdApPathgySampDO[] findByBDMode(String whereStr,String orderStr,FBoolean isLazy) throws BizException;
	/**
	*  根据查询方案查找病理申请单数据集合
	*/	
	public abstract OrdApPathgySampDO[] findByQScheme(IQryScheme qscheme) throws BizException;//暂不用
	
	/**
	*  根据分页信息及查询与分组条件获得分页数据
	*/
	public abstract PagingRtnData<OrdApPathgySampDO> findByPageInfo(PaginationInfo pg, String wherePart,String orderByPart) throws BizException;
	
	/**
	 * 根据分页信息、查询与分组条件及管控获得分页数据
	 */
//	public abstract PagingRtnData<OrdApPathgySampDO> findByPageInfoAndBDMode(PaginationInfo pg, String whereStr,String orderStr) throws BizException;
	
	/**
	 * 根据查询方案查询聚合数据集合
	 * @param qscheme
	 * @return
	 * @throws BizException
	 */
	public OrdApPathgySampDO[] findByQCond(QryRootNodeDTO qryRootNodeDTO,String orderStr,FBoolean isLazy) throws BizException;
	
	/**
	 * 根据DO某一字符类型属性值查询DO数据
	 * @param attr
	 * @param value
	 * @return
	 * @throws BizException
	 */
	public abstract OrdApPathgySampDO[] findByAttrValString(String attr, String value) throws BizException;
	
	/**
	 * 根据DO某一字符类型属性值数组查询DO数据
	 * @param attr
	 * @param values
	 * @return
	 * @throws BizException
	 */
	public abstract OrdApPathgySampDO[] findByAttrValStrings(String attr, String[] values) throws BizException;
	
	/**
	 * 根据DO某一属性值List查询DO数据
	 * @param attr
	 * @param values
	 * @return
	 * @throws BizException
	 */
	public abstract OrdApPathgySampDO[] findByAttrValList(String attr, FArrayList values) throws BizException;
	
	/**
	 * 根据查询模板条件、分页信息查询分页数据集合
	 * @param qryRootNodeDTO
	 * @param orderStr
	 * @param pg
	 * @return
	 * @throws BizException
	 */
	public PagingRtnData<OrdApPathgySampDO> findByQCondAndPageInfo(QryRootNodeDTO qryRootNodeDTO,String orderStr,PaginationInfo pg) throws BizException;
}
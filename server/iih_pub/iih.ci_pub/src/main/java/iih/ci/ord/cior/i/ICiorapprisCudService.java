package iih.ci.ord.cior.i;

import xap.mw.core.data.BizException;
import iih.ci.ord.cior.d.OrdApObsDO;
import xap.sys.appfw.orm.handle.dataobject.errlog.DOWithErrLog;

/**
* 医嘱检查申请单数据维护服务
*/
public interface ICiorapprisCudService {
	/**
	*  医嘱检查申请单数据真删除
	*/
    public abstract void delete(OrdApObsDO[] aggdos) throws BizException;
    
    /**
	*  医嘱检查申请单数据插入保存
	*/
	public abstract OrdApObsDO[] insert(OrdApObsDO[] aggdos) throws BizException;
	
    /**
	*  医嘱检查申请单数据保存
	*/
	public abstract OrdApObsDO[] save(OrdApObsDO[] aggdos) throws BizException;
	
    /**
	*  医嘱检查申请单数据更新
	*/
	public abstract OrdApObsDO[] update(OrdApObsDO[] aggdos) throws BizException;
	
	/**
	*  医嘱检查申请单数据逻辑删除
	*/
	public abstract void logicDelete(OrdApObsDO[] aggdos) throws BizException;

	/**
	 * 批量启用：全部都启用；或者出现异常，启用全部失败
	 */
	public OrdApObsDO[] enableWithoutFilter(OrdApObsDO[] dos) throws BizException ;

	/**
	 * 批量启用：可部分启用成功；
	 * 启用成功的记录可通过返回值的getDos方法得到，启用不成功的记录附加日志可通过返回值的getErrLogList方法得到
	 */
	public DOWithErrLog enableDO(OrdApObsDO[] dos) throws BizException ;

	/**
	 * 批量停用：要不全部都停用；或者出现异常，停用全部失败
	 */
	public OrdApObsDO[] disableVOWithoutFilter(OrdApObsDO[] dos) throws BizException;


	/**
	 * 批量停用：可部分停用成功；
	 * 停用成功的记录可通过返回值的getDos方法得到，停用不成功的记录附加日志可通过返回值的getErrLogList方法得到
	 */
	public DOWithErrLog disableDO(OrdApObsDO[] dos) throws BizException ;
}

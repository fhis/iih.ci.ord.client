package iih.ci.ord.i.cfg.rulecfg;

import iih.bd.srv.medsrv.d.MedSrvDO;

/**
 * 校验
 * @author HUMS
 *
 */
public interface ICiValidatorChainService {

	/**
	 * 校验bd_srv服务是否可用
	 * @param checkPoint
	 * @param medSrv
	 */
	public void validateMedSrv(Integer checkPoint, MedSrvDO medSrv);
	
	/**
	 * 根据服务类型校验
	 * @param checkPoint
	 * @param sdSrvtp
	 */
	public boolean  validateBySdSrvtp(Integer checkPoint,String sdSrvtp);
	
	/**
	 * 根据医疗单id获取校验链
	 * @param id_srvof
	 */
	public boolean validatorChainByEmsId(String id_srvof);
	
	/**
	 * 根据服务id获取校验链
	 * @param id_srv
	 */
	public boolean validatorByIdSrv(String id_srv);
	
}

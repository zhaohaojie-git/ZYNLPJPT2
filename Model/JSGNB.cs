﻿/**  版本信息模板在安装目录下，可自行修改。
* JSGNB.cs
*
* 功 能： N/A
* 类 名： JSGNB
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/3/31 16:02:13   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// JSGNB:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class JSGNB
	{
		public JSGNB()
		{}
		#region Model
		private int _jsbh;
		private int _gnbh;
		/// <summary>
		/// 
		/// </summary>
		public int JSBH
		{
			set{ _jsbh=value;}
			get{return _jsbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int GNBH
		{
			set{ _gnbh=value;}
			get{return _gnbh;}
		}
		#endregion Model

	}
}


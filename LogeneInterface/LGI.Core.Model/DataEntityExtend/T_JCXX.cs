﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace LGI.Core.Model
{
    [MetadataType(typeof (T_JCXX_MeteData))]
    public partial class T_JCXX
    {
        public List<T_LGI_WJZ> ListWjz { get; set; }
    }

    public class T_JCXX_MeteData
    {
        [Display(Name = "病理库")] public string F_BLK;
        [Display(Name = "病理号")] public string F_BLH;
        [Display(Name = "病人编号")] public string F_BRBH;
        [Display(Name = "申请序号")] public string F_SQXH;
        [Display(Name = "医嘱ID")] public string F_YZID;
        [Display(Name = "")] public string F_YZXM;
        [Display(Name = "")] public string F_STUDY_UID;
        [Display(Name = "姓名")] public string F_XM;
        [Display(Name = "性别")] public string F_XB;
        [Display(Name = "年龄")] public string F_NL;
        [Display(Name = "年龄2")] public Nullable<double> F_AGE;
        [Display(Name = "")] public string F_HY;
        [Display(Name = "")] public string F_MZ;
        [Display(Name = "")] public string F_ZY;
        [Display(Name = "")] public string F_SFZH;
        [Display(Name = "")] public string F_LXXX;
        [Display(Name = "病人类别")] public string F_BRLB;
        [Display(Name = "")] public string F_FB;
        [Display(Name = "住院号")] public string F_ZYH;
        [Display(Name = "门诊号")] public string F_MZH;
        [Display(Name = "病区")] public string F_BQ;
        [Display(Name = "送检科室")] public string F_SJKS;
        [Display(Name = "床号")] public string F_CH;
        [Display(Name = "送检单位")] public string F_SJDW;
        [Display(Name = "送检医生")] public string F_SJYS;
        [Display(Name = "收到日期")] public string F_SDRQ;
        [Display(Name = "")] public string F_JSY;
        [Display(Name = "标本类型")] public string F_BBLX;
        [Display(Name = "")] public string F_BBQK;
        [Display(Name = "")] public string F_JSYY;
        [Display(Name = "")] public Nullable<double> F_SF;
        [Display(Name = "标本名称")] public string F_BBMC;
        [Display(Name = "临床诊断")] public string F_LCZD;
        [Display(Name = "")] public string F_LCZL;
        [Display(Name = "入院时间")] public string F_RYSJ;
        [Display(Name = "取材医生")] public string F_QCYS;
        [Display(Name = "取材日期")] public string F_QCRQ;
        [Display(Name = "")] public string F_JLY;
        [Display(Name = "")] public Nullable<int> F_LKZS;
        [Display(Name = "")] public Nullable<int> F_CKZS;
        [Display(Name = "")] public string F_FY;
        [Display(Name = "")] public string F_JXSJ;
        [Display(Name = "病理诊断")] public string F_BLZD;
        [Display(Name = "")] public string F_TSJC;
        [Display(Name = "报告医生")] public string F_BGYS;
        [Display(Name = "审核医生")] public string F_SHYS;
        [Display(Name = "报告日期")] public string F_BGRQ;
        [Display(Name = "")] public string F_CZYJ;
        [Display(Name = "")] public string F_XGYJ;
        [Display(Name = "")] public string F_ZDGJC;
        [Display(Name = "阴阳性")] public string F_YYX;
        [Display(Name = "")] public string F_WFBGYY;
        [Display(Name = "")] public string F_BZ;
        [Display(Name = "")] public string F_BD_SFFH;
        [Display(Name = "报告状态")] public string F_BGZT;
        [Display(Name = "")] public string F_SFCT;
        [Display(Name = "是否打印")] public string F_SFDY;
        [Display(Name = "")] public string F_BGGS;
        [Display(Name = "")] public string F_GDZT;
        [Display(Name = "")] public Nullable<int> F_KNHZ;
        [Display(Name = "")] public string F_ZJYJ;
        [Display(Name = "")] public string F_WYYJ;
        [Display(Name = "")] public Nullable<int> F_SFZT;
        [Display(Name = "")] public string F_SFJG;
        [Display(Name = "")] public string F_JBBM_CN;
        [Display(Name = "")] public string F_JBBM_ENG;
        [Display(Name = "")] public string F_JBMC;
        [Display(Name = "")] public string F_YBLH;
        [Display(Name = "")] public string F_SJCL;
        [Display(Name = "")] public string F_YBLZD;
        [Display(Name = "")] public string F_BGFSFS;
        [Display(Name = "")] public string F_SCYS;
        [Display(Name = "")] public string F_SFFH;
        [Display(Name = "")] public string F_SPARE1;
        [Display(Name = "")] public string F_SPARE2;
        [Display(Name = "")] public string F_SPARE3;
        [Display(Name = "")] public string F_SPARE4;
        [Display(Name = "审核时间")] public string F_SPARE5;
        [Display(Name = "")] public string F_SPARE6;
        [Display(Name = "")] public string F_SPARE7;
        [Display(Name = "")] public string F_SPARE8;
        [Display(Name = "")] public string F_SPARE9;
        [Display(Name = "")] public string F_SPARE10;
        [Display(Name = "")] public string F_BY1;
        [Display(Name = "")] public string F_BY2;
        [Display(Name = "")] public string F_TXML;
        [Display(Name = "")] public string F_ZPZT;
        [Display(Name = "")] public string F_MCYJ;
        [Display(Name = "")] public string F_SFJJ;
        [Display(Name = "")] public Nullable<int> F_TBSID;
        [Display(Name = "")] public string F_TBSMC;
        [Display(Name = "")] public string F_QSB_DYZT;
        [Display(Name = "")] public string F_BGWZ;
        [Display(Name = "")] public string F_BGWZ_QRSJ;
        [Display(Name = "")] public string F_BGWZ_QRCZY;
        [Display(Name = "")] public string F_BBWZ;
        [Display(Name = "")] public string F_LKWZ;
        [Display(Name = "")] public string F_QPWZ;
        [Display(Name = "")] public string F_GDCZY;
        [Display(Name = "")] public string F_GDSJ;
        [Display(Name = "")] public string F_GDBZ;
        [Display(Name = "")] public string F_BGLRY;
        [Display(Name = "")] public string F_FZYS;
        [Display(Name = "")] public string F_YL1;
        [Display(Name = "")] public string F_YL2;
        [Display(Name = "")] public string F_YL3;
        [Display(Name = "")] public string F_YL4;
        [Display(Name = "")] public string F_YL5;
        [Display(Name = "")] public string F_YL6;
        [Display(Name = "")] public string F_YL7;
        [Display(Name = "")] public string F_YL8;
        [Display(Name = "")] public string F_YL9;
        [Display(Name = "")] public string F_YL10;
        [Display(Name = "")] public string F_ICD10_BM1;
        [Display(Name = "")] public string F_ICD10_MC1;
        [Display(Name = "")] public string F_BL1;
        [Display(Name = "")] public string F_BL2;
        [Display(Name = "")] public string F_BL3;
        [Display(Name = "")] public string F_BL4;
        [Display(Name = "")] public string F_BL5;
        [Display(Name = "")] public string F_BL6;
        [Display(Name = "")] public string F_BL7;
        [Display(Name = "")] public string F_BL8;
        [Display(Name = "")] public string F_BL9;
        [Display(Name = "")] public string F_BL10;
        [Display(Name = "")] public string F_ICD10_BM2;
        [Display(Name = "")] public string F_ICD10_MC2;
        [Display(Name = "")] public string F_FBSJ;
        [Display(Name = "")] public string F_FBYS;
    }
}
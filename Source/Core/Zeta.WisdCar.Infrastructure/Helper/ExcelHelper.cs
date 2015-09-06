using System;
using System.Diagnostics;
using System.Collections;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Excel;

namespace Zeta.WisdCar.Infrastructure.Helper
{
    public class ExcelHelper
    {
        public ExcelHelper()
        {
        }

        #region 操作EXCEL的一个类(需要Excel.dll支持)

        private int titleColorindex = 15;
        /// <summary>
        /// 标题背景色
        /// </summary>
        public int TitleColorIndex
        {
            set { titleColorindex = value; }
            get { return titleColorindex; }
        }

        private DateTime beforeTime;			//Excel启动之前时间
        private DateTime afterTime;				//Excel启动之后时间

        #region 创建一个Excel示例
        /// <summary>
        /// 创建一个Excel示例
        /// </summary>
        public void CreateExcel()
        {
            Excel.Application excel = new Excel.Application();
            excel.Application.Workbooks.Add(true);
            excel.Cells[1, 1] = "第1行第1列";
            excel.Cells[1, 2] = "第1行第2列";
            excel.Cells[2, 1] = "第2行第1列";
            excel.Cells[2, 2] = "第2行第2列";
            excel.Cells[3, 1] = "第3行第1列";
            excel.Cells[3, 2] = "第3行第2列";

            //保存
            excel.ActiveWorkbook.SaveAs("./tt.xls", XlFileFormat.xlExcel9795, null, null, false, false, Excel.XlSaveAsAccessMode.xlNoChange, null, null, null, null, null);
            //打开显示
            excel.Visible = true;
            //			excel.Quit();
            //			excel=null;            
            //			GC.Collect();//垃圾回收
        }
        #endregion

        #region Kill Excel进程

        /// <summary>
        /// 结束Excel进程
        /// </summary>
        public void KillExcelProcess()
        {
            Process[] myProcesses;
            DateTime startTime;
            myProcesses = Process.GetProcessesByName("Excel");

            //得不到Excel进程ID，暂时只能判断进程启动时间
            foreach (Process myProcess in myProcesses)
            {
                startTime = myProcess.StartTime;
                if (startTime > beforeTime && startTime < afterTime)
                {
                    myProcess.Kill();
                }
            }
        }
        #endregion

        #endregion

        #region 将DataTable的数据导出显示为报表(不使用Excel对象，使用COM.Excel)

        #region 使用示例
        /*使用示例：
		 * DataSet ds=(DataSet)Session["AdBrowseHitDayList"];
			string ExcelFolder=Assistant.GetConfigString("ExcelFolder");
			string FilePath=Server.MapPath(".")+"\\"+ExcelFolder+"\\";
			
			//生成列的中文对应表
			Hashtable nameList = new Hashtable();
			nameList.Add("ADID", "广告编码");
			nameList.Add("ADName", "广告名称");
			nameList.Add("year", "年");
			nameList.Add("month", "月");
			nameList.Add("browsum", "显示数");
			nameList.Add("hitsum", "点击数");
			nameList.Add("BrowsinglIP", "独立IP显示");
			nameList.Add("HitsinglIP", "独立IP点击");
			//利用excel对象
			DataToExcel dte=new DataToExcel();
			string filename="";
			try
			{			
				if(ds.Tables[0].Rows.Count>0)
				{
					filename=dte.DataExcel(ds.Tables[0],"标题",FilePath,nameList);
				}
			}
			catch
			{
				//dte.KillExcelProcess();
			}
			
			if(filename!="")
			{
				Response.Redirect(ExcelFolder+"\\"+filename,true);
			}
		 * 
		 * */

        #endregion

        /// <summary>
        /// 将DataTable的数据导出显示为报表(不使用Excel对象)
        /// </summary>
        /// <param name="dt">数据DataTable</param>
        /// <param name="strTitle">标题</param>
        /// <param name="FilePath">生成文件的路径</param>
        /// <param name="nameList"></param>
        /// <returns></returns>
        public string DataExcel(System.Data.DataTable dt, string strTitle, string FilePath, Hashtable nameList)
        {
            COM.Excel.cExcelFile excel = new COM.Excel.cExcelFile();
            ClearFile(FilePath);
            string filename = DateTime.Now.ToString("yyyyMMddHHmmssff") + ".xls";
            excel.CreateFile(FilePath + filename);
            excel.PrintGridLines = false;

            COM.Excel.cExcelFile.MarginTypes mt1 = COM.Excel.cExcelFile.MarginTypes.xlsTopMargin;
            COM.Excel.cExcelFile.MarginTypes mt2 = COM.Excel.cExcelFile.MarginTypes.xlsLeftMargin;
            COM.Excel.cExcelFile.MarginTypes mt3 = COM.Excel.cExcelFile.MarginTypes.xlsRightMargin;
            COM.Excel.cExcelFile.MarginTypes mt4 = COM.Excel.cExcelFile.MarginTypes.xlsBottomMargin;

            double height = 1.5;
            excel.SetMargin(ref mt1, ref height);
            excel.SetMargin(ref mt2, ref height);
            excel.SetMargin(ref mt3, ref height);
            excel.SetMargin(ref mt4, ref height);

            COM.Excel.cExcelFile.FontFormatting ff = COM.Excel.cExcelFile.FontFormatting.xlsNoFormat;
            string font = "宋体";
            short fontsize = 9;
            excel.SetFont(ref font, ref fontsize, ref ff);

            byte b1 = 1,
                b2 = 12;
            short s3 = 12;
            excel.SetColumnWidth(ref b1, ref b2, ref s3);

            string header = "页眉";
            string footer = "页脚";
            excel.SetHeader(ref header);
            excel.SetFooter(ref footer);


            COM.Excel.cExcelFile.ValueTypes vt = COM.Excel.cExcelFile.ValueTypes.xlsText;
            COM.Excel.cExcelFile.CellFont cf = COM.Excel.cExcelFile.CellFont.xlsFont0;
            COM.Excel.cExcelFile.CellAlignment ca = COM.Excel.cExcelFile.CellAlignment.xlsCentreAlign;
            COM.Excel.cExcelFile.CellHiddenLocked chl = COM.Excel.cExcelFile.CellHiddenLocked.xlsNormal;

            // 报表标题
            int cellformat = 1;
            //			int rowindex = 1,colindex = 3;					
            //			object title = (object)strTitle;
            //			excel.WriteValue(ref vt, ref cf, ref ca, ref chl,ref rowindex,ref colindex,ref title,ref cellformat);

            int rowIndex = 1;//起始行
            int colIndex = 0;



            //取得列标题				
            foreach (DataColumn colhead in dt.Columns)
            {
                colIndex++;
                string name = colhead.ColumnName.Trim();
                object namestr = (object)name;
                IDictionaryEnumerator Enum = nameList.GetEnumerator();
                while (Enum.MoveNext())
                {
                    if (Enum.Key.ToString().Trim() == name)
                    {
                        namestr = Enum.Value;
                    }
                }
                excel.WriteValue(ref vt, ref cf, ref ca, ref chl, ref rowIndex, ref colIndex, ref namestr, ref cellformat);
            }

            //取得表格中的数据			
            foreach (DataRow row in dt.Rows)
            {
                rowIndex++;
                colIndex = 0;
                foreach (DataColumn col in dt.Columns)
                {
                    colIndex++;
                    if (col.DataType == System.Type.GetType("System.DateTime"))
                    {
                        object str = (object)(Convert.ToDateTime(row[col.ColumnName].ToString())).ToString("yyyy-MM-dd"); ;
                        excel.WriteValue(ref vt, ref cf, ref ca, ref chl, ref rowIndex, ref colIndex, ref str, ref cellformat);
                    }
                    else
                    {
                        object str = (object)row[col.ColumnName].ToString();
                        excel.WriteValue(ref vt, ref cf, ref ca, ref chl, ref rowIndex, ref colIndex, ref str, ref cellformat);
                    }
                }
            }
            int ret = excel.CloseFile();

            //			if(ret!=0)
            //			{
            //				//MessageBox.Show(this,"Error!");
            //			}
            //			else
            //			{
            //				//MessageBox.Show(this,"请打开文件c:\\test.xls!");
            //			}
            return filename;

        }

        #endregion

        #region  清理过时的Excel文件

        private void ClearFile(string FilePath)
        {
            String[] Files = System.IO.Directory.GetFiles(FilePath);
            if (Files.Length > 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    try
                    {
                        System.IO.File.Delete(Files[i]);
                    }
                    catch
                    {
                    }

                }
            }
        }
        #endregion

    }
}

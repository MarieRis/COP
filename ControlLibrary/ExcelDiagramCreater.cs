using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Document.NET;
using  Microsoft.Office.Interop.Excel;
using XL = Microsoft.Office.Interop.Excel;

namespace ControlLibrary
{
    public partial class ExcelDiagramCreater : Component
    {
        private void btnXL_Click(object sender, EventArgs e)
        {
            XL.Application XL1 = new XL.Application(); // Объявляем объект
            XL1.Workbooks.Add(); // Добавляем рабочую книгу

            // Заполнить ячейки A2 (со 2 по 6)
            XL1.ActiveSheet.Range["A2"].Value = "продукт 1";
            XL1.ActiveSheet.Range["A3"].Value = "продукт 2";
            XL1.ActiveSheet.Range["A4"].Value = "продукт 3";
            XL1.ActiveSheet.Range["A5"].Value = "продукт 4";
            XL1.ActiveSheet.Range["A6"].Value = "продукт 5";

            // Заполнить ячейки B2 (со 2 по 6)
            XL1.ActiveSheet.Range["B2"].Value = 15;
            XL1.ActiveSheet.Range["B3"].Value = 22;
            XL1.ActiveSheet.Range["B4"].Value = 56;
            XL1.ActiveSheet.Range["B5"].Value = 28;
            XL1.ActiveSheet.Range["B6"].Value = 50;

            // Добавить новую диаграмму
            XL1.Charts.Add();

            // Задаем тип графика - столбчатая диаграммма
            XL1.ActiveChart.ChartType = XL.XlChartType.xlColumnClustered;
            // Отключаем легенду и задаем имя диаграммы
            XL1.ActiveChart.HasLegend = false;
            XL1.ActiveChart.HasTitle = true; // ВОЗНИКАЕТ Исключение из HRESULT: 0x800A03EC
            XL1.ActiveChart.ChartTitle.Characters.Text = "сколько продуктов в каких единицах поставляются";

            // Задаем подписи по оси X
            XL1.ActiveChart.Axes(XL.XlAxisType.xlCategory).HasTitle = true;
            XL1.ActiveChart.Axes(XL.XlAxisType.xlCategory).AxisTitle.Characters.Text = "единицы";

            // Задаем подписи по оси Y
            XL1.ActiveChart.Axes(XL.XlAxisType.xlCategory).HasTitle = true;
            XL1.ActiveChart.Axes(XL.XlAxisType.xlCategory).AxisTitle.Characters.Text = "продукты";

            // Сохраняем график в растровом файле
            XL1.ActiveChart.Export("myFile.jpg");
            XL1.Visible = true;
        }
    }
}

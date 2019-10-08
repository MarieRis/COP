using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibrary
{
	public partial class ControlComboBox : UserControl
	{
		/// <summary>
		/// Порядковый номер выбранного элемента
		/// </summary>
		private int _selectedIndex;

		/// <summary>
		/// Событие выбора элемента из списка
		/// </summary>
		private event EventHandler _comboBoxSelectedElementChange;

		/// <summary>
		/// Порядковый номер выбранного элемента
		/// </summary>
		[Category("Спецификация"), Description("Порядковый номер выбранного элемента")]
		public int SelectedIndex
		{
			get { return _selectedIndex; }
			set { if (value > -2 && value < comboBox.Items.Count) { _selectedIndex = value; comboBox.SelectedIndex = _selectedIndex; } }
		}

		/// <summary>
		/// Текст выбранной записи
		/// </summary>
		[Category("Спецификация"), Description("Текст выбранной записи")]
		public string SelectedText
		{
			get { return comboBox.Text; }
		}

		public int SelectedInt
		{
			get { return (int)elems.GetValue(comboBox.SelectedIndex); }
		}

		/// <summary>
		/// Событие выбора элемента из списка
		/// </summary>
		[Category("Спецификация"), Description("Событие выбора элемента из списка")]
		public event EventHandler ComboBoxSelectedElementChange
		{
			add { _comboBoxSelectedElementChange += value; }
			remove { _comboBoxSelectedElementChange -= value; }
		}


		/// <summary>
		/// <summary>
		/// Конструктор
		/// </summary>
		public ControlComboBox()
		{
			InitializeComponent();
			comboBox.SelectedIndexChanged += (sender, e) => { _comboBoxSelectedElementChange?.Invoke(sender, e); };
		}
		
		Array elems;
		/// <summary>
		/// Заполнение списка значениями из справочника
		/// </summary>
		/// <param name="type">тип-справочник</param>
		public void LoadEnumeration(Type type)
		{
			elems = Enum.GetValues(type);
			foreach (var elem in elems)
			{
				comboBox.Items.Add(elem);
			}
		}
	}
}

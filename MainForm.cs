/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 5/29/2024
 * Time: 8:50 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace rapidDeleteACharArray
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public char[] arrayc = {'a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a'};
		public char[] thiswilldeleteall = {' '};
		void MainFormLoad(object sender, EventArgs e)
		{
			Text = "dimension is :" + arrayc.Length.ToString();
		}
		void Button1Click(object sender, EventArgs e)
		{
			arrayc = thiswilldeleteall;
			Text = "dimension is :" + arrayc.Length.ToString();
		}
		
	}
}

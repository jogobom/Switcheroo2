using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Switcheroo2
{
	public partial class Form1 : Form
	{
		[DllImport( "user32.dll" )]
		public static extern Int32 SwapMouseButton( Int32 bSwap );

		public Form1()
		{
			InitializeComponent();
		}

		private void UpdateText()
		{
			label1.Text = SystemInformation.MouseButtonsSwapped ? "Left-handed" : "Right-handed";
		}

		private void Form1_Load( object sender, EventArgs e )
		{
			UpdateText();
		}

		private void label1_MouseClick( object sender, MouseEventArgs e )
		{
			SwapMouseButton( SystemInformation.MouseButtonsSwapped ? 0 : 1 );
			UpdateText();
		}

		private void Form1_FormClosed( object sender, FormClosedEventArgs e )
		{
			SwapMouseButton( 0 );
		}
	}
}

﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EntityTool {
	static class Program {
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() {
#if MONO

#else
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmEntity());
#endif
		}
	}
}

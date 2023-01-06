using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._os_.cmd_._EXE4BAT_
{
	public class Program
	{
		static void Main(string[] args)
		{
			//read config

			var batPath = nilnul._os_.cmd_._EXE4BAT_.Properties.Settings.Default.path;

			var argument = nilnul._os_.cmd_._EXE4BAT_.Properties.Settings.Default.argument;


			Process.Start(
				new ProcessStartInfo(
					batPath, argument
				){
					UseShellExecute=true
				}
			);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace NoxMacroAlign
{
	class Macro
	{
		public Macro(string name)
		{
			this.name = name;
			this.playImage = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/play-button.png"));
			this.icon = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/edit.png"));
		}

		BitmapImage playImage;
		BitmapImage icon;
		string filename;
		string name;
		class PlaySet
		{
			string accelerator;
			string interval;
			string mode;
			string playgrounds;
			string repeatTimes;
		}
		string time;

		public BitmapImage PlayImage
		{
			get
			{
				return playImage;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
		}

		public BitmapImage Icon
		{
			get
			{
				return icon;
			}
		}
	}
}

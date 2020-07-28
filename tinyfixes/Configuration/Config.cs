﻿using System.ComponentModel;
using tinyfixes.Configuration.Implementation;

namespace tinyfixes.Configuration
{
	public class Config : Configurable<Config>
	{
		/*
            User Properties:
                - Please put all of your configurable properties here.
                - Tip: Consider using the various available attributes https://stackoverflow.com/a/15051390/11106111
        
            By default, configuration saves as "Config.json" in mod folder.    
            Need more config files/classes? See Configuration.cs
        */

		[DisplayName("Subs Fix")]
		[Description("Apply subtitle fixes.")]
		public bool SubsFix { get; set; } = true;
		
		[Description("Apply NG+ save slot fix.")]
		[DisplayName("Slot Fix")]
		public bool SlotFix { get; set; } = true;

		[Description("Apply TexWrap fix.")]
		[DisplayName("TexWrap Fix")]
		public bool TexWrapFix { get; set; } = true;
	}
}

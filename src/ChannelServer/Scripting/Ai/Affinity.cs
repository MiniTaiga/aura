﻿// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Aura.Channel.Scripting.Ai
{
	[ContentProperty("RaceId")]
	public abstract class Affinity
	{
		public string RaceId { get; set; }
	}

	public class Loves : Affinity
	{
		
	}

	public class Doubts : Affinity
	{
		
	}

	public class Hates : Affinity
	{
		
	}
}

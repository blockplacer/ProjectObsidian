﻿using System.IO;

namespace SharpMC.Network.Framework
{
	public interface IPacket : IPacket<Stream>
	{
		
	}

	public interface IPacket<in TStream> where TStream : Stream
	{
		void Encode(TStream stream);
		void Decode(TStream stream);
	}
}

﻿namespace Mono.Debugging.Soft
{
	public class SourceLinkMap
	{
		public string RelativePathWildcard { get; }
		public string UriWildcard { get; }

		public SourceLinkMap (string relativePathWildcard, string uriWildcard)
		{
			UriWildcard = uriWildcard;
			RelativePathWildcard = relativePathWildcard;
		}
	}
}

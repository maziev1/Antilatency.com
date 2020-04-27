//Generated by AntilatencyApiGenerator
using Csml;
public sealed partial class Api : Scope {
	public sealed partial class Antilatency : Scope {
		public sealed partial class DeviceNetwork : Scope {
			public sealed partial class Interop : Scope {
				public sealed partial class BigPacket : Scope {
					public static IElement NameRef => new ContentReplace(FullNameRef, $"BigPacket");
					public static MultiLanguageGroup FullNameRef => new MultiLanguageGroup("Antilatency.DeviceNetwork.Interop.BigPacket");
					private static Material FullNameRef_en => new Material("Antilatency\u200B.DeviceNetwork\u200B.Interop\u200B.BigPacket",null,$"Namespace in `{Api.Antilatency.DeviceNetwork.Interop.FullNameRef}`")[new Section("Types")
						[new UnorderedList()
							[$"*struct* `{FullBlock.NameRef}`"]
							[$"*struct* `{PartialBlock.NameRef}`"]
						]
					];
					public sealed partial class FullBlock : Scope {
						public static IElement NameRef => new ContentReplace(FullNameRef, $"FullBlock");
						public static MultiLanguageGroup FullNameRef => new MultiLanguageGroup("Antilatency.DeviceNetwork.Interop.BigPacket.FullBlock");
						private static Material FullNameRef_en => new Material("Antilatency\u200B.DeviceNetwork\u200B.Interop\u200B.BigPacket\u200B.FullBlock",null,$"Struct in `{Api.Antilatency.DeviceNetwork.Interop.BigPacket.FullNameRef}`");
					} //scope FullBlock
					
					public sealed partial class PartialBlock : Scope {
						public static IElement NameRef => new ContentReplace(FullNameRef, $"PartialBlock");
						public static MultiLanguageGroup FullNameRef => new MultiLanguageGroup("Antilatency.DeviceNetwork.Interop.BigPacket.PartialBlock");
						private static Material FullNameRef_en => new Material("Antilatency\u200B.DeviceNetwork\u200B.Interop\u200B.BigPacket\u200B.PartialBlock",null,$"Struct in `{Api.Antilatency.DeviceNetwork.Interop.BigPacket.FullNameRef}`");
					} //scope PartialBlock
					
					
				} //scope BigPacket
			} //scope Interop
		} //scope DeviceNetwork
	} //scope Antilatency
} //scope Api

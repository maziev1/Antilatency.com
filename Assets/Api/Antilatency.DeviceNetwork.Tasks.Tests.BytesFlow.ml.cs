//Generated by AntilatencyApiGenerator
using Csml;
public sealed partial class Api : Scope {
	public sealed partial class Antilatency : Scope {
		public sealed partial class DeviceNetwork : Scope {
			public sealed partial class Tasks : Scope {
				public sealed partial class Tests : Scope {
					public sealed partial class BytesFlow : Scope {
						public static IElement NameRef => new ContentReplace(FullNameRef, $"BytesFlow");
						public static MultiLanguageGroup FullNameRef => new MultiLanguageGroup("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow");
						private static Material FullNameRef_en => new Material("Antilatency\u200B.DeviceNetwork\u200B.Tasks\u200B.Tests\u200B.BytesFlow",null,$"Namespace in `{Api.Antilatency.DeviceNetwork.Tasks.Tests.FullNameRef}`")[new Section("Types")
							[new UnorderedList()
								[$"*struct* `{Settings.NameRef}`"]
								[$"*constant group* `{Constants.NameRef}`"]
								[$"*interface* `{IHostToDevice.NameRef}`"]
								[$"*interface* `{IDeviceToHost.NameRef}`"]
							]
						];
						public sealed partial class Settings : Scope {
							public static IElement NameRef => new ContentReplace(FullNameRef, $"Settings");
							public static MultiLanguageGroup FullNameRef => new MultiLanguageGroup("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.Settings");
							private static Material FullNameRef_en => new Material("Antilatency\u200B.DeviceNetwork\u200B.Tasks\u200B.Tests\u200B.BytesFlow\u200B.Settings",null,$"Struct in `{Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.FullNameRef}`");
						} //scope Settings
						
						public sealed partial class Constants : Scope {
							public static IElement NameRef => new ContentReplace(FullNameRef, $"Constants");
							public static MultiLanguageGroup FullNameRef => new MultiLanguageGroup("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.Constants");
							private static Material FullNameRef_en => new Material("Antilatency\u200B.DeviceNetwork\u200B.Tasks\u200B.Tests\u200B.BytesFlow\u200B.Constants",null,$"Constants in `{Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.FullNameRef}`");
						} //scope Constants
						
						public sealed partial class IHostToDevice : Scope {
							public static IElement NameRef => new ContentReplace(FullNameRef, $"IHostToDevice");
							public static MultiLanguageGroup FullNameRef => new MultiLanguageGroup("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IHostToDevice");
							public static IElement RawDeclarationCode => new Text($"{Interface} {NameRef} : {Type("Antilatency.InterfaceContract.IInterface")} {{\n    {settings.RawDeclarationCode}\n}}");
							private static IElement CodeBlock => CodeBlock(RawDeclarationCode);
							private static Material FullNameRef_en => new Material("Antilatency\u200B.DeviceNetwork\u200B.Tasks\u200B.Tests\u200B.BytesFlow\u200B.IHostToDevice",null,$"Interface in `{Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.FullNameRef}`")[CodeBlock];
							public sealed partial class settings : Scope {
								public static IElement NameRef => new ContentReplace(FullNameRef, $"settings");
								public static MultiLanguageGroup FullNameRef => new MultiLanguageGroup("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IHostToDevice.settings");
								public static IElement RawDeclarationCode => new Text($"{Type("void")} {NameRef}({Parameters.value.RawDeclarationCode})");
								private static Material FullNameRef_en => new Material("Antilatency\u200B.DeviceNetwork\u200B.Tasks\u200B.Tests\u200B.BytesFlow\u200B.IHostToDevice\u200B.settings",null,$"Method of `{Type(Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IHostToDevice.FullNameRef)}`\n`{Type("void")} {NameRef}({Parameters.value.RawDeclarationCode})`")
									[new Section("Parameters")]
									;
								public sealed partial class Parameters : Scope {
									public sealed partial class value : Scope {
										public static IElement RawDeclarationCode => new Text($"{Type(Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.Settings.FullNameRef)} {Name}");public static IElement Name => new Modify($"value").SetAttributeValue("title", "parameter value");
									} //scope value
								} //scope Parameters
							} //scope settings
						} //scope IHostToDevice
						
						public sealed partial class IDeviceToHost : Scope {
							public static IElement NameRef => new ContentReplace(FullNameRef, $"IDeviceToHost");
							public static MultiLanguageGroup FullNameRef => new MultiLanguageGroup("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost");
							public static IElement RawDeclarationCode => new Text($"{Interface} {NameRef} : {Type("Antilatency.InterfaceContract.IInterface")} {{\n    {byte1.RawDeclarationCode}\n    {byte2.RawDeclarationCode}\n    {byte4.RawDeclarationCode}\n    {byte8.RawDeclarationCode}\n    {byte16.RawDeclarationCode}\n    {byte32.RawDeclarationCode}\n    {byte64.RawDeclarationCode}\n    {byte128.RawDeclarationCode}\n    {byte255.RawDeclarationCode}\n}}");
							private static IElement CodeBlock => CodeBlock(RawDeclarationCode);
							private static Material FullNameRef_en => new Material("Antilatency\u200B.DeviceNetwork\u200B.Tasks\u200B.Tests\u200B.BytesFlow\u200B.IDeviceToHost",null,$"Interface in `{Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.FullNameRef}`")[CodeBlock];
							public sealed partial class byte1 : Scope {
								public static IElement NameRef => new ContentReplace(FullNameRef, $"byte1");
								public static MultiLanguageGroup FullNameRef => new MultiLanguageGroup("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.byte1");
								public static IElement RawDeclarationCode => new Text($"{Type("void")} {NameRef}({Parameters.value.RawDeclarationCode})");
								private static Material FullNameRef_en => new Material("Antilatency\u200B.DeviceNetwork\u200B.Tasks\u200B.Tests\u200B.BytesFlow\u200B.IDeviceToHost\u200B.byte1",null,$"Method of `{Type(Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.FullNameRef)}`\n`{Type("void")} {NameRef}({Parameters.value.RawDeclarationCode})`")
									[new Section("Parameters")]
									;
								public sealed partial class Parameters : Scope {
									public sealed partial class value : Scope {
										public static IElement RawDeclarationCode => new Text($"{Type("byte")} {Name}");public static IElement Name => new Modify($"value").SetAttributeValue("title", "parameter value");
									} //scope value
								} //scope Parameters
							} //scope byte1
							public sealed partial class byte2 : Scope {
								public static IElement NameRef => new ContentReplace(FullNameRef, $"byte2");
								public static MultiLanguageGroup FullNameRef => new MultiLanguageGroup("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.byte2");
								public static IElement RawDeclarationCode => new Text($"{Type("void")} {NameRef}({Parameters.value.RawDeclarationCode})");
								private static Material FullNameRef_en => new Material("Antilatency\u200B.DeviceNetwork\u200B.Tasks\u200B.Tests\u200B.BytesFlow\u200B.IDeviceToHost\u200B.byte2",null,$"Method of `{Type(Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.FullNameRef)}`\n`{Type("void")} {NameRef}({Parameters.value.RawDeclarationCode})`")
									[new Section("Parameters")]
									;
								public sealed partial class Parameters : Scope {
									public sealed partial class value : Scope {
										public static IElement RawDeclarationCode => new Text($"{Type(Api.Antilatency.DeviceNetwork.Interop.Memory.Memory2.FullNameRef)} {Name}");public static IElement Name => new Modify($"value").SetAttributeValue("title", "parameter value");
									} //scope value
								} //scope Parameters
							} //scope byte2
							public sealed partial class byte4 : Scope {
								public static IElement NameRef => new ContentReplace(FullNameRef, $"byte4");
								public static MultiLanguageGroup FullNameRef => new MultiLanguageGroup("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.byte4");
								public static IElement RawDeclarationCode => new Text($"{Type("void")} {NameRef}({Parameters.value.RawDeclarationCode})");
								private static Material FullNameRef_en => new Material("Antilatency\u200B.DeviceNetwork\u200B.Tasks\u200B.Tests\u200B.BytesFlow\u200B.IDeviceToHost\u200B.byte4",null,$"Method of `{Type(Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.FullNameRef)}`\n`{Type("void")} {NameRef}({Parameters.value.RawDeclarationCode})`")
									[new Section("Parameters")]
									;
								public sealed partial class Parameters : Scope {
									public sealed partial class value : Scope {
										public static IElement RawDeclarationCode => new Text($"{Type(Api.Antilatency.DeviceNetwork.Interop.Memory.Memory4.FullNameRef)} {Name}");public static IElement Name => new Modify($"value").SetAttributeValue("title", "parameter value");
									} //scope value
								} //scope Parameters
							} //scope byte4
							public sealed partial class byte8 : Scope {
								public static IElement NameRef => new ContentReplace(FullNameRef, $"byte8");
								public static MultiLanguageGroup FullNameRef => new MultiLanguageGroup("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.byte8");
								public static IElement RawDeclarationCode => new Text($"{Type("void")} {NameRef}({Parameters.value.RawDeclarationCode})");
								private static Material FullNameRef_en => new Material("Antilatency\u200B.DeviceNetwork\u200B.Tasks\u200B.Tests\u200B.BytesFlow\u200B.IDeviceToHost\u200B.byte8",null,$"Method of `{Type(Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.FullNameRef)}`\n`{Type("void")} {NameRef}({Parameters.value.RawDeclarationCode})`")
									[new Section("Parameters")]
									;
								public sealed partial class Parameters : Scope {
									public sealed partial class value : Scope {
										public static IElement RawDeclarationCode => new Text($"{Type(Api.Antilatency.DeviceNetwork.Interop.Memory.Memory8.FullNameRef)} {Name}");public static IElement Name => new Modify($"value").SetAttributeValue("title", "parameter value");
									} //scope value
								} //scope Parameters
							} //scope byte8
							public sealed partial class byte16 : Scope {
								public static IElement NameRef => new ContentReplace(FullNameRef, $"byte16");
								public static MultiLanguageGroup FullNameRef => new MultiLanguageGroup("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.byte16");
								public static IElement RawDeclarationCode => new Text($"{Type("void")} {NameRef}({Parameters.value.RawDeclarationCode})");
								private static Material FullNameRef_en => new Material("Antilatency\u200B.DeviceNetwork\u200B.Tasks\u200B.Tests\u200B.BytesFlow\u200B.IDeviceToHost\u200B.byte16",null,$"Method of `{Type(Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.FullNameRef)}`\n`{Type("void")} {NameRef}({Parameters.value.RawDeclarationCode})`")
									[new Section("Parameters")]
									;
								public sealed partial class Parameters : Scope {
									public sealed partial class value : Scope {
										public static IElement RawDeclarationCode => new Text($"{Type(Api.Antilatency.DeviceNetwork.Interop.Memory.Memory16.FullNameRef)} {Name}");public static IElement Name => new Modify($"value").SetAttributeValue("title", "parameter value");
									} //scope value
								} //scope Parameters
							} //scope byte16
							public sealed partial class byte32 : Scope {
								public static IElement NameRef => new ContentReplace(FullNameRef, $"byte32");
								public static MultiLanguageGroup FullNameRef => new MultiLanguageGroup("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.byte32");
								public static IElement RawDeclarationCode => new Text($"{Type("void")} {NameRef}({Parameters.value.RawDeclarationCode})");
								private static Material FullNameRef_en => new Material("Antilatency\u200B.DeviceNetwork\u200B.Tasks\u200B.Tests\u200B.BytesFlow\u200B.IDeviceToHost\u200B.byte32",null,$"Method of `{Type(Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.FullNameRef)}`\n`{Type("void")} {NameRef}({Parameters.value.RawDeclarationCode})`")
									[new Section("Parameters")]
									;
								public sealed partial class Parameters : Scope {
									public sealed partial class value : Scope {
										public static IElement RawDeclarationCode => new Text($"{Type(Api.Antilatency.DeviceNetwork.Interop.Memory.Memory32.FullNameRef)} {Name}");public static IElement Name => new Modify($"value").SetAttributeValue("title", "parameter value");
									} //scope value
								} //scope Parameters
							} //scope byte32
							public sealed partial class byte64 : Scope {
								public static IElement NameRef => new ContentReplace(FullNameRef, $"byte64");
								public static MultiLanguageGroup FullNameRef => new MultiLanguageGroup("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.byte64");
								public static IElement RawDeclarationCode => new Text($"{Type("void")} {NameRef}({Parameters.value.RawDeclarationCode})");
								private static Material FullNameRef_en => new Material("Antilatency\u200B.DeviceNetwork\u200B.Tasks\u200B.Tests\u200B.BytesFlow\u200B.IDeviceToHost\u200B.byte64",null,$"Method of `{Type(Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.FullNameRef)}`\n`{Type("void")} {NameRef}({Parameters.value.RawDeclarationCode})`")
									[new Section("Parameters")]
									;
								public sealed partial class Parameters : Scope {
									public sealed partial class value : Scope {
										public static IElement RawDeclarationCode => new Text($"{Type(Api.Antilatency.DeviceNetwork.Interop.Memory.Memory64.FullNameRef)} {Name}");public static IElement Name => new Modify($"value").SetAttributeValue("title", "parameter value");
									} //scope value
								} //scope Parameters
							} //scope byte64
							public sealed partial class byte128 : Scope {
								public static IElement NameRef => new ContentReplace(FullNameRef, $"byte128");
								public static MultiLanguageGroup FullNameRef => new MultiLanguageGroup("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.byte128");
								public static IElement RawDeclarationCode => new Text($"{Type("void")} {NameRef}({Parameters.value.RawDeclarationCode})");
								private static Material FullNameRef_en => new Material("Antilatency\u200B.DeviceNetwork\u200B.Tasks\u200B.Tests\u200B.BytesFlow\u200B.IDeviceToHost\u200B.byte128",null,$"Method of `{Type(Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.FullNameRef)}`\n`{Type("void")} {NameRef}({Parameters.value.RawDeclarationCode})`")
									[new Section("Parameters")]
									;
								public sealed partial class Parameters : Scope {
									public sealed partial class value : Scope {
										public static IElement RawDeclarationCode => new Text($"{Type(Api.Antilatency.DeviceNetwork.Interop.Memory.Memory128.FullNameRef)} {Name}");public static IElement Name => new Modify($"value").SetAttributeValue("title", "parameter value");
									} //scope value
								} //scope Parameters
							} //scope byte128
							public sealed partial class byte255 : Scope {
								public static IElement NameRef => new ContentReplace(FullNameRef, $"byte255");
								public static MultiLanguageGroup FullNameRef => new MultiLanguageGroup("Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.byte255");
								public static IElement RawDeclarationCode => new Text($"{Type("void")} {NameRef}({Parameters.value.RawDeclarationCode})");
								private static Material FullNameRef_en => new Material("Antilatency\u200B.DeviceNetwork\u200B.Tasks\u200B.Tests\u200B.BytesFlow\u200B.IDeviceToHost\u200B.byte255",null,$"Method of `{Type(Api.Antilatency.DeviceNetwork.Tasks.Tests.BytesFlow.IDeviceToHost.FullNameRef)}`\n`{Type("void")} {NameRef}({Parameters.value.RawDeclarationCode})`")
									[new Section("Parameters")]
									;
								public sealed partial class Parameters : Scope {
									public sealed partial class value : Scope {
										public static IElement RawDeclarationCode => new Text($"{Type(Api.Antilatency.DeviceNetwork.Interop.Memory.Memory255.FullNameRef)} {Name}");public static IElement Name => new Modify($"value").SetAttributeValue("title", "parameter value");
									} //scope value
								} //scope Parameters
							} //scope byte255
						} //scope IDeviceToHost
						
						
					} //scope BytesFlow
				} //scope Tests
			} //scope Tasks
		} //scope DeviceNetwork
	} //scope Antilatency
} //scope Api

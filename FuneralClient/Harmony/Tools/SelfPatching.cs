using Harmony.ILCopying;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace Harmony.Tools
{
	internal class SelfPatching
	{
		static readonly int upgradeToLatestVersionFullNameHash = typeof(UpgradeToLatestVersion).FullName.GetHashCode();

		[UpgradeToLatestVersion(1)]
		static int GetVersion(MethodBase method)
		{
			var attribute = method.GetCustomAttributes(false)
				.Where(attr => attr.GetType().FullName.GetHashCode() == upgradeToLatestVersionFullNameHash)
				.FirstOrDefault();
			if (attribute == null)
				return -1;
			return Traverse.Create(attribute).Field("version").GetValue<int>();
		}

		[UpgradeToLatestVersion(1)]
		static string MethodKey(MethodBase method)
		{
			return method.FullDescription();
		}

		[UpgradeToLatestVersion(1)]
		static bool IsHarmonyAssembly(Assembly assembly)
		{
			try
			{
				return assembly.ReflectionOnly == false && assembly.GetType(typeof(HarmonyInstance).FullName) != null;
			}
			catch (Exception)
			{
				return false;
			}
		}

		private static List<MethodBase> GetAllMethods(Assembly assembly)
		{
            return null;
		}

		private static string AssemblyInfo(Assembly assembly)
		{
			var version = assembly.GetName().Version;
			var location = assembly.Location;
			if (location == null || location == "") location = new Uri(assembly.CodeBase).LocalPath;
			return location + "(v" + version + (assembly.GlobalAssemblyCache ? ", cached" : "") + ")";
		}

		[UpgradeToLatestVersion(1)]
		public static void PatchOldHarmonyMethods()
		{

		}
	}
}
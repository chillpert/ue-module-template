using UnrealBuildTool;

public class Utils : ModuleRules
{
	public Utils(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		/**
		 * The difference between public and private dependencies is outlined in the example below.
		 */
		PublicDependencyModuleNames.AddRange(new string[] { "Engine", "Core" });

		/**
		 * If only your module's sources or private headers require a dependency's header, make it private.
		 * Private dependencies are preferred as they reduce compile times.
		 *
		 * Use forward declare when possible so that you only have to include some header in the respective source file.
		 * But don't forward declare entire function definitions or structs.
		 */
		// PrivateDependencyModuleNames.AddRange(new string[] { "Core" });

		/**
		 * Consider the following case: 
		 *
		 * There are three modules: MyMainModule, Utils, Engine.
		 * If the Utils module were to privately depend on the engine module instead, MyMainModule (any module that will be using ExposedActor)
		 * would only get ExposedActor but not Actor itself and would get a compile error.
		 * However, even in the way this build file is set up, MyMainModule would still not link against source files from the engine module.
		 * But instead only the specific objects that are required, e.g. a specific function.
		 *
		 * So use public dependencies for any external includes in our public headers.
		 *
		 * Also note that there is no difference between public and privat dependencies between two modules like MyMainModule and Utils if Utils
		 * doesn't have any private dependencies itself.
		 */

		PublicIncludePaths.AddRange(new string[] { "Utils/Public" });
		PrivateIncludePaths.AddRange(new string[] { "Utils/Private" });
	}
}

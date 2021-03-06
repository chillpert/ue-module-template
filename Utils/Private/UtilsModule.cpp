#include "UtilsModule.h"

#include "Modules/ModuleManager.h"

IMPLEMENT_GAME_MODULE(FDefaultModuleImpl, Utils);

/**
 * This file exposes Utils 'main class' to the rest of the engine.
 * The 'main class' could be an empty class you define yourself.
 * Alternatively, you can just use FDefaultModuleImpl which lets Unreal take care of it (as with this file).
 *
 * The 'main class' basically acts like a global singleton. It can be used from anywhere as long as the module is loaded.
 * Simly use:
 * FModuleManager::Get().LoadModuleChecked<FUtilsModule>(TEXT("Utils")).DoFoo();
 *
 * This could theoretically be added to any source file of the module but let's follow the conventions.
 *
 * ModuleManager is part of the core module. That's why it's always required as a dependency.
 *
 * For game modules use IMPLEMENT_GAME_MODULE instead.
 * For the primary game module use IMPLEMENT_PRIMARY_GAME_MODULE. This one will be generated by default when creating an Unreal
 * project.
 * Note that you usually only have one gameplay module in your project: the primary gameplay module. So this will probably not
 * matter.
 * Avoid gameplay modules as they have extra hot-reloading overhead. One useful exception might be an automation module for testing
 * your gameplay code.
 */

# How to add a new module to your project

1. Place 'Example' folder in your projects 'Source' folder.
2. Rename every occurrence of 'Example' in the provided files to 'NewModuleName'.
## This step might only be necessary if you want to see the module inside UE4Editor. Requires further investigation.
3. Add 'NewModuleName' to 'ExtraModuleNames' in both 'MyProjectName.Target.cs' and 'MyProjectNameEditor.Target.cs' inside the 'Source' folder.
4. Close the editor.
5. Regenerate project files (by right-clicking the .uproject file) or build the project (e.g. with [ue4cli](https://github.com/adamrehn/ue4cli)).
6. Start the editor.
7. Add a new class to the module from within the editor (ignore the compile error).
8. Close the editor.
9. Delete the 'Binaries' and 'Intermediate' folders inside of your project root directory.
10. Repeat step 5.
11. Start the editor and you will see a new folder in 'C++ Classes' for your newly added module.

**Make sure that when you include any UE header that you have its respective module included as a dependency.**

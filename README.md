# NKHook6 Example Mod
An example mod template to use for your Bloons TD 6 mod using NKHook6


## Project setup
This Example Mod uses CMake, which may seem scary at first. Most modders are farmiliar with Microsoft's Visual Studio project setup using a .sln file for the solution, or a .csproj for a single project, or both used together.

Using CMake provides some advantages that the traditional setup doesn't allow.
- Faster
- Cleaner
- Freedom in project structure
- CMake generates the project around how you use it

Let me elaborate on that last part. That is one huge reason this project uses CMake. With the CMake setup for the standard NKHook6 Implementation, we need the implementation to include the API code. Doing this with the standard setup can be very messy and annoying to work with. With CMake, its a different story, we can simply add the submodule and build the code into the main implementation, while still maintaining the API as a seperate project with its own repository.

Most of you probably won't care about these things either way, but it's important to know what you're working with when using this as an example for your project.

## Setup
This section is to help you get your build system setup.

This project requires [CMake](https://cmake.org/), [.Net Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework) or newer, as well as an IDE. I'd advise [Visual Studio Code](https://code.visualstudio.com/) but almost anything will work.
**If you still have issues with building, consider installing [Visual Studio Community](https://visualstudio.microsoft.com/)**

Now that you have your tools set up, lets get building!

### CMake Cache
Before we can do anything, we must set up the CMake Cache. This is for cmake to use to build our project. We only have to do this once, but you may do it as many times as you please.
To generate the CMake cache, do the following command in a Terminal or Command Prompt window.
```cmake .```

### Building
Now that the cache is ready, we can build. There are 2 different types of builds that we care about: **Debug** and **Release**.

Debug is good for testing your mod to ensure it is working as expected. To build with Debug, use the following command:
```cmake --build .```

Release is used for when you want to share your mod with the world and have other people use it. To build with Release, use the following command:
```cmake --build . --config Release```


## Conclusion
Cool! You should now have a good understanding of this project structure and how to make mods with it. Happy modding!
# Set cmake version & make project
cmake_minimum_required(VERSION 3.17)
project(ExampleMod VERSION 1.0.0 LANGUAGES CSharp)

# Create .dll
add_library(ExampleMod SHARED)

# Set the C# language version to 9
set_target_properties(ExampleMod PROPERTIES VS_GLOBAL_LangVersion "9.0")

# Set project properties
set_property(TARGET ExampleMod PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION "v4.8")
set_property(TARGET ExampleMod PROPERTY WIN32_EXECUTABLE FALSE)
set_property(TARGET ExampleMod PROPERTY VS_CONFIGURATION_TYPE ClassLibrary)
set_property(TARGET ExampleMod PROPERTY VS_DOTNET_REFERENCES_COPY_LOCAL OFF)

# Add sources
target_sources(ExampleMod PRIVATE
    "Entry.cs"
    "Events.cs"
)
add_subdirectory(Properties)
add_subdirectory(References)
# Adds references to the project
set_property(TARGET ExampleMod PROPERTY VS_DOTNET_REFERENCES
    # Adds NKHook6 to the references to be added
    ${CMAKE_CURRENT_LIST_DIR}/NKHook6.dll;
    # Adds MelonLoader to the references
    ${CMAKE_CURRENT_LIST_DIR}/MelonLoader.dll;
)
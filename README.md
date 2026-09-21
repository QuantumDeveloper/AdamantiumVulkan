# AdamantiumVulkan

C# bindings to the Vulkan API, generated from the Khronos registry, with hand-written wrappers over the generated
interop so that calling Vulkan reads as C# rather than as marshalling.

The Vulkan bindings come from `vk.xml` and `video.xml` - the registry Khronos publishes as the specification's own
machine-readable form - so extensions, aliases, enum extensions and the structure chains arrive as the registry
defines them rather than as a parse of the headers happened to see them.

The other three packages have no registry to read from, so their bindings are generated from the C headers by
[QuantumBinding](https://github.com/QuantumDeveloper/QuantumBinding), which parses through Clang's own front end
rather than a bespoke parser: macros, bitfields, anonymous unions and platform conditionals mean there what they
mean to a C compiler.

These packages are what the [Adamantium](https://github.com/QuantumDeveloper/Adamantium) engine is built on, but they
carry no dependency on it and can be used on their own.

## Packages

| Package | What it is |
|---|---|
| [`Adamantium.Vulkan`](https://www.nuget.org/packages/Adamantium.Vulkan) | The bindings themselves: structures, handles, enums and commands |
| [`Adamantium.Vulkan.Loader`](https://www.nuget.org/packages/Adamantium.Vulkan.Loader) | Finds the Vulkan loader at run time and resolves its entry points |
| [`Adamantium.Vulkan.Slang`](https://www.nuget.org/packages/Adamantium.Vulkan.Slang) | Bindings to the Slang shader compiler, shipping the compiler itself |
| [`Adamantium.Vulkan.Spirv`](https://www.nuget.org/packages/Adamantium.Vulkan.Spirv) | Bindings to SPIRV-Cross, for reading back what a compiled shader declares |

```
dotnet add package Adamantium.Vulkan
dotnet add package Adamantium.Vulkan.Loader
```

## Requirements

- **.NET 10** or later. The shader packages also target `netstandard2.0`.
- **x64.** The projects build for that platform only; other architectures have not been tried.
- **A Vulkan driver** on the machine at run time. No SDK is needed to build: the loader resolves the driver's own
  library, and the Slang package carries the shader compiler with it.

## Why the loader is a separate package

`Adamantium.Vulkan.Loader` resolves Vulkan at run time instead of linking an import library at build time. An
application therefore binds to whichever Vulkan the machine actually has, and a machine without one fails with an
error you can catch rather than refusing to start.

## Third-party binaries

The Slang and SPIRV-Cross packages ship compiled binaries of projects that are not ours - among them the Slang
compiler (Apache-2.0 with the LLVM exception, itself carrying glslang, SPIRV-Tools, LLVM, mimalloc and lz4),
SPIRV-Cross and SPIRV-Tools (Apache-2.0, Khronos). Every one of those licences is permissive, and the notices travel
with the binaries in
[THIRD-PARTY-NOTICES.md](https://github.com/QuantumDeveloper/AdamantiumVulkan/blob/master/THIRD-PARTY-NOTICES.md).

Nothing here derives from the Vulkan logo or any other Khronos trademark.

## Building from source

```
git clone https://github.com/QuantumDeveloper/AdamantiumVulkan
cd AdamantiumVulkan
dotnet build Adamantium.Vulkan/Adamantium.Vulkan.csproj -c Release -p:Platform=x64
```

The four published projects build from a clone on their own. **Regenerating the bindings** - which is only needed when
the Vulkan registry moves - additionally requires
[QuantumBinding](https://github.com/QuantumDeveloper/QuantumBinding) cloned beside this repository, because
`Adamantium.Vulkan.Generator` uses it directly:

```
<parent>/
  AdamantiumVulkan/
  QuantumBinding/
```

## Status

In use, and under active development alongside the engine that depends on it. The API follows the Vulkan registry, so
it changes when the registry does.

## Licence

[Apache-2.0](https://github.com/QuantumDeveloper/AdamantiumVulkan/blob/master/LICENSE).

# Third-party notices

This repository **redistributes compiled binaries of other people's projects** alongside its own code. That is
permitted by their licences — all of them permissive — on one condition: the notices travel with the binaries. This
file is that notice.

Listed here is what ships in the repository as a build output of someone else. Packages consumed through NuGet are
not listed: those carry their own licences with them and are not redistributed here.

**On versions.** These binaries were taken from upstream release builds, and the repository does not record which
build each came from. Where a filename carries a version it is named below; otherwise treat the entry as covering
whatever build is committed. This is worth fixing — see the note at the end.

---

## Slang — shader compiler

**Where:** `Adamantium.Vulkan.Slang/` — `slang.dll`, `slang-compiler.dll`, `slang-glslang.dll`, `slang-c-shared.dll`

The compiler that turns this engine's shaders into SPIR-V. Shipped so that building shaders needs no Vulkan SDK
installed.

Slang is licensed under the **Apache License 2.0 with LLVM exception**. The Apache-2.0 text is in `LICENSE` at the
root of this repository; the LLVM exception adds to it:

```
---- LLVM Exceptions to the Apache 2.0 License ----

As an exception, if, as a result of your compiling your source code, portions
of this Software are embedded into an Object form of such source code, you
may redistribute such embedded portions in such Object form without complying
with the conditions of Sections 4(a), 4(b) and 4(d) of the License.

In addition, if you combine or link compiled forms of this Software with
software that is licensed under the GPLv2 ("Combined Software") and if a
court of competent jurisdiction determines that the patent provision (Section
3), the indemnity provision (Section 9) or other Section of the License
conflicts with the conditions of the GPLv2, you may retroactively and
prospectively choose to deem waived or otherwise exclude such Section(s) of
the License, but only in their entirety and only with respect to the Combined
Software.
```

**Slang bundles further projects inside these binaries**, each under its own licence — among them glslang (BSD),
SPIRV-Tools (Apache-2.0), SPIRV-Headers (modified MIT), LLVM (Apache-2.0 with LLVM exception), mimalloc (MIT) and
lz4 (BSD). `slang-glslang.dll` is glslang as Slang ships it. The authoritative and complete list is the `LICENSE`
file of the Slang release these binaries came from.

Upstream: https://github.com/shader-slang/slang

---

## SPIRV-Cross — SPIR-V reflection and cross-compilation

**Where:** `Adamantium.Vulkan.Spirv/` — `spirv-cross-c-shared.dll`, `libspirv-cross-c-shared.dylib`,
`libspirv-cross-c-shared.so.0.49.0` (the Linux build names version 0.49.0)

Used to read back what a compiled shader declares, so the engine can bind resources by what the shader actually asks
for rather than by a hand-kept table.

A Khronos Group project, licensed under the **Apache License 2.0** — text in `LICENSE` at the root of this
repository.

Upstream: https://github.com/KhronosGroup/SPIRV-Cross

---

## SPIRV-Tools

**Where:** `Adamantium.Vulkan.SpirvTools/SPIRV-Tools-shared.dll`

Assembly, disassembly, validation and optimisation of SPIR-V modules.

A Khronos Group project, licensed under the **Apache License 2.0** — text in `LICENSE` at the root of this
repository.

Upstream: https://github.com/KhronosGroup/SPIRV-Tools

---

## XmlSchemaClassGenerator and its dependencies

**Where:** `XmlSchemaClassGenerator.2.0.254/`

Build-time tooling used by the Vulkan binding generator to turn the Vulkan XML registry into C# types. Not part of
anything this repository produces at runtime — it runs only when the bindings are regenerated.

### XmlSchemaClassGenerator

`XmlSchemaClassGenerator.dll` — licensed under the **Apache License 2.0**, text in `LICENSE` at the root of this
repository.

Upstream: https://github.com/mganss/XmlSchemaClassGenerator

### Glob

`Glob.dll` — MIT.

```
The MIT License (MIT)

Copyright (c) 2013-2019 Kevin Thompson

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
the Software, and to permit persons to whom the Software is furnished to do so,
subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
```

Upstream: https://github.com/kthompson/glob

### Mono.Options

`Mono.Options.dll` — MIT.

```
Copyright (C) 2008 Novell (http://www.novell.com)
Copyright (C) 2009 Federico Di Gregorio.
Copyright (C) 2012 Xamarin Inc (http://www.xamarin.com)
Copyright (C) 2017 Microsoft Corporation (http://www.microsoft.com)

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
```

Upstream: https://github.com/mono/mono/tree/main/mcs/class/Mono.Options

### System.IO.Abstractions

`System.IO.Abstractions.dll` — MIT, copyright © Tatham Oddie & friends, maintained by TestableIO. The MIT text is
the one reproduced above for Glob, with that copyright line in place of Kevin Thompson's.

Upstream: https://github.com/TestableIO/System.IO.Abstractions

---

## Not third-party

For the avoidance of doubt, these committed binaries are this project's own and are covered by the repository's
`LICENSE`: `QuantumBinding.Generator.dll`, `Adamantium.Core.dll`, `Adamantium.Imaging.dll`,
`Adamantium.Mathematics.dll`.

---

## Worth fixing

Committing other people's binaries is what makes this file necessary. Two of these entries need not exist:

- **`XmlSchemaClassGenerator.2.0.254/` is an unpacked NuGet package.** Consuming it as a `PackageReference` would
  remove five binaries and their notices from this repository outright.
- **The Slang, SPIRV-Cross and SPIRV-Tools binaries are genuinely redistributed** — they ship so that building needs
  no Vulkan SDK, which is a deliberate and good property. They should stay, but the upstream release version of each
  ought to be recorded next to them, so this file can name it.

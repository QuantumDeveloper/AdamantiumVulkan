using System;
using System.Collections.Generic;

namespace AdamantiumVulkan.Generator.Parser.Schema;

public class VulkanRegistry
{
    public HashSet<string> VendorTags = new();
    public Dictionary<string, string> BaseTypes = new();
    public Dictionary<string, VkConstant> Constants = new();
    public Dictionary<string, string> FlagsToBitsMap = new();
    public Dictionary<string, VkEnum> Enums = new();
    public Dictionary<string, VkHandle> Handles = new();
    public Dictionary<string, VkStruct> Structs = new();
    public Dictionary<string, VkStruct> Unions = new();
    public Dictionary<string, VkCommand> Commands = new();
    public Dictionary<string, VkDelegate> Delegates = new();
    public HashSet<string> ForbiddenVideoTypes { get; } = new(StringComparer.OrdinalIgnoreCase);
    public HashSet<string> VideoExtensions { get; } = new(StringComparer.OrdinalIgnoreCase);
    public Dictionary<string, VkExtension> Extensions = new();
    public Dictionary<string, string> ExtensionPlatformMap = new();
    public Dictionary<string, string> TypeToExtensionMap = new();
    public Dictionary<string, VkTypedef> Typedefs = new();
    public Dictionary<string, HashSet<string>> AliasGroups = new();
    public Dictionary<string, string> Aliases { get; } = new();
    public Dictionary<string, string> CanonicalTypeMap = new();
    public Dictionary<string, string> AliasesForGlobalUsings { get; set; } = new();
    public Dictionary<string, string> HandleParents { get; } = new();
}

public enum ExtensionType
{
    Instance,
    Device
}
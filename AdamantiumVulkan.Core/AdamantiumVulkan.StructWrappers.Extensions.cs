using System;
using System.Collections.Generic;
using AdamantiumVulkan.Core.Interop;

namespace AdamantiumVulkan.Core
{
    public partial class PipelineRasterizationStateCreateInfo : ICloneable
    {
        public static PipelineRasterizationStateCreateInfo Default()
        {
            var state = new PipelineRasterizationStateCreateInfo();
            state.DepthClampEnable = VkBool32.FALSE;
            state.RasterizerDiscardEnable = VkBool32.FALSE;
            state.PolygonMode = PolygonMode.Fill;
            state.LineWidth = 1.0f;
            state.CullMode = CullModeFlagBits.BackBit;
            state.FrontFace = FrontFace.Clockwise;
            state.DepthBiasEnable = VkBool32.FALSE;

            return state;
        }

        public object Clone()
        {
            var clone = new PipelineRasterizationStateCreateInfo();
            clone.Flags = Flags;
            clone.DepthClampEnable = DepthClampEnable;
            clone.RasterizerDiscardEnable = RasterizerDiscardEnable;
            clone.PolygonMode = PolygonMode;
            clone.LineWidth = LineWidth;
            clone.CullMode = CullMode;
            clone.FrontFace = FrontFace;
            clone.DepthBiasEnable = DepthBiasEnable;
            return clone;
        }
    }

    public partial class PipelineDepthStencilStateCreateInfo : ICloneable
    {
        public static PipelineDepthStencilStateCreateInfo Default()
        {
            var state = new PipelineDepthStencilStateCreateInfo();
            state.DepthTestEnable = VkBool32.FALSE;
            state.DepthWriteEnable = VkBool32.TRUE;
            state.DepthCompareOp = CompareOp.Less;
            state.DepthBoundsTestEnable = VkBool32.FALSE;
            state.MinDepthBounds = 0.0f;
            state.MaxDepthBounds = 1.0f;
            state.StencilTestEnable = VkBool32.TRUE;
            state.Front = new StencilOpState() { CompareOp = CompareOp.Always, DepthFailOp = StencilOp.Keep, FailOp = StencilOp.Keep, PassOp = StencilOp.Keep };
            state.Back = new StencilOpState() { CompareOp = CompareOp.Always, DepthFailOp = StencilOp.Keep, FailOp = StencilOp.Keep, PassOp = StencilOp.Keep };
            return state;
        }

        public object Clone()
        {
            var clone = new PipelineDepthStencilStateCreateInfo();
            clone.Flags = Flags;
            clone.DepthTestEnable = DepthTestEnable;
            clone.DepthWriteEnable = DepthWriteEnable;
            clone.DepthCompareOp = DepthCompareOp;
            clone.DepthBoundsTestEnable = DepthBoundsTestEnable;
            clone.MinDepthBounds = MinDepthBounds;
            clone.MaxDepthBounds = MaxDepthBounds;
            clone.StencilTestEnable = StencilTestEnable;
            clone.Front = (StencilOpState)Front.Clone();
            clone.Back = (StencilOpState)Back.Clone();
            return clone;
        }
    }

    public partial class PipelineColorBlendStateCreateInfo: ICloneable
    {
        public static PipelineColorBlendStateCreateInfo Default()
        {
            var colorBlendAttachment = new PipelineColorBlendAttachmentState();
            colorBlendAttachment.ColorWriteMask = (ColorComponentFlagBits.RBit | ColorComponentFlagBits.GBit | ColorComponentFlagBits.BBit | ColorComponentFlagBits.ABit);
            colorBlendAttachment.BlendEnable = VkBool32.FALSE;

            var state = new PipelineColorBlendStateCreateInfo();
            state.LogicOpEnable = VkBool32.FALSE;
            state.LogicOp = LogicOp.Copy;
            state.AttachmentCount = 1;
            state.PAttachments = new [] { colorBlendAttachment };
            state.BlendConstants = new float[4];
            state.BlendConstants[0] = 0.0f;
            state.BlendConstants[1] = 0.0f;
            state.BlendConstants[2] = 0.0f;
            state.BlendConstants[3] = 0.0f;

            return state;
        }

        public object Clone()
        {
            var colorBlenAttachments = new List<PipelineColorBlendAttachmentState>();
            foreach (var attachment in PAttachments)
            {
                var colorBlendAttachment = (PipelineColorBlendAttachmentState)attachment.Clone();
                colorBlenAttachments.Add(colorBlendAttachment);
            }

            var clone = new PipelineColorBlendStateCreateInfo();
            clone.Flags = Flags;
            clone.LogicOpEnable = LogicOpEnable;
            clone.LogicOp = LogicOp.Copy;
            clone.AttachmentCount = AttachmentCount;
            clone.PAttachments = colorBlenAttachments.ToArray();
            clone.BlendConstants = new float[BlendConstants.Length];
            for (int i = 0; i < clone.BlendConstants.Length; ++i)
            {
                clone.BlendConstants[i] = BlendConstants[i];
            }

            return clone;
        }
    }

    public partial class PipelineColorBlendAttachmentState : ICloneable
    {
        public override int GetHashCode()
        {
            int hashCode = ColorWriteMask.GetHashCode();
            hashCode = (hashCode * 397) ^ BlendEnable.GetHashCode();
            hashCode = (hashCode * 397) ^ AlphaBlendOp.GetHashCode();
            hashCode = (hashCode * 397) ^ ColorBlendOp.GetHashCode();
            hashCode = (hashCode * 397) ^ SrcAlphaBlendFactor.GetHashCode();
            hashCode = (hashCode * 397) ^ SrcColorBlendFactor.GetHashCode();
            hashCode = (hashCode * 397) ^ DstAlphaBlendFactor.GetHashCode();
            hashCode = (hashCode * 397) ^ DstColorBlendFactor.GetHashCode();
            return hashCode;
        }

        public object Clone()
        {
            var clone = new PipelineColorBlendAttachmentState();
            clone.ColorWriteMask = ColorWriteMask;
            clone.BlendEnable = BlendEnable;
            clone.AlphaBlendOp = AlphaBlendOp;
            clone.ColorBlendOp = ColorBlendOp;
            clone.SrcAlphaBlendFactor = SrcAlphaBlendFactor;
            clone.SrcColorBlendFactor = SrcColorBlendFactor;
            clone.DstAlphaBlendFactor = DstAlphaBlendFactor;
            clone.DstColorBlendFactor = DstColorBlendFactor;

            return clone;
        }
    }

    public partial class StencilOpState : ICloneable
    {
        public override int GetHashCode()
        {
            int hashCode = FailOp.GetHashCode();
            hashCode = (hashCode * 397) ^ PassOp.GetHashCode();
            hashCode = (hashCode * 397) ^ DepthFailOp.GetHashCode();
            hashCode = (hashCode * 397) ^ CompareOp.GetHashCode();
            hashCode = (hashCode * 397) ^ CompareMask.GetHashCode();
            hashCode = (hashCode * 397) ^ WriteMask.GetHashCode();
            hashCode = (hashCode * 397) ^ Reference.GetHashCode();
            return hashCode;
        }

        public object Clone()
        {
            var clone = new StencilOpState();
            clone.FailOp = FailOp;
            clone.PassOp = PassOp;
            clone.DepthFailOp = DepthFailOp;
            clone.CompareOp = CompareOp;
            clone.CompareMask = CompareMask;
            clone.WriteMask = WriteMask;
            clone.Reference = Reference;

            return clone;
        }
    }

    public partial class Viewport
    {
        public override int GetHashCode()
        {
            int hashCode = X.GetHashCode();
            hashCode = (hashCode * 397) ^ Y.GetHashCode();
            hashCode = (hashCode * 397) ^ Width.GetHashCode();
            hashCode = (hashCode * 397) ^ Height.GetHashCode();
            hashCode = (hashCode * 397) ^ MinDepth.GetHashCode();
            hashCode = (hashCode * 397) ^ MaxDepth.GetHashCode();

            return hashCode;
        }
    }
    
    public partial class Rect2D
    {
        public override int GetHashCode()
        {
            int hashCode = Offset.GetHashCode();
            hashCode = (hashCode * 397) ^ Extent.GetHashCode();

            return hashCode;
        }
    }
    
    public partial class Offset2D
    {
        public override int GetHashCode()
        {
            int hashCode = X.GetHashCode();
            hashCode = (hashCode * 397) ^ Y.GetHashCode();

            return hashCode;
        }
    }
    
    public partial class Extent2D
    {
        public override int GetHashCode()
        {
            int hashCode = Width.GetHashCode();
            hashCode = (hashCode * 397) ^ Height.GetHashCode();

            return hashCode;
        }
    }
}
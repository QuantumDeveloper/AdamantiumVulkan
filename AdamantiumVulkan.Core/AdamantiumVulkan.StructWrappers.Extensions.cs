using System;
using System.Collections.Generic;
using System.Text;

namespace AdamantiumVulkan.Core
{
    public partial class PipelineRasterizationStateCreateInfo
    {
        public static PipelineRasterizationStateCreateInfo Defaults()
        {
            var state = new PipelineRasterizationStateCreateInfo();
            state.DepthClampEnable = false;
            state.RasterizerDiscardEnable = false;
            state.PolygonMode = PolygonMode.Fill;
            state.LineWidth = 1.0f;
            state.CullMode = (uint)CullModeFlagBits.BackBit;
            state.FrontFace = FrontFace.Clockwise;
            state.DepthBiasEnable = false;

            return state;
        }
    }

    public partial class PipelineDepthStencilStateCreateInfo
    {
        public static PipelineDepthStencilStateCreateInfo Defaults()
        {
            return null;
        }
    }
}
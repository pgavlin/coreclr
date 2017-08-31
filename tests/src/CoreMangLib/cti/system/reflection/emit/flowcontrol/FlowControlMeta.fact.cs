using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_flowcontrol_FlowControlMeta_FlowControlMeta_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_flowcontrol_FlowControlMeta_FlowControlMeta_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\flowcontrol\\FlowControlMeta\\FlowControlMeta.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

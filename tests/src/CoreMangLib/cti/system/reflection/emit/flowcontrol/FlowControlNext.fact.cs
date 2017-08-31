using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_flowcontrol_FlowControlNext_FlowControlNext_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_flowcontrol_FlowControlNext_FlowControlNext_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\flowcontrol\\FlowControlNext\\FlowControlNext.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

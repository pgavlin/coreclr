using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_flowcontrol_FlowControlBranch_FlowControlBranch_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_flowcontrol_FlowControlBranch_FlowControlBranch_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\flowcontrol\\FlowControlBranch\\FlowControlBranch.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

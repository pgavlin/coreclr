using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_flowcontrol_FlowControlCall_FlowControlCall_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_flowcontrol_FlowControlCall_FlowControlCall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\flowcontrol\\FlowControlCall\\FlowControlCall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

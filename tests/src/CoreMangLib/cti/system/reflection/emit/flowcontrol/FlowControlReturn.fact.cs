using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_flowcontrol_FlowControlReturn_FlowControlReturn_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_flowcontrol_FlowControlReturn_FlowControlReturn_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\flowcontrol\\FlowControlReturn\\FlowControlReturn.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

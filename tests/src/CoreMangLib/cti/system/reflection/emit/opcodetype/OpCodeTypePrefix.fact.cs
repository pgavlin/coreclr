using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_opcodetype_OpCodeTypePrefix_OpCodeTypePrefix_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_opcodetype_OpCodeTypePrefix_OpCodeTypePrefix_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\opcodetype\\OpCodeTypePrefix\\OpCodeTypePrefix.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

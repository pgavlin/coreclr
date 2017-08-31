using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_opcodes_OpCodeSize_OpCodeSize_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_opcodes_OpCodeSize_OpCodeSize_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\opcodes\\OpCodeSize\\OpCodeSize.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

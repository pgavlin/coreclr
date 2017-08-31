using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_opcodes_OpCodeGetHashCode_OpCodeGetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_opcodes_OpCodeGetHashCode_OpCodeGetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\opcodes\\OpCodeGetHashCode\\OpCodeGetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

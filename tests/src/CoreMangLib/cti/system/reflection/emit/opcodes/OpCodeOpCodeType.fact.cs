using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_opcodes_OpCodeOpCodeType_OpCodeOpCodeType_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_opcodes_OpCodeOpCodeType_OpCodeOpCodeType_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\opcodes\\OpCodeOpCodeType\\OpCodeOpCodeType.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

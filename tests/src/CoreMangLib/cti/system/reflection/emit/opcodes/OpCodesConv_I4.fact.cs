using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_opcodes_OpCodesConv_I4_OpCodesConv_I4_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_opcodes_OpCodesConv_I4_OpCodesConv_I4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\opcodes\\OpCodesConv_I4\\OpCodesConv_I4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

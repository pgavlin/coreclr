using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_opcodes_OpCodesLdarg_S_OpCodesLdarg_S_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_opcodes_OpCodesLdarg_S_OpCodesLdarg_S_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\opcodes\\OpCodesLdarg_S\\OpCodesLdarg_S.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_opcodes_OpCodesLdloc_OpCodesLdloc_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_opcodes_OpCodesLdloc_OpCodesLdloc_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\opcodes\\OpCodesLdloc\\OpCodesLdloc.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_opcodes_OpCodesLdelem_U4_OpCodesLdelem_U4_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_opcodes_OpCodesLdelem_U4_OpCodesLdelem_U4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\opcodes\\OpCodesLdelem_U4\\OpCodesLdelem_U4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

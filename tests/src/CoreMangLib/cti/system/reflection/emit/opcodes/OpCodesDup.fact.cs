using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_opcodes_OpCodesDup_OpCodesDup_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_opcodes_OpCodesDup_OpCodesDup_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\opcodes\\OpCodesDup\\OpCodesDup.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

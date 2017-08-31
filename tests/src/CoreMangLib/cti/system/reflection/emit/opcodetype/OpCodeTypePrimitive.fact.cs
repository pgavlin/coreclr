using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_opcodetype_OpCodeTypePrimitive_OpCodeTypePrimitive_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_opcodetype_OpCodeTypePrimitive_OpCodeTypePrimitive_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\opcodetype\\OpCodeTypePrimitive\\OpCodeTypePrimitive.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

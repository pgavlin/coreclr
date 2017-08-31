using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_operandtype_OperandTypeShortInlineR_OperandTypeShortInlineR_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_operandtype_OperandTypeShortInlineR_OperandTypeShortInlineR_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\operandtype\\OperandTypeShortInlineR\\OperandTypeShortInlineR.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

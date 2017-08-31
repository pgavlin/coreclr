using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_operandtype_OperandTypeInlineNone_OperandTypeInlineNone_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_operandtype_OperandTypeInlineNone_OperandTypeInlineNone_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\operandtype\\OperandTypeInlineNone\\OperandTypeInlineNone.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

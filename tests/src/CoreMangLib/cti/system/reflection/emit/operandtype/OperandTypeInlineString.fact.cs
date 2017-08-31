using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_operandtype_OperandTypeInlineString_OperandTypeInlineString_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_operandtype_OperandTypeInlineString_OperandTypeInlineString_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\operandtype\\OperandTypeInlineString\\OperandTypeInlineString.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

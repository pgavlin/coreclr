using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_operandtype_OperandTypeInlineType_OperandTypeInlineType_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_operandtype_OperandTypeInlineType_OperandTypeInlineType_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\operandtype\\OperandTypeInlineType\\OperandTypeInlineType.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

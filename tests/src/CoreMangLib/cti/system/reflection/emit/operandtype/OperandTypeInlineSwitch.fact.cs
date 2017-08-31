using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_emit_operandtype_OperandTypeInlineSwitch_OperandTypeInlineSwitch_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_emit_operandtype_OperandTypeInlineSwitch_OperandTypeInlineSwitch_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\emit\\operandtype\\OperandTypeInlineSwitch\\OperandTypeInlineSwitch.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

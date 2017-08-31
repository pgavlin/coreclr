using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_diagnostics_conditionalattribute_ConditionalAttributeConditionString_ConditionalAttributeConditionString_
    {
        [OuterLoop]
        [Fact]
        public void _system_diagnostics_conditionalattribute_ConditionalAttributeConditionString_ConditionalAttributeConditionString_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\diagnostics\\conditionalattribute\\ConditionalAttributeConditionString\\ConditionalAttributeConditionString.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

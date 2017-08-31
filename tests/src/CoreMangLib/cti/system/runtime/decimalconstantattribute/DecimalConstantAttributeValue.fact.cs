using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_decimalconstantattribute_DecimalConstantAttributeValue_DecimalConstantAttributeValue_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_decimalconstantattribute_DecimalConstantAttributeValue_DecimalConstantAttributeValue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\decimalconstantattribute\\DecimalConstantAttributeValue\\DecimalConstantAttributeValue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

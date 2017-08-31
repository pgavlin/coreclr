using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_decimalconstantattribute_DecimalConstantAttributeCtor_DecimalConstantAttributeCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_decimalconstantattribute_DecimalConstantAttributeCtor_DecimalConstantAttributeCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\decimalconstantattribute\\DecimalConstantAttributeCtor\\DecimalConstantAttributeCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_attributeusageattribute_AttributeUsageAttributeCtor_AttributeUsageAttributeCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_attributeusageattribute_AttributeUsageAttributeCtor_AttributeUsageAttributeCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\attributeusageattribute\\AttributeUsageAttributeCtor\\AttributeUsageAttributeCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

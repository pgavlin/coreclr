using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_attributeusageattribute_AttributeUsageAttributeAllowMultiple_AttributeUsageAttributeAllowMultiple_
    {
        [OuterLoop]
        [Fact]
        public void _system_attributeusageattribute_AttributeUsageAttributeAllowMultiple_AttributeUsageAttributeAllowMultiple_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\attributeusageattribute\\AttributeUsageAttributeAllowMultiple\\AttributeUsageAttributeAllowMultiple.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

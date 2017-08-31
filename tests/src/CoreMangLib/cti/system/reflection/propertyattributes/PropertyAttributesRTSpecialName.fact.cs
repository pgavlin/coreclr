using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_propertyattributes_PropertyAttributesRTSpecialName_PropertyAttributesRTSpecialName_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_propertyattributes_PropertyAttributesRTSpecialName_PropertyAttributesRTSpecialName_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\propertyattributes\\PropertyAttributesRTSpecialName\\PropertyAttributesRTSpecialName.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

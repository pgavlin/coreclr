using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_propertyattributes_PropertyAttributesSpecialName_PropertyAttributesSpecialName_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_propertyattributes_PropertyAttributesSpecialName_PropertyAttributesSpecialName_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\propertyattributes\\PropertyAttributesSpecialName\\PropertyAttributesSpecialName.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

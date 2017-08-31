using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_propertyattributes_PropertyAttributesNone_PropertyAttributesNone_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_propertyattributes_PropertyAttributesNone_PropertyAttributesNone_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\propertyattributes\\PropertyAttributesNone\\PropertyAttributesNone.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

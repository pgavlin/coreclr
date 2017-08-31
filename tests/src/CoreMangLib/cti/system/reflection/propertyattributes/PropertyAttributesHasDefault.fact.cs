using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_propertyattributes_PropertyAttributesHasDefault_PropertyAttributesHasDefault_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_propertyattributes_PropertyAttributesHasDefault_PropertyAttributesHasDefault_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\propertyattributes\\PropertyAttributesHasDefault\\PropertyAttributesHasDefault.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_fieldattributes_FieldAttributesHasFieldRVA_FieldAttributesHasFieldRVA_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_fieldattributes_FieldAttributesHasFieldRVA_FieldAttributesHasFieldRVA_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\fieldattributes\\FieldAttributesHasFieldRVA\\FieldAttributesHasFieldRVA.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

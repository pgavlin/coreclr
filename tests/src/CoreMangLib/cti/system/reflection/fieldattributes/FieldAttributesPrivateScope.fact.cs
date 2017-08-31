using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_fieldattributes_FieldAttributesPrivateScope_FieldAttributesPrivateScope_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_fieldattributes_FieldAttributesPrivateScope_FieldAttributesPrivateScope_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\fieldattributes\\FieldAttributesPrivateScope\\FieldAttributesPrivateScope.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

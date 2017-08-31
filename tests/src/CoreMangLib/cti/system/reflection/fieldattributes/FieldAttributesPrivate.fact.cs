using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_fieldattributes_FieldAttributesPrivate_FieldAttributesPrivate_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_fieldattributes_FieldAttributesPrivate_FieldAttributesPrivate_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\fieldattributes\\FieldAttributesPrivate\\FieldAttributesPrivate.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

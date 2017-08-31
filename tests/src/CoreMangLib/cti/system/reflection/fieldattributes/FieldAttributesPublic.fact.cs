using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_fieldattributes_FieldAttributesPublic_FieldAttributesPublic_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_fieldattributes_FieldAttributesPublic_FieldAttributesPublic_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\fieldattributes\\FieldAttributesPublic\\FieldAttributesPublic.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

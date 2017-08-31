using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_fieldattributes_FieldAttributesLiteral_FieldAttributesLiteral_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_fieldattributes_FieldAttributesLiteral_FieldAttributesLiteral_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\fieldattributes\\FieldAttributesLiteral\\FieldAttributesLiteral.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

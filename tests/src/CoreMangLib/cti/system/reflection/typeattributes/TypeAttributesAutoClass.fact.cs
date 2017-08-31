using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_typeattributes_TypeAttributesAutoClass_TypeAttributesAutoClass_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_typeattributes_TypeAttributesAutoClass_TypeAttributesAutoClass_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\typeattributes\\TypeAttributesAutoClass\\TypeAttributesAutoClass.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

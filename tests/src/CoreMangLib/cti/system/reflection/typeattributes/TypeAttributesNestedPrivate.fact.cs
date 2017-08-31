using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_typeattributes_TypeAttributesNestedPrivate_TypeAttributesNestedPrivate_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_typeattributes_TypeAttributesNestedPrivate_TypeAttributesNestedPrivate_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\typeattributes\\TypeAttributesNestedPrivate\\TypeAttributesNestedPrivate.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

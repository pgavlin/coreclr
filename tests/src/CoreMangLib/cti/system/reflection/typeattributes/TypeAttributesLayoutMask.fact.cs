using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_typeattributes_TypeAttributesLayoutMask_TypeAttributesLayoutMask_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_typeattributes_TypeAttributesLayoutMask_TypeAttributesLayoutMask_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\typeattributes\\TypeAttributesLayoutMask\\TypeAttributesLayoutMask.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

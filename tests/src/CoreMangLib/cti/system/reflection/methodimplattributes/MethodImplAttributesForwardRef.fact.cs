using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_methodimplattributes_MethodImplAttributesForwardRef_MethodImplAttributesForwardRef_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_methodimplattributes_MethodImplAttributesForwardRef_MethodImplAttributesForwardRef_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\methodimplattributes\\MethodImplAttributesForwardRef\\MethodImplAttributesForwardRef.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

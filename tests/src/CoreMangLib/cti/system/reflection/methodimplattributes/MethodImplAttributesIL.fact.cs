using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_methodimplattributes_MethodImplAttributesIL_MethodImplAttributesIL_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_methodimplattributes_MethodImplAttributesIL_MethodImplAttributesIL_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\methodimplattributes\\MethodImplAttributesIL\\MethodImplAttributesIL.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

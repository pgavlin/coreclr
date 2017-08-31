using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_methodimplattributes_MethodImplAttributesInternalCall_MethodImplAttributesInternalCall_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_methodimplattributes_MethodImplAttributesInternalCall_MethodImplAttributesInternalCall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\methodimplattributes\\MethodImplAttributesInternalCall\\MethodImplAttributesInternalCall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

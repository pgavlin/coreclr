using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_methodimplattributes_MethodImplAttributesNoInlining_MethodImplAttributesNoInlining_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_methodimplattributes_MethodImplAttributesNoInlining_MethodImplAttributesNoInlining_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\methodimplattributes\\MethodImplAttributesNoInlining\\MethodImplAttributesNoInlining.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_methodimplattributes_MethodImplAttributesSynchronized_MethodImplAttributesSynchronized_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_methodimplattributes_MethodImplAttributesSynchronized_MethodImplAttributesSynchronized_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\methodimplattributes\\MethodImplAttributesSynchronized\\MethodImplAttributesSynchronized.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

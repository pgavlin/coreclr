using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_methodattributes_MethodAttributesReuseSlot_MethodAttributesReuseSlot_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_methodattributes_MethodAttributesReuseSlot_MethodAttributesReuseSlot_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\methodattributes\\MethodAttributesReuseSlot\\MethodAttributesReuseSlot.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

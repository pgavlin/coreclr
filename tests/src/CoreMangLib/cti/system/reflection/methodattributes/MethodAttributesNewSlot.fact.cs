using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_methodattributes_MethodAttributesNewSlot_MethodAttributesNewSlot_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_methodattributes_MethodAttributesNewSlot_MethodAttributesNewSlot_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\methodattributes\\MethodAttributesNewSlot\\MethodAttributesNewSlot.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

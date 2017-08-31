using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_methodattributes_MethodAttributesRTSpecialName_MethodAttributesRTSpecialName_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_methodattributes_MethodAttributesRTSpecialName_MethodAttributesRTSpecialName_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\methodattributes\\MethodAttributesRTSpecialName\\MethodAttributesRTSpecialName.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

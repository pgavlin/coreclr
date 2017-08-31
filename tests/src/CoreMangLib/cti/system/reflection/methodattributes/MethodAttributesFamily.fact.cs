using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_methodattributes_MethodAttributesFamily_MethodAttributesFamily_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_methodattributes_MethodAttributesFamily_MethodAttributesFamily_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\methodattributes\\MethodAttributesFamily\\MethodAttributesFamily.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_methodattributes_MethodAttributesAbstract_MethodAttributesAbstract_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_methodattributes_MethodAttributesAbstract_MethodAttributesAbstract_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\methodattributes\\MethodAttributesAbstract\\MethodAttributesAbstract.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _Boxing_variantint_variantint_
    {
        [Fact]
        public void _Boxing_variantint_variantint_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\Boxing\\variantint\\variantint.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

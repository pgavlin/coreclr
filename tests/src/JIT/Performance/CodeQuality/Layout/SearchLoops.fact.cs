using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_Layout_SearchLoops_SearchLoops_
    {
        [Fact]
        public void _CodeQuality_Layout_SearchLoops_SearchLoops_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\Layout\\SearchLoops\\SearchLoops.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

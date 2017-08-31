using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchmarksGame_binarytrees_binarytrees_binarytrees_
    {
        [Fact]
        public void _CodeQuality_BenchmarksGame_binarytrees_binarytrees_binarytrees_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchmarksGame\\binarytrees\\binarytrees\\binarytrees.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

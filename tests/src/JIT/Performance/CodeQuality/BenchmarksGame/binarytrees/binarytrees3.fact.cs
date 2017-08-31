using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchmarksGame_binarytrees_binarytrees3_binarytrees3_
    {
        [Fact]
        public void _CodeQuality_BenchmarksGame_binarytrees_binarytrees3_binarytrees3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchmarksGame\\binarytrees\\binarytrees3\\binarytrees3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

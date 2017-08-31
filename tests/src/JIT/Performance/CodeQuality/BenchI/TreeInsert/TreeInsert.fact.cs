using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchI_TreeInsert_TreeInsert_TreeInsert_
    {
        [Fact]
        public void _CodeQuality_BenchI_TreeInsert_TreeInsert_TreeInsert_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchI\\TreeInsert\\TreeInsert\\TreeInsert.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

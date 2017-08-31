using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Inline_tests_UnsafeBlockCopy_UnsafeBlockCopy_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_UnsafeBlockCopy_UnsafeBlockCopy_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\UnsafeBlockCopy\\UnsafeBlockCopy.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

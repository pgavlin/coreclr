using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _inlining_bug505642_test_test_
    {
        [OuterLoop]
        [Fact]
        public void _inlining_bug505642_test_test_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\inlining\\bug505642\\test\\test.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

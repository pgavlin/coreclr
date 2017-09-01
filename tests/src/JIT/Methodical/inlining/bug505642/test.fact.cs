using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _inlining_bug505642_test_test_
    {
        [OuterLoop]
        [Fact]
        public void _inlining_bug505642_test_test_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\inlining\\bug505642\\test\\test.cmd");
        }
    }
}

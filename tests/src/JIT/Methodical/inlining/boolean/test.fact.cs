using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _inlining_boolean_test_test_
    {
        [OuterLoop]
        [Fact]
        public void _inlining_boolean_test_test_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\inlining\\boolean\\test\\test.cmd");
        }
    }
}

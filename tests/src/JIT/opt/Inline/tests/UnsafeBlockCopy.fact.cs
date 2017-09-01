using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Inline_tests_UnsafeBlockCopy_UnsafeBlockCopy_
    {
        [OuterLoop]
        [Fact]
        public void _Inline_tests_UnsafeBlockCopy_UnsafeBlockCopy_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Inline\\tests\\UnsafeBlockCopy\\UnsafeBlockCopy.cmd");
        }
    }
}

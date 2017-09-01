using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _regress_asurt_143616_foo_foo_
    {
        [OuterLoop]
        [Fact]
        public void _regress_asurt_143616_foo_foo_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\regress\\asurt\\143616\\foo\\foo.cmd");
        }
    }
}

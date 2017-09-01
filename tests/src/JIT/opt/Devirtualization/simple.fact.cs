using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Devirtualization_simple_simple_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_simple_simple_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\simple\\simple.cmd");
        }
    }
}

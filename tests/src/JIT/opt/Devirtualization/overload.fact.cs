using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Devirtualization_overload_overload_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_overload_overload_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\overload\\overload.cmd");
        }
    }
}

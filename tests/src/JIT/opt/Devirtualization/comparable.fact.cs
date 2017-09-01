using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Devirtualization_comparable_comparable_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_comparable_comparable_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\comparable\\comparable.cmd");
        }
    }
}

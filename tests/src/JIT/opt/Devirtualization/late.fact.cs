using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Devirtualization_late_late_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_late_late_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\late\\late.cmd");
        }
    }
}

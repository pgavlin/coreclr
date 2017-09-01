using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Devirtualization_override_override_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_override_override_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\override\\override.cmd");
        }
    }
}

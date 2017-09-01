using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Devirtualization_sealeddefault_sealeddefault_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_sealeddefault_sealeddefault_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\sealeddefault\\sealeddefault.cmd");
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Devirtualization_sealedmethod_sealedmethod_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_sealedmethod_sealedmethod_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\sealedmethod\\sealedmethod.cmd");
        }
    }
}

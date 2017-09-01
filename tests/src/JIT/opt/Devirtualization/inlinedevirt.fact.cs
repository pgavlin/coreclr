using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Devirtualization_inlinedevirt_inlinedevirt_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_inlinedevirt_inlinedevirt_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\inlinedevirt\\inlinedevirt.cmd");
        }
    }
}

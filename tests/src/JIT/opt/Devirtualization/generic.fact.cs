using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _Devirtualization_generic_generic_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_generic_generic_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\generic\\generic.cmd");
        }
    }
}

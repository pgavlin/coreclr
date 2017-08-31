using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Devirtualization_inlinedevirt_inlinedevirt_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_inlinedevirt_inlinedevirt_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\inlinedevirt\\inlinedevirt.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

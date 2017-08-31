using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Devirtualization_late_late_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_late_late_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\late\\late.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

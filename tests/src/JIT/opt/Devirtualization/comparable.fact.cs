using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Devirtualization_comparable_comparable_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_comparable_comparable_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\comparable\\comparable.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

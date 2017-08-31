using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Devirtualization_override_override_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_override_override_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\override\\override.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

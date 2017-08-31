using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Devirtualization_sealeddefault_sealeddefault_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_sealeddefault_sealeddefault_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\sealeddefault\\sealeddefault.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

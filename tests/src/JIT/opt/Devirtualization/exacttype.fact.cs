using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Devirtualization_exacttype_exacttype_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_exacttype_exacttype_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\exacttype\\exacttype.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

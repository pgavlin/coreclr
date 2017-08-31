using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _Devirtualization_enum_enum_
    {
        [OuterLoop]
        [Fact]
        public void _Devirtualization_enum_enum_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\Devirtualization\\enum\\enum.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

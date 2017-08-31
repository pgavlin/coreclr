using CoreclrTestLib;
using Xunit;

namespace JIT_BBT
{
    class _Scenario4_Not_Int32_Not_Int32_
    {
        [OuterLoop]
        [Fact]
        public void _Scenario4_Not_Int32_Not_Int32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\BBT\\Scenario4\\Not-Int32\\Not-Int32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_basics_throwisfirstinstruction_d_throwisfirstinstruction_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwisfirstinstruction_d_throwisfirstinstruction_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwisfirstinstruction_d\\throwisfirstinstruction_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

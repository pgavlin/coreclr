using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_deadoponerror_d_deadoponerror_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_deadoponerror_d_deadoponerror_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\deadoponerror_d\\deadoponerror_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_deadcode_deadoponerror_r_deadoponerror_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_deadoponerror_r_deadoponerror_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\deadoponerror_r\\deadoponerror_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

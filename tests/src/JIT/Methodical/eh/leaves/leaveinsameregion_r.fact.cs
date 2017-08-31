using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_leaveinsameregion_r_leaveinsameregion_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_leaveinsameregion_r_leaveinsameregion_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\leaveinsameregion_r\\leaveinsameregion_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

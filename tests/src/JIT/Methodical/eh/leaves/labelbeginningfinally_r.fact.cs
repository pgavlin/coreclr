using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_labelbeginningfinally_r_labelbeginningfinally_r_
    {
        [Fact]
        public void _eh_leaves_labelbeginningfinally_r_labelbeginningfinally_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\labelbeginningfinally_r\\labelbeginningfinally_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_labelbeforefinally_r_labelbeforefinally_r_
    {
        [Fact]
        public void _eh_leaves_labelbeforefinally_r_labelbeforefinally_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\labelbeforefinally_r\\labelbeforefinally_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

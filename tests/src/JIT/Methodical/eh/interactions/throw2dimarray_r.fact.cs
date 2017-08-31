using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_interactions_throw2dimarray_r_throw2dimarray_r_
    {
        [Fact]
        public void _eh_interactions_throw2dimarray_r_throw2dimarray_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\interactions\\throw2dimarray_r\\throw2dimarray_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

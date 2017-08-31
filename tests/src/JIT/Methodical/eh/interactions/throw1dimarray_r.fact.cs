using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_interactions_throw1dimarray_r_throw1dimarray_r_
    {
        [Fact]
        public void _eh_interactions_throw1dimarray_r_throw1dimarray_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\interactions\\throw1dimarray_r\\throw1dimarray_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

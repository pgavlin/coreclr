using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_mixedhandler_filterfiltercatchcatch_r_filterfiltercatchcatch_r_
    {
        [Fact]
        public void _eh_mixedhandler_filterfiltercatchcatch_r_filterfiltercatchcatch_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\mixedhandler\\filterfiltercatchcatch_r\\filterfiltercatchcatch_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

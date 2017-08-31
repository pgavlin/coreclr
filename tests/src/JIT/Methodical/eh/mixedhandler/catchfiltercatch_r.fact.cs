using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_mixedhandler_catchfiltercatch_r_catchfiltercatch_r_
    {
        [Fact]
        public void _eh_mixedhandler_catchfiltercatch_r_catchfiltercatch_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\mixedhandler\\catchfiltercatch_r\\catchfiltercatch_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

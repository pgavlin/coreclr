using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_arrays__il_dbghugedim__il_dbghugedim_
    {
        [OuterLoop]
        [Fact]
        public void _int64_arrays__il_dbghugedim__il_dbghugedim_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\arrays\\_il_dbghugedim\\_il_dbghugedim.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

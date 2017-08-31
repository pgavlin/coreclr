using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_arrays__il_relhugedim__il_relhugedim_
    {
        [Fact]
        public void _int64_arrays__il_relhugedim__il_relhugedim_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\arrays\\_il_relhugedim\\_il_relhugedim.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

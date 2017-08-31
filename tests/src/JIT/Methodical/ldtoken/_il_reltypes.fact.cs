using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ldtoken__il_reltypes__il_reltypes_
    {
        [Fact]
        public void _ldtoken__il_reltypes__il_reltypes_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ldtoken\\_il_reltypes\\_il_reltypes.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

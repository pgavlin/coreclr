using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ldtoken__il_dbgtypes__il_dbgtypes_
    {
        [Fact]
        public void _ldtoken__il_dbgtypes__il_dbgtypes_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ldtoken\\_il_dbgtypes\\_il_dbgtypes.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

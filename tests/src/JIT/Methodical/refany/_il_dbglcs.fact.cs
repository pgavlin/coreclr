using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__il_dbglcs__il_dbglcs_
    {
        [OuterLoop]
        [Fact]
        public void _refany__il_dbglcs__il_dbglcs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_il_dbglcs\\_il_dbglcs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_misc__speed_dbgselfref__speed_dbgselfref_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_misc__speed_dbgselfref__speed_dbgselfref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\misc\\_speed_dbgselfref\\_speed_dbgselfref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_misc__speed_dbgarrres__speed_dbgarrres_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_misc__speed_dbgarrres__speed_dbgarrres_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\misc\\_speed_dbgarrres\\_speed_dbgarrres.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

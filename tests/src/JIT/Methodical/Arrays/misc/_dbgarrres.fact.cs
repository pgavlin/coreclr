using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_misc__dbgarrres__dbgarrres_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_misc__dbgarrres__dbgarrres_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\misc\\_dbgarrres\\_dbgarrres.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

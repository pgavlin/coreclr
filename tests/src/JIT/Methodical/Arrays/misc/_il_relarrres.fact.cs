using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_misc__il_relarrres__il_relarrres_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_misc__il_relarrres__il_relarrres_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\misc\\_il_relarrres\\_il_relarrres.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

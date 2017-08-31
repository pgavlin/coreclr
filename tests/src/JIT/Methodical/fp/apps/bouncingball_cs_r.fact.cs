using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _fp_apps_bouncingball_cs_r_bouncingball_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _fp_apps_bouncingball_cs_r_bouncingball_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\fp\\apps\\bouncingball_cs_r\\bouncingball_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

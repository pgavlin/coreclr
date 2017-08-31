using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _fp_apps_bouncingball_cs_d_bouncingball_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _fp_apps_bouncingball_cs_d_bouncingball_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\fp\\apps\\bouncingball_cs_d\\bouncingball_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

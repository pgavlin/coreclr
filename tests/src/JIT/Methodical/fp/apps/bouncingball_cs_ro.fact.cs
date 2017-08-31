using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _fp_apps_bouncingball_cs_ro_bouncingball_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _fp_apps_bouncingball_cs_ro_bouncingball_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\fp\\apps\\bouncingball_cs_ro\\bouncingball_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

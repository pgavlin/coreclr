using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _fp_apps_bouncingball_cs_do_bouncingball_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _fp_apps_bouncingball_cs_do_bouncingball_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\fp\\apps\\bouncingball_cs_do\\bouncingball_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

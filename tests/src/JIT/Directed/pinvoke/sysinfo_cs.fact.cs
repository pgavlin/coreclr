using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _pinvoke_sysinfo_cs_sysinfo_cs_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _pinvoke_sysinfo_cs_sysinfo_cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\pinvoke\\sysinfo_cs\\sysinfo_cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _pinvoke_sysinfo_il_sysinfo_il_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _pinvoke_sysinfo_il_sysinfo_il_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\pinvoke\\sysinfo_il\\sysinfo_il.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}

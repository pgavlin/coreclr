using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _pinvoke_sysinfo_il_sysinfo_il_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _pinvoke_sysinfo_il_sysinfo_il_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\pinvoke\\sysinfo_il\\sysinfo_il.cmd");
        }
    }
}

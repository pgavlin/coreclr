using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _pinvoke_calli_excep_calli_excep_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _pinvoke_calli_excep_calli_excep_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\pinvoke\\calli_excep\\calli_excep.cmd");
        }
    }
}

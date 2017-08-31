using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _pinvoke_calli_excep_calli_excep_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _pinvoke_calli_excep_calli_excep_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\pinvoke\\calli_excep\\calli_excep.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
